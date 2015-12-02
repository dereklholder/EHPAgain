﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using HtmlAgilityPack;
using System.Web;

/* Code for Demonstration Purposes by Derek Holder
 * For Demo Purposes Only, not intented for Live use */

namespace EHPAgain
{
    
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public string TCC = null; //Transaction Condition Code vaiable, used for Check Transactions. 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void transactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e) //Manage the Visible and Available Charge Types based on Transaction Type 
        {
            
            if (transactionTypeCombo.Text == "DEBIT_CARD")
            {
                accountTypeCombo.Visible = true;
                accountTypeLabel.Visible = true;
                sigCapCheckBox.Visible = false;
                tccComboBox.Visible = false;
                tccLabel.Visible = false;
                returnedSignatureLabel.Visible = false;
                chargeTypeCombo.Items.Clear();
                chargeTypeCombo.Items.AddRange(new object[] 
                {
                    "PURCHASE",
                    "REFUND"
                });
                entryModeCombo.Items.Clear();
                entryModeCombo.Items.AddRange(new object[]
                {
                    "EMV",
                    "HID"
                });
            }
            if (transactionTypeCombo.Text == "ACH")
            {
                tccComboBox.Visible = true;
                tccLabel.Visible = true;
                accountTypeCombo.Visible = false;
                accountTypeLabel.Visible = false;
                sigCapCheckBox.Visible = false;
                returnedSignatureLabel.Visible = false;
                chargeTypeCombo.Items.Clear();
                chargeTypeCombo.Items.AddRange(new object[] 
                {
                    "DEBIT",
                    "CREDIT"
                });
                entryModeCombo.Items.Clear();
                entryModeCombo.Items.AddRange(new object[]
                {
                    "KEYED"
                });
            }
            if (transactionTypeCombo.Text == "CREDIT_CARD")
            {
                accountTypeCombo.Visible = false;
                accountTypeLabel.Visible = false;
                tccComboBox.Visible = false;
                tccLabel.Visible = false;
                sigCapCheckBox.Visible = true;
                returnedSignatureLabel.Visible = true;
                chargeTypeCombo.Items.Clear();
                chargeTypeCombo.Items.AddRange(new object[] {
                    "SALE",
                    "CREDIT",
                    "VOID",
                    "FORCE_SALE",
                    "AUTH",
                    "CAPTURE",
                    "ADJUSTMENT"});
                entryModeCombo.Items.Clear();
                entryModeCombo.Items.AddRange(new object[]
                {
                    "KEYED",
                    "EMV",
                    "HID",
                    "SWIPED"
                });
            }
        }
       
        private void chargeTypeCombo_SelectedIndexChanged(object sender, EventArgs e) // Allow OrderID to be manually entered for Applicable Transactions, also Manage Independent vs Dependent credit box.
        {
            
            
            if (chargeTypeCombo.Text == "CREDIT" || chargeTypeCombo.Text == "REFUND" || chargeTypeCombo.Text == "FORCE_SALE" || chargeTypeCombo.Text == "VOID")
            {
                orderIDText.ReadOnly = false;

                if (transactionTypeCombo.Text == "CREDIT_CARD" && chargeTypeCombo.Text == "CREDIT")
                {
                    creditTypeLabel.Visible = true;
                    creditTypeCombo.Visible = true;
                }
                else
                {
                    creditTypeCombo.Visible = false;
                    creditTypeLabel.Visible = false;
                }
                
            }
            else
            {
                orderIDText.ReadOnly = true;
                creditTypeLabel.Visible = false;
                creditTypeCombo.Visible = false;
            }
        }
        
