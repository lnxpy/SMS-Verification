namespace smart_validator
{
    partial class Form2
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
            this.txtbox_verification = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_passconfirm = new System.Windows.Forms.TextBox();
            this.lnk_forgetpass = new System.Windows.Forms.LinkLabel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_verification
            // 
            this.txtbox_verification.Location = new System.Drawing.Point(149, 99);
            this.txtbox_verification.Name = "txtbox_verification";
            this.txtbox_verification.Size = new System.Drawing.Size(118, 20);
            this.txtbox_verification.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reset Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verification Code";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Password";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(149, 159);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(104, 20);
            this.txtbox_password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Passowrd";
            // 
            // txtbox_passconfirm
            // 
            this.txtbox_passconfirm.Location = new System.Drawing.Point(149, 194);
            this.txtbox_passconfirm.Name = "txtbox_passconfirm";
            this.txtbox_passconfirm.PasswordChar = '*';
            this.txtbox_passconfirm.Size = new System.Drawing.Size(104, 20);
            this.txtbox_passconfirm.TabIndex = 7;
            // 
            // lnk_forgetpass
            // 
            this.lnk_forgetpass.AutoSize = true;
            this.lnk_forgetpass.Location = new System.Drawing.Point(32, 123);
            this.lnk_forgetpass.Name = "lnk_forgetpass";
            this.lnk_forgetpass.Size = new System.Drawing.Size(210, 13);
            this.lnk_forgetpass.TabIndex = 9;
            this.lnk_forgetpass.TabStop = true;
            this.lnk_forgetpass.Text = "Verification code not sent? Send me again.";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(34, 246);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Set New Password";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 343);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lnk_forgetpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_passconfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_verification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_verification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_passconfirm;
        private System.Windows.Forms.LinkLabel lnk_forgetpass;
        private System.Windows.Forms.Button btn_reset;
    }
}