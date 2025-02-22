namespace Shopify.presentation
{
    partial class registerForm
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
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_address = new TextBox();
            nud_age = new NumericUpDown();
            panel3 = new Panel();
            pb_unShowPassword = new PictureBox();
            lbl_emailerror = new Label();
            lbl_passworderror = new Label();
            lbl_login = new Label();
            label4 = new Label();
            lbl_ster = new Label();
            pb_register = new PictureBox();
            label3 = new Label();
            chb_terms = new CheckBox();
            label7 = new Label();
            lbl_showPassword = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pb_showPassword = new PictureBox();
            panel6 = new Panel();
            lbl_ageerror = new Label();
            lbl_usernameerror = new Label();
            label5 = new Label();
            panel11 = new Panel();
            panel12 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_register).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).BeginInit();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Location = new Point(10, 10);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(300, 20);
            txt_username.TabIndex = 7;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Location = new Point(10, 10);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(300, 20);
            txt_email.TabIndex = 10;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(10, 10);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(300, 20);
            txt_password.TabIndex = 11;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.None;
            txt_address.Location = new Point(10, 10);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(300, 20);
            txt_address.TabIndex = 9;
            // 
            // nud_age
            // 
            nud_age.BorderStyle = BorderStyle.None;
            nud_age.Location = new Point(10, 10);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(300, 23);
            nud_age.TabIndex = 8;
            nud_age.ValueChanged += nud_age_ValueChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 124, 127);
            panel3.Controls.Add(pb_unShowPassword);
            panel3.Controls.Add(lbl_emailerror);
            panel3.Controls.Add(lbl_passworderror);
            panel3.Controls.Add(lbl_login);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lbl_ster);
            panel3.Controls.Add(pb_register);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(chb_terms);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lbl_showPassword);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pb_showPassword);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(510, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 663);
            panel3.TabIndex = 15;
            // 
            // pb_unShowPassword
            // 
            pb_unShowPassword.Image = Properties.Resources.Screenshot_2025_02_22_192515;
            pb_unShowPassword.Location = new Point(319, 331);
            pb_unShowPassword.Name = "pb_unShowPassword";
            pb_unShowPassword.Size = new Size(29, 17);
            pb_unShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_unShowPassword.TabIndex = 21;
            pb_unShowPassword.TabStop = false;
            pb_unShowPassword.Visible = false;
            pb_unShowPassword.Click += pb_unShowPassword_Click;
            // 
            // lbl_emailerror
            // 
            lbl_emailerror.AutoSize = true;
            lbl_emailerror.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_emailerror.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_emailerror.Location = new Point(70, 292);
            lbl_emailerror.Name = "lbl_emailerror";
            lbl_emailerror.Size = new Size(0, 17);
            lbl_emailerror.TabIndex = 22;
            // 
            // lbl_passworderror
            // 
            lbl_passworderror.AutoSize = true;
            lbl_passworderror.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passworderror.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_passworderror.Location = new Point(70, 400);
            lbl_passworderror.Name = "lbl_passworderror";
            lbl_passworderror.Size = new Size(0, 17);
            lbl_passworderror.TabIndex = 21;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.BackColor = Color.Transparent;
            lbl_login.Cursor = Cursors.Hand;
            lbl_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.White;
            lbl_login.Location = new Point(66, 563);
            lbl_login.Name = "lbl_login";
            lbl_login.RightToLeft = RightToLeft.No;
            lbl_login.Size = new Size(48, 20);
            lbl_login.TabIndex = 19;
            lbl_login.Text = "Login";
            lbl_login.Click += lbl_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 563);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "account?";
            // 
            // lbl_ster
            // 
            lbl_ster.AutoSize = true;
            lbl_ster.BackColor = Color.Transparent;
            lbl_ster.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_ster.ForeColor = Color.White;
            lbl_ster.Location = new Point(-3, 45);
            lbl_ster.Name = "lbl_ster";
            lbl_ster.Size = new Size(95, 54);
            lbl_ster.TabIndex = 18;
            lbl_ster.Text = "ster";
            // 
            // pb_register
            // 
            pb_register.Cursor = Cursors.Hand;
            pb_register.Image = Properties.Resources.Screenshot_2025_02_21_165535;
            pb_register.Location = new Point(72, 474);
            pb_register.Name = "pb_register";
            pb_register.Size = new Size(145, 49);
            pb_register.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_register.TabIndex = 19;
            pb_register.TabStop = false;
            pb_register.Click += pb_register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(196, 449);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 21;
            label3.Text = "Terms and Conditions";
            // 
            // chb_terms
            // 
            chb_terms.AutoSize = true;
            chb_terms.BackColor = Color.Transparent;
            chb_terms.Cursor = Cursors.Hand;
            chb_terms.FlatAppearance.BorderSize = 0;
            chb_terms.ForeColor = Color.White;
            chb_terms.Location = new Point(75, 448);
            chb_terms.Name = "chb_terms";
            chb_terms.Size = new Size(134, 24);
            chb_terms.TabIndex = 12;
            chb_terms.Text = "I do accept the ";
            chb_terms.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 124, 127);
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 150);
            label7.Name = "label7";
            label7.Size = new Size(270, 31);
            label7.TabIndex = 17;
            label7.Text = "Credentials Information";
            // 
            // lbl_showPassword
            // 
            lbl_showPassword.AutoSize = true;
            lbl_showPassword.Cursor = Cursors.Hand;
            lbl_showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPassword.ForeColor = Color.White;
            lbl_showPassword.Location = new Point(343, 329);
            lbl_showPassword.Name = "lbl_showPassword";
            lbl_showPassword.Size = new Size(47, 20);
            lbl_showPassword.TabIndex = 13;
            lbl_showPassword.Text = "Show";
            lbl_showPassword.Click += lbl_showPassword_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 89, 91);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(68, 352);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 89, 91);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(68, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 45);
            panel2.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 124, 127);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 217);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 124, 127);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(66, 329);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // pb_showPassword
            // 
            pb_showPassword.Image = Properties.Resources.Screenshot_2025_02_21_163348;
            pb_showPassword.Location = new Point(321, 333);
            pb_showPassword.Name = "pb_showPassword";
            pb_showPassword.Size = new Size(28, 14);
            pb_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_showPassword.TabIndex = 10;
            pb_showPassword.TabStop = false;
            pb_showPassword.Click += pb_showPassword_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lbl_ageerror);
            panel6.Controls.Add(lbl_usernameerror);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(511, 663);
            panel6.TabIndex = 18;
            // 
            // lbl_ageerror
            // 
            lbl_ageerror.AutoSize = true;
            lbl_ageerror.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ageerror.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_ageerror.Location = new Point(126, 401);
            lbl_ageerror.Name = "lbl_ageerror";
            lbl_ageerror.Size = new Size(0, 17);
            lbl_ageerror.TabIndex = 20;
            // 
            // lbl_usernameerror
            // 
            lbl_usernameerror.AutoSize = true;
            lbl_usernameerror.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usernameerror.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_usernameerror.Location = new Point(127, 291);
            lbl_usernameerror.Name = "lbl_usernameerror";
            lbl_usernameerror.Size = new Size(0, 17);
            lbl_usernameerror.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 124, 127);
            label5.Location = new Point(418, 45);
            label5.Name = "label5";
            label5.Size = new Size(106, 54);
            label5.TabIndex = 12;
            label5.Text = "Regi";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(230, 230, 230);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(125, 463);
            panel11.Name = "panel11";
            panel11.Size = new Size(322, 45);
            panel11.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(txt_address);
            panel12.Location = new Point(1, 1);
            panel12.Name = "panel12";
            panel12.Size = new Size(320, 43);
            panel12.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(0, 124, 127);
            label11.Location = new Point(393, 563);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 14;
            label11.Text = "Already have an";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(122, 440);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 9;
            label12.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 124, 127);
            label8.Location = new Point(116, 150);
            label8.Name = "label8";
            label8.Size = new Size(232, 31);
            label8.TabIndex = 17;
            label8.Text = "General Information";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(124, 352);
            panel7.Name = "panel7";
            panel7.Size = new Size(322, 45);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(nud_age);
            panel8.Location = new Point(1, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(320, 43);
            panel8.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(230, 230, 230);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(124, 241);
            panel9.Name = "panel9";
            panel9.Size = new Size(322, 45);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txt_username);
            panel10.Location = new Point(1, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(320, 43);
            panel10.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(121, 216);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 7;
            label14.Text = "Username";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(122, 329);
            label15.Name = "label15";
            label15.Size = new Size(37, 20);
            label15.TabIndex = 8;
            label15.Text = "Age";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Name = "registerForm";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_register).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_address;
        private NumericUpDown nud_age;
        private Panel panel3;
        private Label lbl_showPassword;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Panel panel6;
        private Label label8;
        private Label label11;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label14;
        private Label label15;
        private Panel panel11;
        private Panel panel12;
        private Label label12;
        private PictureBox pb_showPassword;
        private PictureBox pb_register;
        private Label label5;
        private Label lbl_ster;
        private Label label3;
        private CheckBox chb_terms;
        private Label lbl_login;
        private Label label4;
        private Label lbl_usernameerror;
        private Label lbl_ageerror;
        private Label lbl_emailerror;
        private Label lbl_passworderror;
        private PictureBox pb_unShowPassword;
    }
}