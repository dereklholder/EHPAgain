using System;
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
using System.Data.SqlClient;

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
   
        /* Deprecated SQL Attempt. May revisit.
        public static string LocalPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string ConnString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                    AttachDBFilename={0}MPDVault.MDF;
                                                    Integrated Security= true;
                                                    Connect Timeout=30;
                                                    User Instance=false", LocalPath);
        public static string newConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MPDVault.mdf;Integrated Security = True;";
        */
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        
        private void transactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e) //Manage the Visible and Available Charge Types based on Transaction Type 
        {
            switch (transactionTypeCombo.Text)
            {
                case "DEBIT_CARD":
                    creditTypeCombo.Visible = false;
                    creditTypeLabel.Visible = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
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
                    break;

                case "CREDIT_CARD":
                    creditTypeCombo.Visible = false;
                    creditTypeLabel.Visible = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
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
                    "ADJUSTMENT",
                    "SIGNATURE"});
                    entryModeCombo.Items.Clear();
                    entryModeCombo.Items.AddRange(new object[]
                    {
                    "KEYED",
                    "EMV",
                    "HID",
                    "SWIPED"
                    });
                    break;

                case "ACH":
                    creditTypeCombo.Visible = false;
                    creditTypeLabel.Visible = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
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
                    break;

                case "INTERAC":
                    creditTypeCombo.Visible = false;
                    creditTypeLabel.Visible = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    accountTypeCombo.Visible = false;
                    accountTypeLabel.Visible = false;
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
                    break;

                default:
                    break;
            }
        }
       
        private void chargeTypeCombo_SelectedIndexChanged(object sender, EventArgs e) // Allow OrderID to be manually entered for Applicable Transactions, also Manage Independent vs Dependent credit box.
        {
            switch (chargeTypeCombo.Text)
            {
                case "CREDIT":
                    orderIDText.ReadOnly = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    switch (transactionTypeCombo.Text)
                    {
                        case "CREDIT_CARD":
                            creditTypeLabel.Visible = true;
                            creditTypeCombo.Visible = true;
                            break;

                        default:
                            creditTypeCombo.Visible = false;
                            creditTypeLabel.Visible = false;
                            break;
                    }
                    break;
                case "REFUND":
                    orderIDText.ReadOnly = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    break;

                case "FORCE_SALE":
                    orderIDText.ReadOnly = false;
                    approvalCodeLabel.Visible = true;
                    approvalCodeBox.Visible = true;
                    break;

                case "VOID":
                    orderIDText.ReadOnly = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    break;

                case "CAPTURE":
                    orderIDText.ReadOnly = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    break;

                default:
                    orderIDText.ReadOnly = true;
                    creditTypeLabel.Visible = false;
                    creditTypeCombo.Visible = false;
                    approvalCodeLabel.Visible = false;
                    approvalCodeBox.Visible = false;
                    break;
            }
        }
        
        private void submitButton_Click(object sender, EventArgs e) //Submit button with Logic for sending correct transaction type. 
        {
            string parameters;
            string otk;
            string content; 

            switch (transactionTypeCombo.Text)
            {
                case "CREDIT_CARD":
                    switch (chargeTypeCombo.Text)
                    {
                        case "SALE":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk);
                            content = hostPay.DocumentText.ToString();
                            break;

                        case "CREDIT":
                            
                            switch (creditTypeCombo.Text)
                            {
                                case "DEPENDENT":
                                    parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                                    postParametersText.Text = parameters;
                                    writeToLog(parameters);

                                    hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                                    break;

                                case "INDEPENDENT":
                                    parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text); // Build Parameters for POST
                                    postParametersText.Text = parameters;
                                    writeToLog(parameters);

                                    otk = PaymentEngine.webRequest_Post(parameters);

                                    hostPay.Navigate(PaymentEngine.otkURL + otk);
                                    break;
                                default:
                                    MessageBox.Show("An Error has occured, Invalid transaction parameters");
                                    break;
                            }
                            break; //End Credit Case

                        case "AUTH":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk);
                            content = hostPay.DocumentText.ToString();
                            break;

                        case "VOID":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                            break;

                        case "FORCE_SALE":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilderAppCode(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, approvalCodeBox.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                            break;

                        case "CAPTURE":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                            break;

                        case "ADJUSTMENT":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                            break;

                        case "SIGNATURE":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk);
                            content = hostPay.DocumentText.ToString();
                            break;

                        default:
                            MessageBox.Show("An error has occured, Invalid transaction parameters");
                            break;

                    } // End Credit_CARD request
                    break;

                case "DEBIT_CARD":

                    switch (chargeTypeCombo.Text)
                    {
                        case "REFUND":
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, accountTypeCombo.Text, customParameterBox.Text); // Build Parameters for POST
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk); //Navigate Web Browser to Paypage URL + Session Token
                            content = hostPay.DocumentText.ToString();
                            break;

                        case "PURCHASE":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, accountTypeCombo.Text, customParameterBox.Text); // Build Parameters for POST
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk); //Navigate Web Browser to Paypage URL + Session Token
                            content = hostPay.DocumentText.ToString();
                            break;

                        default:
                            MessageBox.Show("An error has occured, Invalid Transaction Parameters");
                            break;

                    } //End Debit Card Switch
                    break;

                case "ACH":
                    switch (chargeTypeCombo.Text)
                    {
                        case "CREDIT":

                            switch (creditTypeCombo.Text)
                            {
                                case "DEPENDENT":
                                    parameters = PaymentEngine.ACHParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, TCC, customParameterBox.Text);
                                    postParametersText.Text = parameters;
                                    writeToLog(parameters);

                                    hostPay.DocumentText = PaymentEngine.webRequest_Query(parameters);
                                    break;

                                case "INDEPENDENT":
                                    parameters = PaymentEngine.ACHParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, TCC, customParameterBox.Text);
                                    postParametersText.Text = parameters;
                                    writeToLog(parameters);

                                    otk = PaymentEngine.webRequest_Post(parameters);

                                    hostPay.Navigate(PaymentEngine.otkURL + otk);
                                    break;
                                default:
                                    MessageBox.Show("An Error has occured, Invalid transaction parameters");
                                    break;
                            }
                            break; //End Credit Case

                        case "DEBIT":
                            orderIDText.Text = PaymentEngine.orderIDRandom(8);
                            parameters = PaymentEngine.ACHParamBuilder(accountTokenText.Text, transactionTypeCombo.Text, chargeTypeCombo.Text, entryModeCombo.Text, orderIDText.Text, amountText.Text, TCC, customParameterBox.Text);
                            postParametersText.Text = parameters;
                            writeToLog(parameters);

                            otk = PaymentEngine.webRequest_Post(parameters);

                            hostPay.Navigate(PaymentEngine.otkURL + otk);
                            break;

                        default:
                            MessageBox.Show("An Error has occured, Invalid Transaction Parameters");
                            break;

                    } // End ACH
                    break;

                default:
                    MessageBox.Show("An Error has occured, Invalid Transaction Parameters");
                    break;
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

                default:
                    TCC = null;
                    break;
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
            // Grab Information for MPD Transactions, if it exists. WIP
            NameValueCollection keyPairs = HttpUtility.ParseQueryString(queryPaymentBrowser.DocumentText.ToString());
            
            try
            {
                string id = keyPairs.Get("receipt_approval_code");
                string payer_Id = keyPairs.Get("payer_identifier");
                string exp_mm = keyPairs.Get("expire_month");
                string exp_yy = keyPairs.Get("expire_year");
                string span = keyPairs.Get("span");
                string tranType = transactionTypeCombo.Text;
                string label = DateTime.Now.ToLongTimeString(); // + DateTime.Now.ToLongDateString();
                string forTheLogging =  "Here is the Data Being Attempted to Add to SQL" + Environment.NewLine + payer_Id + Environment.NewLine + exp_mm + Environment.NewLine + exp_yy + Environment.NewLine + span + Environment.NewLine + label;
                string dbString = id + ',' + payer_Id + ',' + exp_mm + ',' + exp_yy + ',' + span + ',' + label + ',' + tranType;
                var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("Logging", "db.dat")).ToString();
                File.AppendAllText(dbPath, dbString + Environment.NewLine);
                writeToLog(forTheLogging);

                /* Sql is dumb, may revisit.
                using (SqlConnection conn = new SqlConnection(newConnString))
                {
                    SqlCommand addToken = new SqlCommand(@"INSERT INTO dbo.tokenVault (Id, Payer_Identifier, SPAN, EXP_MM, EXP_YY, Label) 
                                                                        VALUES (@Id,@payer_ID,@SPAN,@EXP_MM,@EXP_YY,@Label)", conn);
                    addToken.Parameters.AddWithValue("@Id", id);
                    addToken.Parameters.AddWithValue("@payer_ID", payer_Id);
                    addToken.Parameters.AddWithValue("@exp_mm", exp_mm);
                    addToken.Parameters.AddWithValue("@exp_yy", exp_yy);
                    addToken.Parameters.AddWithValue("@span", span);
                    addToken.Parameters.AddWithValue("@Label", label);
                    conn.Open();
                    addToken.ExecuteNonQuery();
                    conn.Close();
                    
                }*/
                
            }
            catch (SqlException ex)
            {
                writeToLog(ex.ToString());
                //MessageBox.Show("An Error Has Occured when Communicating to the Database, Please Check the Log");
                
            }
            catch (Exception ex)
            {
                writeToLog(ex.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e) //Exit Button
        {
            this.Close();
        }

        private void mpdButton_Click(object sender, EventArgs e)
        {
            OpenEdgeHostPayDemo.MPDTransactions m = new OpenEdgeHostPayDemo.MPDTransactions();
            m.Show();
            this.Hide();
        }

        private void entryModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void accountTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void approvalCodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