        private void submitButton_Click(object sender, EventArgs e) //Submit button with Logic for sending correct transaction type. 
        {
            if (transactionTypeCombo.Text == "CREDIT_CARD")
            {
                hostPay.Navigate("about:blank");
                if (chargeTypeCombo.Text != "CREDIT" && chargeTypeCombo.Text != "VOID" && chargeTypeCombo.Text != "FORCE_SALE")
                {
                    orderIDText.Text = PaymentEngine.orderIDRandom(8); //Create Random OrderID
                }          
                string parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text,
                  entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text); // Build Parameters for POST
                postParametersText.Text = parameters;
                writeToLog(parameters);

                if (creditTypeCombo.Text == "INDEPENDENT" || chargeTypeCombo.Text != "CREDIT")
                {
                    string otk = PaymentEngine.webRequest_Post(parameters);

                    //hostPay.DocumentText = PaymentEngine.webRequest_Post(parameters); // Send Post and Render in Browser Control  Deprecated
                    hostPay.Navigate("https://ws.test.paygateway.com/HostPayService/v1/hostpay/paypage/" + otk); //Navigate Web Browser to Paypage URL + Session Token
                    string content = hostPay.DocumentText.ToString();
                }
                if (creditTypeCombo.Text == "DEPENDENT" || chargeTypeCombo.Text == "VOID" || chargeTypeCombo.Text == "FORCE_SALE")
                {
                    hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                }
                
               
            }
            if (transactionTypeCombo.Text == "DEBIT_CARD")
            {
                hostPay.Navigate("about:blank");
                if (chargeTypeCombo.Text != "REFUND")
                {
                    orderIDText.Text = PaymentEngine.orderIDRandom(8); //Create Random OrderID
                }            
                string parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text,
                  entryModeCombo.Text, orderIDText.Text, amountText.Text, accountTypeCombo.Text, customParameterBox.Text); // Build Parameters for POST
                postParametersText.Text = parameters;
                writeToLog(parameters);

                string otk = PaymentEngine.webRequest_Post(parameters);

