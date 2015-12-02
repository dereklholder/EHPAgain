using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHPAgain
{
    public partial class QueryPost : Form
    {
        public QueryPost()
        {
            InitializeComponent();
        }
        public string queryPostText;
        private void Form1_Load(object sender, EventArgs e)
        {
            queryPostBox.Text = queryPostText;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
