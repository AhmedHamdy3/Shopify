namespace Shopify.presentation
{
    partial class loginForm
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
            lbl_email = new Label();
            lbl_password = new Label();
            txt_email = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_createAccount = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pb_showPassword = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pb_login = new PictureBox();
            lbl_showPassword = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            pb_unshowPassword = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_login).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unshowPassword).BeginInit();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.White;
            lbl_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(61, 161);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(141, 20);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Username or Email";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.White;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(62, 259);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(76, 20);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Location = new Point(10, 10);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(300, 20);
            txt_email.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(10, 10);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(300, 20);
            txt_password.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 102);
            label1.Name = "label1";
            label1.Size = new Size(138, 54);
            label1.TabIndex = 6;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(62, 112);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 7;
            label2.Text = "Need a Shopify account? ";
            // 
            // lbl_createAccount
            // 
            lbl_createAccount.AutoSize = true;
            lbl_createAccount.BackColor = Color.White;
            lbl_createAccount.Cursor = Cursors.Hand;
            lbl_createAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_createAccount.ForeColor = Color.FromArgb(0, 124, 127);
            lbl_createAccount.Location = new Point(238, 112);
            lbl_createAccount.Name = "lbl_createAccount";
            lbl_createAccount.Size = new Size(134, 20);
            lbl_createAccount.TabIndex = 8;
            lbl_createAccount.Text = "Create an account";
            lbl_createAccount.Click += lbl_createAccount_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_email);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 43);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 230, 230);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(64, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 45);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pb_unshowPassword);
            panel3.Controls.Add(pb_showPassword);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pb_login);
            panel3.Controls.Add(lbl_showPassword);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(lbl_createAccount);
            panel3.Controls.Add(lbl_email);
            panel3.Controls.Add(lbl_password);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(283, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 537);
            panel3.TabIndex = 12;
            // 
            // pb_showPassword
            // 
            pb_showPassword.Image = Properties.Resources.Screenshot_2025_02_21_154711;
            pb_showPassword.Location = new Point(321, 263);
            pb_showPassword.Name = "pb_showPassword";
            pb_showPassword.Size = new Size(20, 13);
            pb_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_showPassword.TabIndex = 13;
            pb_showPassword.TabStop = false;
            pb_showPassword.Click += pb_showPassword_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.FromArgb(0, 124, 127);
            label5.Location = new Point(62, 458);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 16;
            label5.Text = "Can't Log in?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.FromArgb(0, 124, 127);
            label4.Location = new Point(201, 425);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 15;
            label4.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.FromArgb(0, 124, 127);
            label3.Location = new Point(61, 425);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 14;
            label3.Text = "Forgot Username?";
            // 
            // pb_login
            // 
            pb_login.Image = Properties.Resources.Screenshot_2025_02_21_153730;
            pb_login.Location = new Point(56, 357);
            pb_login.Name = "pb_login";
            pb_login.Size = new Size(125, 45);
            pb_login.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_login.TabIndex = 13;
            pb_login.TabStop = false;
            pb_login.Click += pb_login_Click;
            // 
            // lbl_showPassword
            // 
            lbl_showPassword.AutoSize = true;
            lbl_showPassword.Cursor = Cursors.Hand;
            lbl_showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPassword.ForeColor = Color.FromArgb(0, 124, 127);
            lbl_showPassword.Location = new Point(340, 259);
            lbl_showPassword.Name = "lbl_showPassword";
            lbl_showPassword.Size = new Size(47, 20);
            lbl_showPassword.TabIndex = 13;
            lbl_showPassword.Text = "Show";
            lbl_showPassword.Click += lbl_showPassword_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(230, 230, 230);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(64, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 45);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txt_password);
            panel4.Location = new Point(1, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 43);
            panel4.TabIndex = 12;
            // 
            // pb_unshowPassword
            // 
            pb_unshowPassword.Image = Properties.Resources.Screenshot_2025_02_22_193153;
            pb_unshowPassword.Location = new Point(321, 263);
            pb_unshowPassword.Name = "pb_unshowPassword";
            pb_unshowPassword.Size = new Size(21, 14);
            pb_unshowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_unshowPassword.TabIndex = 13;
            pb_unshowPassword.TabStop = false;
            pb_unshowPassword.Visible = false;
            pb_unshowPassword.Click += pb_unshowPassword_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(label1);
            Controls.Add(panel3);
            Cursor = Cursors.Hand;
            Name = "loginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_login).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unshowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_email;
        private Label lbl_password;
        private TextBox txt_email;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Label lbl_createAccount;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label lbl_showPassword;
        private PictureBox pb_login;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pb_showPassword;
        private PictureBox pb_unshowPassword;
    }
}