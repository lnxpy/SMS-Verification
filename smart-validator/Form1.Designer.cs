namespace smart_validator
{
    partial class Form1
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
            this.tc_mycontrol = new System.Windows.Forms.TabControl();
            this.tpage_signin = new System.Windows.Forms.TabPage();
            this.lnk_forgetpass = new System.Windows.Forms.LinkLabel();
            this.lnk_newacc = new System.Windows.Forms.LinkLabel();
            this.btn_signin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpage_signup = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtboxC_phone = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxC_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxC_passconfirm = new System.Windows.Forms.TextBox();
            this.txtboxC_password = new System.Windows.Forms.TextBox();
            this.txtboxC_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_mycontrol.SuspendLayout();
            this.tpage_signin.SuspendLayout();
            this.tpage_signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_mycontrol
            // 
            this.tc_mycontrol.Controls.Add(this.tpage_signin);
            this.tc_mycontrol.Controls.Add(this.tpage_signup);
            this.tc_mycontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_mycontrol.Location = new System.Drawing.Point(0, 0);
            this.tc_mycontrol.Name = "tc_mycontrol";
            this.tc_mycontrol.SelectedIndex = 0;
            this.tc_mycontrol.Size = new System.Drawing.Size(355, 364);
            this.tc_mycontrol.TabIndex = 0;
            // 
            // tpage_signin
            // 
            this.tpage_signin.Controls.Add(this.lnk_forgetpass);
            this.tpage_signin.Controls.Add(this.lnk_newacc);
            this.tpage_signin.Controls.Add(this.btn_signin);
            this.tpage_signin.Controls.Add(this.label4);
            this.tpage_signin.Controls.Add(this.label3);
            this.tpage_signin.Controls.Add(this.txtbox_password);
            this.tpage_signin.Controls.Add(this.txtbox_username);
            this.tpage_signin.Controls.Add(this.label1);
            this.tpage_signin.Location = new System.Drawing.Point(4, 22);
            this.tpage_signin.Name = "tpage_signin";
            this.tpage_signin.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_signin.Size = new System.Drawing.Size(347, 338);
            this.tpage_signin.TabIndex = 0;
            this.tpage_signin.Text = "Sign in";
            this.tpage_signin.UseVisualStyleBackColor = true;
            // 
            // lnk_forgetpass
            // 
            this.lnk_forgetpass.AutoSize = true;
            this.lnk_forgetpass.Location = new System.Drawing.Point(118, 235);
            this.lnk_forgetpass.Name = "lnk_forgetpass";
            this.lnk_forgetpass.Size = new System.Drawing.Size(114, 13);
            this.lnk_forgetpass.TabIndex = 5;
            this.lnk_forgetpass.TabStop = true;
            this.lnk_forgetpass.Text = "Forget your password?";
            this.lnk_forgetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_forgetpass_LinkClicked);
            // 
            // lnk_newacc
            // 
            this.lnk_newacc.AutoSize = true;
            this.lnk_newacc.Location = new System.Drawing.Point(96, 316);
            this.lnk_newacc.Name = "lnk_newacc";
            this.lnk_newacc.Size = new System.Drawing.Size(154, 13);
            this.lnk_newacc.TabIndex = 4;
            this.lnk_newacc.TabStop = true;
            this.lnk_newacc.Text = "Have no account? Create one.";
            this.lnk_newacc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_newacc_LinkClicked);
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(137, 201);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(75, 23);
            this.btn_signin.TabIndex = 3;
            this.btn_signin.Text = "Sign in";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(120, 165);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(112, 20);
            this.txtbox_password.TabIndex = 1;
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(120, 118);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(112, 20);
            this.txtbox_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // tpage_signup
            // 
            this.tpage_signup.Controls.Add(this.label13);
            this.tpage_signup.Controls.Add(this.label14);
            this.tpage_signup.Controls.Add(this.txtboxC_phone);
            this.tpage_signup.Controls.Add(this.button2);
            this.tpage_signup.Controls.Add(this.button1);
            this.tpage_signup.Controls.Add(this.label12);
            this.tpage_signup.Controls.Add(this.label11);
            this.tpage_signup.Controls.Add(this.label10);
            this.tpage_signup.Controls.Add(this.label9);
            this.tpage_signup.Controls.Add(this.label8);
            this.tpage_signup.Controls.Add(this.txtboxC_email);
            this.tpage_signup.Controls.Add(this.label7);
            this.tpage_signup.Controls.Add(this.label6);
            this.tpage_signup.Controls.Add(this.label5);
            this.tpage_signup.Controls.Add(this.txtboxC_passconfirm);
            this.tpage_signup.Controls.Add(this.txtboxC_password);
            this.tpage_signup.Controls.Add(this.txtboxC_username);
            this.tpage_signup.Controls.Add(this.label2);
            this.tpage_signup.Location = new System.Drawing.Point(4, 22);
            this.tpage_signup.Name = "tpage_signup";
            this.tpage_signup.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_signup.Size = new System.Drawing.Size(347, 338);
            this.tpage_signup.TabIndex = 1;
            this.tpage_signup.Text = "Sign up";
            this.tpage_signup.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(233, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Phone Number";
            // 
            // txtboxC_phone
            // 
            this.txtboxC_phone.Location = new System.Drawing.Point(127, 161);
            this.txtboxC_phone.Name = "txtboxC_phone";
            this.txtboxC_phone.Size = new System.Drawing.Size(100, 20);
            this.txtboxC_phone.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(236, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(202, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(178, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(202, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email";
            // 
            // txtboxC_email
            // 
            this.txtboxC_email.Location = new System.Drawing.Point(72, 129);
            this.txtboxC_email.Name = "txtboxC_email";
            this.txtboxC_email.Size = new System.Drawing.Size(100, 20);
            this.txtboxC_email.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // txtboxC_passconfirm
            // 
            this.txtboxC_passconfirm.Location = new System.Drawing.Point(130, 225);
            this.txtboxC_passconfirm.Name = "txtboxC_passconfirm";
            this.txtboxC_passconfirm.PasswordChar = '*';
            this.txtboxC_passconfirm.Size = new System.Drawing.Size(100, 20);
            this.txtboxC_passconfirm.TabIndex = 2;
            // 
            // txtboxC_password
            // 
            this.txtboxC_password.Location = new System.Drawing.Point(96, 193);
            this.txtboxC_password.Name = "txtboxC_password";
            this.txtboxC_password.PasswordChar = '*';
            this.txtboxC_password.Size = new System.Drawing.Size(100, 20);
            this.txtboxC_password.TabIndex = 2;
            // 
            // txtboxC_username
            // 
            this.txtboxC_username.Location = new System.Drawing.Point(96, 97);
            this.txtboxC_username.Name = "txtboxC_username";
            this.txtboxC_username.Size = new System.Drawing.Size(100, 20);
            this.txtboxC_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 364);
            this.Controls.Add(this.tc_mycontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Smart Validator";
            this.tc_mycontrol.ResumeLayout(false);
            this.tpage_signin.ResumeLayout(false);
            this.tpage_signin.PerformLayout();
            this.tpage_signup.ResumeLayout(false);
            this.tpage_signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_mycontrol;
        private System.Windows.Forms.TabPage tpage_signin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpage_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnk_forgetpass;
        private System.Windows.Forms.LinkLabel lnk_newacc;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxC_password;
        private System.Windows.Forms.TextBox txtboxC_username;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxC_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxC_passconfirm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtboxC_phone;
    }
}

