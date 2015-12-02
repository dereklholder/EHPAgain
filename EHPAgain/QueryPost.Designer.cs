namespace EHPAgain
{
    partial class QueryPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryPost));
            this.queryPostBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryPostBox
            // 
            this.queryPostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryPostBox.Location = new System.Drawing.Point(13, 13);
            this.queryPostBox.Name = "queryPostBox";
            this.queryPostBox.ReadOnly = true;
            this.queryPostBox.Size = new System.Drawing.Size(259, 191);
            this.queryPostBox.TabIndex = 0;
            this.queryPostBox.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(104, 227);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Ok";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // QueryPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.queryPostBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryPost";
            this.Text = "Query Post";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox queryPostBox;
        private System.Windows.Forms.Button closeButton;
    }
}