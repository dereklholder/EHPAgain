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

namespace OpenEdgeHostPayDemo
{
    public partial class MPDTransactions : Form
    {
        public MPDTransactions()
        {
            InitializeComponent();
        }
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
            if (transactionTypeCombo.Text == "ACH")
            {
                tccComboBox.Visible = true;
                tccLabel.Visible = true;
                chargeTypeCombo.Items.Clear();
                chargeTypeCombo.Items.AddRange(new object[]
                {
                    "DEBIT",
                    "CREDIT"
                });
            }
            if (transactionTypeCombo.Text == "CREDIT_CARD")
            {

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
            }
        }

        private void chargeTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tccComboBox.Text == "PPD")
            {
                TCC = "50";
            }
            if (tccComboBox.Text == "TEL")
            {
                TCC = "51";
            }
            if (tccComboBox.Text == "WEB")
            {
                TCC = "52";
            }
            if (tccComboBox.Text == "CCD")
            {
                TCC = "53";
            }
            if (tccComboBox.Text == "")
            {
                TCC = null;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MPDTransactions_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e) // Perform MPD Transaction using Supplied parameters
        {
            try
            {
                orderIDText.Text = EHPAgain.PaymentEngine.orderIDRandom(8);
                string parameters = EHPAgain.PaymentEngine.mpdBuilder(accountTokenText.Text, orderIDText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, amountBox.Text, payerIdentifierBox.Text, spanTextBox.Text, expYYCombo.Text, expMMCombo.Text);
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
    }
}