                //hostPay.DocumentText = PaymentEngine.webRequest_Post(parameters); // Send Post and Render in Browser Control  Deprecated
                hostPay.Navigate("https://ws.test.paygateway.com/HostPayService/v1/hostpay/paypage/" + otk); //Navigate Web Browser to Paypage URL + Session Token
                string content = hostPay.DocumentText.ToString();
                
                
            }
            if (transactionTypeCombo.Text == "ACH")
            {
                hostPay.Navigate("about:blank");
                if (chargeTypeCombo.Text != "CREDIT")
                {
                    orderIDText.Text = PaymentEngine.orderIDRandom(8); //Create Random OrderID
                }
                string parameters = PaymentEngine.ACHParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text,
                  entryModeCombo.Text, orderIDText.Text, amountText.Text, TCC, customParameterBox.Text); // Build Parameters for POST
                postParametersText.Text = parameters;
                writeToLog(parameters);

                if (creditTypeCombo.Text == "INDEPENDENT" || chargeTypeCombo.Text != "CREDIT")
                {
                    string otk = PaymentEngine.webRequest_Post(parameters);                    
                    hostPay.Navigate("https://ws.test.paygateway.com/HostPayService/v1/hostpay/paypage/" + otk); //Navigate Web Browser to Paypage URL + Session Token
                    string content = hostPay.DocumentText.ToString();
                }
                if (creditTypeCombo.Text == "DEPENDENT")
                {
                    hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                }
            }
        } 
        
        private void queryButton_Click(object sender, EventArgs e) //Button for Performing QUERY.
        {
            try
            {
                string parameters = PaymentEngine.QueryBuilder(accountTokenText.Text, orderIDText.Text,
                                transactionTypeCombo.Text, "QUERY_PAYMENT"); // Build Query
                postParametersText.Text = parameters;
                queryPaymentBrowser.DocumentText = PaymentEngine.webRequest_Query(parameters);
                writeToLog(queryPaymentBrowser.DocumentText);
            }
            catch (Exception ex)
            {
                string s = "An error has Occured" + Environment.NewLine + ex.ToString();
                MessageBox.Show(s);
                writeToLog(s);
            }
        }
       
        private void hostPay_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) //Query Payment if the  document contains paymentFinished Singal on Document Completed, In Addition Parse Signature if Signature Capture is enabled.
        {                     
            if (null != hostPay.Document && null != hostPay.Document.GetElementById("paymentFinishedSignal"))
            {
                string parameters = null;
                if (transactionTypeCombo.Text == "CREDIT_CARD")
                {
                    parameters = PaymentEngine.QueryBuilder(accountTokenText.Text, orderIDText.Text,
                    transactionTypeCombo.Text, "QUERY_PAYMENT"); // Build Query
                    queryPaymentBrowser.DocumentText = PaymentEngine.webRequest_Query(parameters);
                }
                if (transactionTypeCombo.Text == "DEBIT_CARD")
                {
                    parameters = PaymentEngine.QueryBuilder(accountTokenText.Text, orderIDText.Text,
                    transactionTypeCombo.Text, "QUERY_PURCHASE"); // Build Query
                    queryPaymentBrowser.DocumentText = PaymentEngine.webRequest_Query(parameters);
                }
                writeToLog(queryPaymentBrowser.DocumentText);
            }
            //Parse Signature From result, uses HtmlAgilityPack for easier parsing of document using XPath
            if (null != hostPay.Document && sigCapCheckBox.Checked == true && null != hostPay.Document.GetElementById("signatureImage"))
            {
                HtmlAgilityPack.HtmlDocument docroot = new HtmlAgilityPack.HtmlDocument();
                docroot.Load(hostPay.DocumentStream);
                var value = docroot.DocumentNode.SelectSingleNode("//input[@type='hidden' and @id='signatureImage' and @name='signatureImage']").Attributes["value"].Value;

                if (null != value)
                {
                    string base64Signature = value.ToString();
                    var signature = Base64ToImage(base64Signature);
                    signatureImageBox.Image = signature;
                }
            }      
        }

        public Image Base64ToImage(string base64String) //Convert Base64 to Image, Used  to parse Signature from result in hostPay_DocumentCompleted
        {
           
            //Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            //Convert byte[] to Image)
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        
        private void helpButton_Click(object sender, EventArgs e) //Display Help
        {
            Help H = new Help();
            H.ShowDialog();
        } 
        
        private void tccComboBox_SelectedIndexChanged(object sender, EventArgs e) //Set Transaction Condition Code based on SEC type selected in transaction Condition Code Box.
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

        private void queryPostButton_Click(object sender, EventArgs e) //Button Displays Form with data that is used for Query Payment transaction.
        {
            try
            {
                QueryPost qp = new QueryPost();
                qp.queryPostText = PaymentEngine.QueryBuilder(accountTokenText.Text, orderIDText.Text,
                transactionTypeCombo.Text, "QUERY_PAYMENT");
                qp.ShowDialog();
            }
            catch (Exception ex)
            {
                string s = "An error has Occured" + Environment.NewLine + ex.ToString();
                MessageBox.Show(s);
                writeToLog(s);
            }
        }

        private void showReceiptButton_Click(object sender, EventArgs e) //Parse receipt from Query Browser that displays result of Query Payment, merely grabs full receipt data, URLDecodes, and sends that to a form
        {
            var queryContent = queryPaymentBrowser.DocumentText.ToString();
            NameValueCollection keyPairs = HttpUtility.ParseQueryString(queryContent);
            try
            {           
                string receiptData = HttpUtility.UrlDecode(keyPairs.Get("customer_receipt"));
                Receipt r = new Receipt();
                r.ReceiptText = receiptData.Replace("\n", "\r\n");
                r.ShowDialog();
                

            }
            catch (NullReferenceException ex)
            {           
                MessageBox.Show("No Data in Query Payment, Unable to Parse Receipt.");
                string log = ex.ToString() + Environment.NewLine + "No Data in Query Payment";
                writeToLog(log);
            }
        }

        public void writeToLog(string logString) //Code for logging functions.
        {
            var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("Logging", "Log.txt")).ToString();
            string timeStamp = DateTime.Now.ToString();
            File.AppendAllText(logPath, timeStamp + Environment.NewLine + logString + Environment.NewLine + "--------------------------------------------------" + Environment.NewLine);
        }

        private void queryPaymentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) //Event Used to send Query data to log.
        {
            string s = queryPaymentBrowser.DocumentText;
            writeToLog(s);
        }

        private void exitButton_Click(object sender, EventArgs e) //Exit Button
        {
            this.Close();
        }
    }
}
