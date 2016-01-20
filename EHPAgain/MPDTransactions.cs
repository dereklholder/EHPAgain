using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Engines;

namespace OpenEdgeHostPayDemo
{
    public partial class MPDTransactions : Form
    {
        Encoding _encoding;
        IBlockCipherPadding _padding;

        public readonly string Key = "6f70656e65646765686f7374706179DH";

        public MPDTransactions()
        {
            InitializeComponent();
            dbViewer.Controls.Add(txt);
            dbViewer.FullRowSelect = true;
            txt.Leave += (o, e) => txt.Visible = false;

            _encoding = Encoding.ASCII;
            Pkcs7Padding pkcs = new Pkcs7Padding();
            _padding = pkcs;

        }
        private readonly TextBox txt = new TextBox { BorderStyle = BorderStyle.FixedSingle, Visible = false, ReadOnly = true };

        public static string TCC = null;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MPDTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            EHPAgain.MainWindow m = new EHPAgain.MainWindow();
            m.Show();
        }

        private void transactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (transactionTypeCombo.Text)
            {
                case "ACH":
                    tccComboBox.Visible = true;
                    tccLabel.Visible = true;
                    chargeTypeCombo.Items.Clear();
                    chargeTypeCombo.Items.AddRange(new object[]
                    {
                    "DEBIT",
                    "CREDIT"
                    });
                    break;

                case "CREDIT_CARD":
                    tccComboBox.Visible = false;
                    tccLabel.Visible = false;

                    chargeTypeCombo.Items.Clear();
                    chargeTypeCombo.Items.AddRange(new object[] {
                    "SALE",
                    "CREDIT",
                    "VOID",
                    "FORCE_SALE",
                    "AUTH",
                    "CAPTURE",
                    "ADJUSTMENT",
                    "DELETE_CUSTOMER"});
                    break;

                default:
                    break;
            }      
        }

        private void chargeTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tccComboBox.Text)
            {
                case "PPD":
                    TCC = "50";
                    break;
                case "TEL":
                    TCC = "51";
                    break;
                case "WEB":
                    TCC = "52";
                    break;
                case "CCD":
                    TCC = "53";
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MPDTransactions_Load(object sender, EventArgs e)
        {
            dbViewer.View = View.Details;
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("Logging", "db.dat")).ToString();

           

            var data = File.ReadAllLines(dbPath);
            foreach (string line in data)
            {
                var parts = line.Split(',');
                ListViewItem lvi = new ListViewItem(parts[0]);
                lvi.SubItems.Add(parts[1]);
                lvi.SubItems.Add(parts[2]);
                lvi.SubItems.Add(parts[3]);
                lvi.SubItems.Add(parts[4]);
                lvi.SubItems.Add(parts[5]);
                lvi.SubItems.Add(parts[6]);
                dbViewer.Items.Add(lvi);

            }
            dbViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            dbViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void submitButton_Click(object sender, EventArgs e) // Perform MPD Transaction using Supplied parameters
        {
            try
            {
                orderIDText.Text = EHPAgain.PaymentEngine.orderIDRandom(8);
                string parameters = EHPAgain.PaymentEngine.mpdBuilder(accountTokenText.Text, orderIDText.Text, transactionTypeCombo.Text, 
                    chargeTypeCombo.Text, amountBox.Text, payerIdentifierBox.Text, spanTextBox.Text, expYYCombo.Text, expMMCombo.Text);
                postParametersText.Text = parameters;
                writeToLog(parameters);

                hostPayWB.DocumentText = EHPAgain.PaymentEngine.webRequest_Query(parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has Occured, please check the log.");
                writeToLog(ex.ToString());
            }

        }

        public void writeToLog(string logString) //Code for logging functions.
        {
            var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("Logging", "Log.txt")).ToString();
            string timeStamp = DateTime.Now.ToString();
            File.AppendAllText(logPath, timeStamp + Environment.NewLine + logString + Environment.NewLine + "--------------------------------------------------" + Environment.NewLine);
        }

        private void dbViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = dbViewer.HitTest(e.Location);

            Rectangle rowBounds = hit.SubItem.Bounds;
            Rectangle labelBounds = hit.Item.GetBounds(ItemBoundsPortion.Label);

            int leftMargin = labelBounds.Left - 1;
            txt.Bounds = new Rectangle(rowBounds.Left + leftMargin, rowBounds.Top, rowBounds.Width - leftMargin - 1, rowBounds.Height);
            txt.Text = hit.SubItem.Text;
            txt.SelectAll();
            txt.Visible = true;
            txt.Focus();
        }

        private void amountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void dbViewerLabel_Click(object sender, EventArgs e)
        {

        }

        public string AESEncryption(string plain, string key, bool fips)
        {
            OpenEdgeHostPayDemo.SuperSecret superSecret = new OpenEdgeHostPayDemo.SuperSecret(new AesEngine(), _encoding);
            superSecret.SetPadding(_padding);
            return superSecret.Encrypt(plain, key);

        }

        public string AESDecryption(string cipher, string key, bool fips)
        {
            OpenEdgeHostPayDemo.SuperSecret superSecret = new OpenEdgeHostPayDemo.SuperSecret(new AesEngine(), _encoding);
            superSecret.SetPadding(_padding);
            return superSecret.Decrypt(cipher, key);
        }
    }
}
