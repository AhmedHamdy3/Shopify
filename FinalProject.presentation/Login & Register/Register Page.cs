using Shopify.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shopify.presentation
{
    public partial class registerForm : Form
    {
        UserService userService;
        private bool isVisiblePass = false;

        public registerForm()
        {
            InitializeComponent();
            userService = new UserService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            txt_username.Select();
        }



        private void lbl_login_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9 ]{3,}$"))
            {
                lbl_usernameerror.Text = "Username must be at least 3 characters long and \ncontain only letters and numbers";
            }
            else
            {
                lbl_usernameerror.Text = "";
            }
        }

        private void nud_age_ValueChanged(object sender, EventArgs e)
        {
            //string username = txt_username.Text;
            int age = (int)nud_age.Value;
            if (age < 18 || age > 100)
            {
                lbl_ageerror.Text = "Age must be a number between 18 and 99.";
            }
            else
            {
                lbl_ageerror.Text = "";
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbl_emailerror.Text = "Please enter a valid email address (e.g., example@mail.com).";
            }
            else
            {
                lbl_emailerror.Text = "";
            }

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {
                lbl_passworderror.Text = "Password must be at least 8 characters long and \ninclude at least one uppercase letter, one lowercase \nletter, and one number.";
            }
            else
            {
                lbl_passworderror.Text = "";
            }

        }

        private void cbtn_register_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string email = txt_email.Text;
                string password = txt_password.Text;
                int age = (int)nud_age.Value;
                string address = txt_address.Text;
                int flag = 1;
                if (!Regex.IsMatch(username, @"^[a-zA-Z0-9 ]{3,}$"))
                {
                    flag = 0;
                    MessageBox.Show("Username must be at least 3 characters long and contain only letters and numbers");
                }
                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                {
                    flag = 0;

                    MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.");
                }
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    flag = 0;
                    MessageBox.Show("Please enter a valid email address (e.g., example@mail.com).");

                }
                if (age < 18 || age > 100)
                {
                    flag = 0;
                    MessageBox.Show("Age must be a number between 18 and 99.");
                }
                if (!chb_terms.Checked)
                {
                    flag = 0;
                    MessageBox.Show("You must accept the terms & conditions");

                }
                if (flag == 1)
                {
                    userService.insertUser(username, email, password, age, address, "User");
                    MessageBox.Show("Added");
                    loginForm login = new loginForm();
                    login.StartPosition = FormStartPosition.Manual;
                    login.Location = this.Location;
                    login.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisiblePass)
            {
                txt_password.PasswordChar = '\0';
                btn.Image = (Image)Properties.Resources.Invisible_white;
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn.Image = (Image)Properties.Resources.Eye_white;
            }
            isVisiblePass = !isVisiblePass;
        }
    }
}
