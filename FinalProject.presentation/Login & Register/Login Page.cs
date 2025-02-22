using Shopify.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopify.presentation
{
    public partial class loginForm : Form
    {
        UserService userService;
        bool showPassword;
        public loginForm()
        {
            InitializeComponent();
            userService = new UserService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            showPassword = false;
        }

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    GlobalData.startForm.StartPosition = FormStartPosition.Manual;
        //    GlobalData.startForm.Location = this.Location;
        //    GlobalData.startForm.Show();
        //    this.Close();
        //}

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            DataTable dt = userService.getUser(email, password);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Role"].ToString() == "Admin")
                {
                    adminHomeForm adminHomeForm = new adminHomeForm();
                    adminHomeForm.StartPosition = FormStartPosition.Manual;
                    adminHomeForm.Location = this.Location;
                    adminHomeForm.Show();
                }
                else
                {
                    homeForm homeForm = new homeForm();
                    homeForm.StartPosition = FormStartPosition.Manual;
                    homeForm.Location = this.Location;
                    homeForm.Show();
                }
                this.Close();
                GlobalData.user_id = (int)dt.Rows[0]["UserId"];
            }
            else
            {
                MessageBox.Show("Email Or Password not correct");
            }
        }

        private void lbl_createAccount_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.StartPosition = FormStartPosition.Manual;
            register.Location = this.Location;
            register.Show();
            this.Close();
        }

        private void pb_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            DataTable dt = userService.getUser(email, password);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Role"].ToString() == "Admin")
                {
                    adminHomeForm adminHomeForm = new adminHomeForm();
                    adminHomeForm.StartPosition = FormStartPosition.Manual;
                    adminHomeForm.Location = this.Location;
                    adminHomeForm.Show();
                }
                else
                {
                    homeForm homeForm = new homeForm();
                    homeForm.StartPosition = FormStartPosition.Manual;
                    homeForm.Location = this.Location;
                    homeForm.Show();
                }
                this.Close();
                GlobalData.user_id = (int)dt.Rows[0]["UserId"];
            }
            else
            {
                MessageBox.Show("Email Or Password not correct");
            }
        }

        private void lbl_showPassword_Click(object sender, EventArgs e)
        {
            HandleShowPassword();
        }

        private void pb_showPassword_Click(object sender, EventArgs e)
        {
            HandleShowPassword();
        }
        private void HandleShowPassword()
        {
            if (showPassword == false)
            {
                txt_password.PasswordChar = '\0';
                showPassword = true;
                pb_showPassword.Visible = false;
                pb_unshowPassword.Visible = true;
            }
            else
            {
                txt_password.PasswordChar = '*';
                showPassword = false;
                pb_showPassword.Visible = true;
                pb_unshowPassword.Visible = false;
            }
        }

        private void pb_unshowPassword_Click(object sender, EventArgs e)
        {
            HandleShowPassword();
        }
    }
}
