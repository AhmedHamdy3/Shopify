namespace Shopify.presentation
{
    partial class chPasswordForm
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
            lbl_oldPassword = new Label();
            lbl_newPassword = new Label();
            lbl_confirmPassword = new Label();
            txt_oldPassword = new TextBox();
            txt_newPassword = new TextBox();
            txt_confirmPassword = new TextBox();
            btn_change = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_oldPassword
            // 
            lbl_oldPassword.AutoSize = true;
            lbl_oldPassword.Location = new Point(269, 90);
            lbl_oldPassword.Name = "lbl_oldPassword";
            lbl_oldPassword.Size = new Size(98, 20);
            lbl_oldPassword.TabIndex = 0;
            lbl_oldPassword.Text = "Old Password";
            // 
            // lbl_newPassword
            // 
            lbl_newPassword.AutoSize = true;
            lbl_newPassword.Location = new Point(269, 169);
            lbl_newPassword.Name = "lbl_newPassword";
            lbl_newPassword.Size = new Size(104, 20);
            lbl_newPassword.TabIndex = 1;
            lbl_newPassword.Text = "New Password";
            // 
            // lbl_confirmPassword
            // 
            lbl_confirmPassword.AutoSize = true;
            lbl_confirmPassword.Location = new Point(269, 261);
            lbl_confirmPassword.Name = "lbl_confirmPassword";
            lbl_confirmPassword.Size = new Size(127, 20);
            lbl_confirmPassword.TabIndex = 2;
            lbl_confirmPassword.Text = "Confirm Password";
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Location = new Point(440, 83);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(125, 27);
            txt_oldPassword.TabIndex = 3;
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(440, 162);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(125, 27);
            txt_newPassword.TabIndex = 4;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(440, 254);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(125, 27);
            txt_confirmPassword.TabIndex = 5;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(380, 335);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(94, 29);
            btn_change.TabIndex = 6;
            btn_change.Text = "Change";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(380, 392);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // chPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_change);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_newPassword);
            Controls.Add(txt_oldPassword);
            Controls.Add(lbl_confirmPassword);
            Controls.Add(lbl_newPassword);
            Controls.Add(lbl_oldPassword);
            Name = "chPasswordForm";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_oldPassword;
        private Label lbl_newPassword;
        private Label lbl_confirmPassword;
        private TextBox txt_oldPassword;
        private TextBox txt_newPassword;
        private TextBox txt_confirmPassword;
        private Button btn_change;
        private Button btn_back;
    }
}