namespace EmailVerifier
{
    partial class EmailVerifier
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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(12, 12);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(516, 20);
            this.txtEmailAddress.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(555, 10);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 50);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(681, 373);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // EmailVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtEmailAddress);
            this.Name = "EmailVerifier";
            this.Text = "Email Verifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}