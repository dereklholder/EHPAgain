namespace EHPAgain
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.receiptTextNew = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptTextNew
            // 
            this.receiptTextNew.Location = new System.Drawing.Point(13, 13);
            this.receiptTextNew.Multiline = true;
            this.receiptTextNew.Name = "receiptTextNew";
            this.receiptTextNew.ReadOnly = true;
            this.receiptTextNew.Size = new System.Drawing.Size(285, 456);
            this.receiptTextNew.TabIndex = 0;
            this.receiptTextNew.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(13, 475);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 1;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(223, 475);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 2;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 675);
            this.Controls.Add(this.print);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.receiptTextNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiptTextNew;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button print;

    }
}