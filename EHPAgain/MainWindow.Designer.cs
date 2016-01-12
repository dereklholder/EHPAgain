namespace EHPAgain
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.hostPay = new System.Windows.Forms.WebBrowser();
            this.transactionTypeCombo = new System.Windows.Forms.ComboBox();
            this.entryModeCombo = new System.Windows.Forms.ComboBox();
            this.orderIDText = new System.Windows.Forms.TextBox();
            this.accountTokenText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chargeTypeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.postParametersText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.queryPaymentBrowser = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.queryButton = new System.Windows.Forms.Button();
            this.accountTypeCombo = new System.Windows.Forms.ComboBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.creditTypeLabel = new System.Windows.Forms.Label();
            this.creditTypeCombo = new System.Windows.Forms.ComboBox();
            this.customParameterBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.tccLabel = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.tccComboBox = new System.Windows.Forms.ComboBox();
            this.queryPostButton = new System.Windows.Forms.Button();
            this.sigCapCheckBox = new System.Windows.Forms.CheckBox();
            this.signatureImageBox = new System.Windows.Forms.PictureBox();
            this.returnedSignatureLabel = new System.Windows.Forms.Label();
            this.showReceiptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mpdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signatureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hostPay
            // 
            this.hostPay.Location = new System.Drawing.Point(16, 317);
            this.hostPay.MinimumSize = new System.Drawing.Size(20, 20);
            this.hostPay.Name = "hostPay";
            this.hostPay.Size = new System.Drawing.Size(891, 341);
            this.hostPay.TabIndex = 0;
            this.hostPay.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.hostPay_DocumentCompleted);
            // 
            // transactionTypeCombo
            // 
            this.transactionTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionTypeCombo.FormattingEnabled = true;
            this.transactionTypeCombo.Items.AddRange(new object[] {
            "CREDIT_CARD",
            "DEBIT_CARD",
            "ACH",
            "INTERAC"});
            this.transactionTypeCombo.Location = new System.Drawing.Point(9, 64);
            this.transactionTypeCombo.Name = "transactionTypeCombo";
            this.transactionTypeCombo.Size = new System.Drawing.Size(161, 21);
            this.transactionTypeCombo.TabIndex = 1;
            this.transactionTypeCombo.SelectedIndexChanged += new System.EventHandler(this.transactionTypeCombo_SelectedIndexChanged);
            // 
            // entryModeCombo
            // 
            this.entryModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryModeCombo.FormattingEnabled = true;
            this.entryModeCombo.Items.AddRange(new object[] {
            "KEYED",
            "SWIPED",
            "AUTO",
            "HID",
            "EMV"});
            this.entryModeCombo.Location = new System.Drawing.Point(182, 64);
            this.entryModeCombo.Name = "entryModeCombo";
            this.entryModeCombo.Size = new System.Drawing.Size(121, 21);
            this.entryModeCombo.TabIndex = 2;
            this.entryModeCombo.SelectedIndexChanged += new System.EventHandler(this.entryModeCombo_SelectedIndexChanged);
            // 
            // orderIDText
            // 
            this.orderIDText.Location = new System.Drawing.Point(603, 64);
            this.orderIDText.Name = "orderIDText";
            this.orderIDText.ReadOnly = true;
            this.orderIDText.Size = new System.Drawing.Size(300, 20);
            this.orderIDText.TabIndex = 3;
            // 
            // accountTokenText
            // 
            this.accountTokenText.Location = new System.Drawing.Point(9, 25);
            this.accountTokenText.Name = "accountTokenText";
            this.accountTokenText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountTokenText.Size = new System.Drawing.Size(421, 20);
            this.accountTokenText.TabIndex = 4;
            this.accountTokenText.Text = "04173F8DCE65520D3580E5FF8555A961CECF249E46B5C2FAEFA04E248CD95FEA9D55BB581758D0591" +
    "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transaction Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entry Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account Token";
            // 
            // chargeTypeCombo
            // 
            this.chargeTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chargeTypeCombo.FormattingEnabled = true;
            this.chargeTypeCombo.Items.AddRange(new object[] {
            "SALE",
            "FORCE_SALE",
            "AUTH",
            "CAPTURE",
            "VOID",
            "CREDIT",
            "ADJUSTMENT",
            "PURCHASE",
            "REFUND",
            "DEBIT"});
            this.chargeTypeCombo.Location = new System.Drawing.Point(309, 64);
            this.chargeTypeCombo.Name = "chargeTypeCombo";
            this.chargeTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.chargeTypeCombo.TabIndex = 9;
            this.chargeTypeCombo.SelectedIndexChanged += new System.EventHandler(this.chargeTypeCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Charge Type";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(16, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // postParametersText
            // 
            this.postParametersText.Location = new System.Drawing.Point(912, 25);
            this.postParametersText.Name = "postParametersText";
            this.postParametersText.Size = new System.Drawing.Size(324, 168);
            this.postParametersText.TabIndex = 13;
            this.postParametersText.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Post Parameters";
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(436, 65);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(161, 20);
            this.amountText.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Amount:";
            // 
            // queryPaymentBrowser
            // 
            this.queryPaymentBrowser.Location = new System.Drawing.Point(913, 241);
            this.queryPaymentBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.queryPaymentBrowser.Name = "queryPaymentBrowser";
            this.queryPaymentBrowser.Size = new System.Drawing.Size(323, 417);
            this.queryPaymentBrowser.TabIndex = 18;
            this.queryPaymentBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.queryPaymentBrowser_DocumentCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(909, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Query Payment Response";
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(912, 202);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 23);
            this.queryButton.TabIndex = 20;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // accountTypeCombo
            // 
            this.accountTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeCombo.FormattingEnabled = true;
            this.accountTypeCombo.Items.AddRange(new object[] {
            "DEFAULT",
            "CASH_BENEFIT",
            "FOOD_STAMP"});
            this.accountTypeCombo.Location = new System.Drawing.Point(9, 104);
            this.accountTypeCombo.Name = "accountTypeCombo";
            this.accountTypeCombo.Size = new System.Drawing.Size(161, 21);
            this.accountTypeCombo.TabIndex = 24;
            this.accountTypeCombo.Visible = false;
            this.accountTypeCombo.SelectedIndexChanged += new System.EventHandler(this.accountTypeCombo_SelectedIndexChanged);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(6, 88);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.accountTypeLabel.TabIndex = 25;
            this.accountTypeLabel.Text = "Account Type";
            this.accountTypeLabel.Visible = false;
            // 
            // creditTypeLabel
            // 
            this.creditTypeLabel.AutoSize = true;
            this.creditTypeLabel.Location = new System.Drawing.Point(306, 88);
            this.creditTypeLabel.Name = "creditTypeLabel";
            this.creditTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.creditTypeLabel.TabIndex = 26;
            this.creditTypeLabel.Text = "Credit Type";
            this.creditTypeLabel.Visible = false;
            // 
            // creditTypeCombo
            // 
            this.creditTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditTypeCombo.FormattingEnabled = true;
            this.creditTypeCombo.Items.AddRange(new object[] {
            "DEPENDENT",
            "INDEPENDENT"});
            this.creditTypeCombo.Location = new System.Drawing.Point(309, 104);
            this.creditTypeCombo.Name = "creditTypeCombo";
            this.creditTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.creditTypeCombo.TabIndex = 27;
            this.creditTypeCombo.Visible = false;
            // 
            // customParameterBox
            // 
            this.customParameterBox.Location = new System.Drawing.Point(603, 104);
            this.customParameterBox.Name = "customParameterBox";
            this.customParameterBox.Size = new System.Drawing.Size(300, 89);
            this.customParameterBox.TabIndex = 28;
            this.customParameterBox.Text = "&prompt_signature=true&manage_payer_data=true";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Custom Parameters";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(747, 22);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 30;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tccLabel
            // 
            this.tccLabel.AutoSize = true;
            this.tccLabel.Location = new System.Drawing.Point(436, 88);
            this.tccLabel.Name = "tccLabel";
            this.tccLabel.Size = new System.Drawing.Size(138, 13);
            this.tccLabel.TabIndex = 31;
            this.tccLabel.Text = "Transaction Condition Code";
            this.tccLabel.Visible = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tccComboBox
            // 
            this.tccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tccComboBox.FormattingEnabled = true;
            this.tccComboBox.Items.AddRange(new object[] {
            "PPD",
            "TEL",
            "WEB",
            "CCD"});
            this.tccComboBox.Location = new System.Drawing.Point(436, 104);
            this.tccComboBox.Name = "tccComboBox";
            this.tccComboBox.Size = new System.Drawing.Size(158, 21);
            this.tccComboBox.TabIndex = 32;
            this.tccComboBox.Visible = false;
            this.tccComboBox.SelectedIndexChanged += new System.EventHandler(this.tccComboBox_SelectedIndexChanged);
            // 
            // queryPostButton
            // 
            this.queryPostButton.Location = new System.Drawing.Point(993, 202);
            this.queryPostButton.Name = "queryPostButton";
            this.queryPostButton.Size = new System.Drawing.Size(132, 23);
            this.queryPostButton.TabIndex = 33;
            this.queryPostButton.Text = "Display Query Post";
            this.queryPostButton.UseVisualStyleBackColor = true;
            this.queryPostButton.Click += new System.EventHandler(this.queryPostButton_Click);
            // 
            // sigCapCheckBox
            // 
            this.sigCapCheckBox.AutoSize = true;
            this.sigCapCheckBox.Location = new System.Drawing.Point(9, 131);
            this.sigCapCheckBox.Name = "sigCapCheckBox";
            this.sigCapCheckBox.Size = new System.Drawing.Size(147, 17);
            this.sigCapCheckBox.TabIndex = 34;
            this.sigCapCheckBox.Text = "Enable Signature Capture";
            this.sigCapCheckBox.UseVisualStyleBackColor = true;
            this.sigCapCheckBox.Visible = false;
            // 
            // signatureImageBox
            // 
            this.signatureImageBox.Location = new System.Drawing.Point(182, 147);
            this.signatureImageBox.Name = "signatureImageBox";
            this.signatureImageBox.Size = new System.Drawing.Size(248, 164);
            this.signatureImageBox.TabIndex = 35;
            this.signatureImageBox.TabStop = false;
            // 
            // returnedSignatureLabel
            // 
            this.returnedSignatureLabel.AutoSize = true;
            this.returnedSignatureLabel.Location = new System.Drawing.Point(182, 128);
            this.returnedSignatureLabel.Name = "returnedSignatureLabel";
            this.returnedSignatureLabel.Size = new System.Drawing.Size(99, 13);
            this.returnedSignatureLabel.TabIndex = 36;
            this.returnedSignatureLabel.Text = "Returned Signature";
            this.returnedSignatureLabel.Visible = false;
            // 
            // showReceiptButton
            // 
            this.showReceiptButton.Location = new System.Drawing.Point(1132, 202);
            this.showReceiptButton.Name = "showReceiptButton";
            this.showReceiptButton.Size = new System.Drawing.Size(104, 23);
            this.showReceiptButton.TabIndex = 37;
            this.showReceiptButton.Text = "Show Receipt";
            this.showReceiptButton.UseVisualStyleBackColor = true;
            this.showReceiptButton.Click += new System.EventHandler(this.showReceiptButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(828, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 38;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mpdButton
            // 
            this.mpdButton.Location = new System.Drawing.Point(9, 154);
            this.mpdButton.Name = "mpdButton";
            this.mpdButton.Size = new System.Drawing.Size(161, 23);
            this.mpdButton.TabIndex = 40;
            this.mpdButton.Text = "MPD Transactions";
            this.mpdButton.UseVisualStyleBackColor = true;
            this.mpdButton.Click += new System.EventHandler(this.mpdButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.mpdButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showReceiptButton);
            this.Controls.Add(this.returnedSignatureLabel);
            this.Controls.Add(this.signatureImageBox);
            this.Controls.Add(this.sigCapCheckBox);
            this.Controls.Add(this.queryPostButton);
            this.Controls.Add(this.tccComboBox);
            this.Controls.Add(this.tccLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customParameterBox);
            this.Controls.Add(this.creditTypeCombo);
            this.Controls.Add(this.creditTypeLabel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountTypeCombo);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.queryPaymentBrowser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postParametersText);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chargeTypeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountTokenText);
            this.Controls.Add(this.orderIDText);
            this.Controls.Add(this.entryModeCombo);
            this.Controls.Add(this.transactionTypeCombo);
            this.Controls.Add(this.hostPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "OpenEdge HostPay Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signatureImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser hostPay;
        private System.Windows.Forms.ComboBox transactionTypeCombo;
        private System.Windows.Forms.ComboBox entryModeCombo;
        private System.Windows.Forms.TextBox orderIDText;
        private System.Windows.Forms.TextBox accountTokenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chargeTypeCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox postParametersText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.WebBrowser queryPaymentBrowser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.ComboBox accountTypeCombo;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label creditTypeLabel;
        private System.Windows.Forms.ComboBox creditTypeCombo;
        private System.Windows.Forms.RichTextBox customParameterBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label tccLabel;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ComboBox tccComboBox;
        private System.Windows.Forms.Button queryPostButton;
        private System.Windows.Forms.CheckBox sigCapCheckBox;
        private System.Windows.Forms.PictureBox signatureImageBox;
        private System.Windows.Forms.Label returnedSignatureLabel;
        private System.Windows.Forms.Button showReceiptButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mpdButton;
    }
}

