using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHPAgain
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        public string ReceiptText;

        private void Receipt_Load(object sender, EventArgs e)
        {
            receiptTextNew.Text = ReceiptText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            string s = ReceiptText;

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
