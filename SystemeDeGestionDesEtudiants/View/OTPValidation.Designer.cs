namespace SystemeDeGestionDesEtudiants.View
{
    partial class OTPValidation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.txtinvisible = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTP Code: ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(133, 34);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(148, 22);
            this.txtCode.TabIndex = 1;
            // 
            // btnVerifier
            // 
            this.btnVerifier.Location = new System.Drawing.Point(259, 71);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(106, 23);
            this.btnVerifier.TabIndex = 2;
            this.btnVerifier.Text = "Verifier";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // txtinvisible
            // 
            this.txtinvisible.Location = new System.Drawing.Point(12, 81);
            this.txtinvisible.Name = "txtinvisible";
            this.txtinvisible.Size = new System.Drawing.Size(100, 22);
            this.txtinvisible.TabIndex = 3;
            // 
            // OTPValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 106);
            this.Controls.Add(this.txtinvisible);
            this.Controls.Add(this.btnVerifier);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "OTPValidation";
            this.Text = "OTPValidation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.TextBox txtinvisible;
    }
}