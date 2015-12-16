namespace OpenEdgeHostPayDemo
{
    partial class MPDTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPDTransactions));
            this.exitButton = new System.Windows.Forms.Button();
            this.transactionTypeCombo = new System.Windows.Forms.ComboBox();
            this.chargeTypeCombo = new System.Windows.Forms.ComboBox();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.chargeTypeLabel = new System.Windows.Forms.Label();
            this.tccComboBox = new System.Windows.Forms.ComboBox();
            this.tccLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.hostPayWB = new System.Windows.Forms.WebBrowser();
            this.postParametersText = new System.Windows.Forms.RichTextBox();
            this.postParametersLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountTokenText = new System.Windows.Forms.TextBox();
            this.payerIdentifierBox = new System.Windows.Forms.TextBox();
            this.spanTextBox = new System.Windows.Forms.TextBox();
            this.spanLabel = new System.Windows.Forms.Label();
            this.payerIdentifierLabel = new System.Windows.Forms.Label();
            this.expMMCombo = new System.Windows.Forms.ComboBox();
            this.expYYCombo = new System.Windows.Forms.ComboBox();
            this.expMMLabel = new System.Windows.Forms.Label();
            this.expYYLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Standard Transactions";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // transactionTypeCombo
            // 
            this.transactionTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionTypeCombo.FormattingEnabled = true;
            this.transactionTypeCombo.Items.AddRange(new object[] {
            "CREDIT_CARD",
            "ACH"});
            this.transactionTypeCombo.Location = new System.Drawing.Point(12, 100);
            this.transactionTypeCombo.Name = "transactionTypeCombo";
            this.transactionTypeCombo.Size = new System.Drawing.Size(160, 21);
            this.transactionTypeCombo.TabIndex = 1;
            this.transactionTypeCombo.SelectedIndexChanged += new System.EventHandler(this.transactionTypeCombo_SelectedIndexChanged);
            // 
            // chargeTypeCombo
            // 
            this.chargeTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chargeTypeCombo.FormattingEnabled = true;
            this.chargeTypeCombo.Location = new System.Drawing.Point(178, 99);
            this.chargeTypeCombo.Name = "chargeTypeCombo";
            this.chargeTypeCombo.Size = new System.Drawing.Size(160, 21);
            this.chargeTypeCombo.TabIndex = 2;
            this.chargeTypeCombo.SelectedIndexChanged += new System.EventHandler(this.chargeTypeCombo_SelectedIndexChanged);
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(9, 84);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(90, 13);
            this.transactionTypeLabel.TabIndex = 3;
            this.transactionTypeLabel.Text = "Transaction Type";
            this.transactionTypeLabel.UseMnemonic = false;
            // 
            // chargeTypeLabel
            // 
            this.chargeTypeLabel.AutoSize = true;
            this.chargeTypeLabel.Location = new System.Drawing.Point(175, 83);
            this.chargeTypeLabel.Name = "chargeTypeLabel";
            this.chargeTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.chargeTypeLabel.TabIndex = 4;
            this.chargeTypeLabel.Text = "Charge Type";
            // 
            // tccComboBox
            // 
            this.tccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tccComboBox.FormattingEnabled = true;
            this.tccComboBox.Items.AddRange(new object[] {
            "PPD",
            "CCD",
            "TEL",
            "WEB"});
            this.tccComboBox.Location = new System.Drawing.Point(344, 99);
            this.tccComboBox.Name = "tccComboBox";
            this.tccComboBox.Size = new System.Drawing.Size(160, 21);
            this.tccComboBox.TabIndex = 5;
            this.tccComboBox.SelectedIndexChanged += new System.EventHandler(this.tccComboBox_SelectedIndexChanged);
            // 
            // tccLabel
            // 
            this.tccLabel.AutoSize = true;
            this.tccLabel.Location = new System.Drawing.Point(341, 83);
            this.tccLabel.Name = "tccLabel";
            this.tccLabel.Size = new System.Drawing.Size(138, 13);
            this.tccLabel.TabIndex = 6;
            this.tccLabel.Text = "Transaction Condition Code";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(510, 101);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(119, 20);
            this.amountBox.TabIndex = 7;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(508, 84);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 168);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // hostPayWB
            // 
            this.hostPayWB.Location = new System.Drawing.Point(15, 343);
            this.hostPayWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.hostPayWB.Name = "hostPayWB";
            this.hostPayWB.Size = new System.Drawing.Size(614, 228);
            this.hostPayWB.TabIndex = 10;
            // 
            // postParametersText
            // 
            this.postParametersText.Location = new System.Drawing.Point(861, 28);
            this.postParametersText.Name = "postParametersText";
            this.postParametersText.Size = new System.Drawing.Size(324, 153);
            this.postParametersText.TabIndex = 14;
            this.postParametersText.Text = "";
            // 
            // postParametersLabel
            // 
            this.postParametersLabel.AutoSize = true;
            this.postParametersLabel.Location = new System.Drawing.Point(858, 12);
            this.postParametersLabel.Name = "postParametersLabel";
            this.postParametersLabel.Size = new System.Drawing.Size(84, 13);
            this.postParametersLabel.TabIndex = 15;
            this.postParametersLabel.Text = "Post Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Account Token";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // accountTokenText
            // 
            this.accountTokenText.Location = new System.Drawing.Point(12, 61);
            this.accountTokenText.Name = "accountTokenText";
            this.accountTokenText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountTokenText.Size = new System.Drawing.Size(421, 20);
            this.accountTokenText.TabIndex = 16;
            this.accountTokenText.Text = "04173F8DCE65520D3580E5FF8555A961CECF249E46B5C2FAEFA04E248CD95FEA9D55BB581758D0591" +
    "B";
            // 
            // payerIdentifierBox
            // 
            this.payerIdentifierBox.Location = new System.Drawing.Point(12, 142);
            this.payerIdentifierBox.Name = "payerIdentifierBox";
            this.payerIdentifierBox.Size = new System.Drawing.Size(160, 20);
            this.payerIdentifierBox.TabIndex = 18;
            this.payerIdentifierBox.Text = "JLJVNfk7Sf";
            // 
            // spanTextBox
            // 
            this.spanTextBox.Location = new System.Drawing.Point(178, 142);
            this.spanTextBox.Name = "spanTextBox";
            this.spanTextBox.Size = new System.Drawing.Size(80, 20);
            this.spanTextBox.TabIndex = 19;
            this.spanTextBox.Text = "0010";
            // 
            // spanLabel
            // 
            this.spanLabel.AutoSize = true;
            this.spanLabel.Location = new System.Drawing.Point(175, 126);
            this.spanLabel.Name = "spanLabel";
            this.spanLabel.Size = new System.Drawing.Size(36, 13);
            this.spanLabel.TabIndex = 20;
            this.spanLabel.Text = "SPAN";
            // 
            // payerIdentifierLabel
            // 
            this.payerIdentifierLabel.AutoSize = true;
            this.payerIdentifierLabel.Location = new System.Drawing.Point(9, 126);
            this.payerIdentifierLabel.Name = "payerIdentifierLabel";
            this.payerIdentifierLabel.Size = new System.Drawing.Size(77, 13);
            this.payerIdentifierLabel.TabIndex = 21;
            this.payerIdentifierLabel.Text = "Payer Identifier";
            // 
            // expMMCombo
            // 
            this.expMMCombo.FormattingEnabled = true;
            this.expMMCombo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.expMMCombo.Location = new System.Drawing.Point(264, 140);
            this.expMMCombo.Name = "expMMCombo";
            this.expMMCombo.Size = new System.Drawing.Size(42, 21);
            this.expMMCombo.TabIndex = 22;
            this.expMMCombo.Visible = false;
            // 
            // expYYCombo
            // 
            this.expYYCombo.FormattingEnabled = true;
            this.expYYCombo.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.expYYCombo.Location = new System.Drawing.Point(313, 140);
            this.expYYCombo.Name = "expYYCombo";
            this.expYYCombo.Size = new System.Drawing.Size(42, 21);
            this.expYYCombo.TabIndex = 23;
            this.expYYCombo.Visible = false;
            // 
            // expMMLabel
            // 
            this.expMMLabel.AutoSize = true;
            this.expMMLabel.Location = new System.Drawing.Point(262, 126);
            this.expMMLabel.Name = "expMMLabel";
            this.expMMLabel.Size = new System.Drawing.Size(46, 13);
            this.expMMLabel.TabIndex = 24;
            this.expMMLabel.Text = "Exp MM";
            this.expMMLabel.Visible = false;
            // 
            // expYYLabel
            // 
            this.expYYLabel.AutoSize = true;
            this.expYYLabel.Location = new System.Drawing.Point(310, 126);
            this.expYYLabel.Name = "expYYLabel";
            this.expYYLabel.Size = new System.Drawing.Size(42, 13);
            this.expYYLabel.TabIndex = 25;
            this.expYYLabel.Text = "Exp YY";
            this.expYYLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Order ID";
            // 
            // orderIDText
            // 
            this.orderIDText.Location = new System.Drawing.Point(507, 61);
            this.orderIDText.Name = "orderIDText";
            this.orderIDText.ReadOnly = true;
            this.orderIDText.Size = new System.Drawing.Size(300, 20);
            this.orderIDText.TabIndex = 26;
            // 
            // MPDTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderIDText);
            this.Controls.Add(this.expYYLabel);
            this.Controls.Add(this.expMMLabel);
            this.Controls.Add(this.expYYCombo);
            this.Controls.Add(this.expMMCombo);
            this.Controls.Add(this.payerIdentifierLabel);
            this.Controls.Add(this.spanLabel);
            this.Controls.Add(this.spanTextBox);
            this.Controls.Add(this.payerIdentifierBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountTokenText);
            this.Controls.Add(this.postParametersLabel);
            this.Controls.Add(this.postParametersText);
            this.Controls.Add(this.hostPayWB);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.tccLabel);
            this.Controls.Add(this.tccComboBox);
            this.Controls.Add(this.chargeTypeLabel);
            this.Controls.Add(this.transactionTypeLabel);
            this.Controls.Add(this.chargeTypeCombo);
            this.Controls.Add(this.transactionTypeCombo);
            this.Controls.Add(this.exitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MPDTransactions";
            this.Text = "OpenEdge Host Pay Demo: Managed Payer Data Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MPDTransactions_FormClosing);
            this.Load += new System.EventHandler(this.MPDTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox transactionTypeCombo;
        private System.Windows.Forms.ComboBox chargeTypeCombo;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label chargeTypeLabel;
        private System.Windows.Forms.ComboBox tccComboBox;
        private System.Windows.Forms.Label tccLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.WebBrowser hostPayWB;
        private System.Windows.Forms.RichTextBox postParametersText;
        private System.Windows.Forms.Label postParametersLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountTokenText;
        private System.Windows.Forms.TextBox payerIdentifierBox;
        private System.Windows.Forms.TextBox spanTextBox;
        private System.Windows.Forms.Label spanLabel;
        private System.Windows.Forms.Label payerIdentifierLabel;
        private System.Windows.Forms.ComboBox expMMCombo;
        private System.Windows.Forms.ComboBox expYYCombo;
        private System.Windows.Forms.Label expMMLabel;
        private System.Windows.Forms.Label expYYLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderIDText;
    }
}