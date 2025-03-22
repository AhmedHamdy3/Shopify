using Shopify.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shopify.presentation
{
    public partial class profileForm : Form
    {
        UserService userService;
        bool menu;
        public profileForm()
        {
            InitializeComponent();
            userService = new UserService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            menu = false;
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void showInfo()
        {
            DataTable dt = userService.getUserById(GlobalData.user_id);

            lbl_usernamedata.Text = txt_username.Text = dt.Rows[0]["Username"].ToString();
            lbl_emaildata.Text = txt_email.Text = dt.Rows[0]["Email"].ToString();
            lbl_addressdata.Text = txt_address.Text = dt.Rows[0]["address"].ToString();
            nud_age.Value = Convert.ToInt32(dt.Rows[0]["Age"]);
            lbl_agedata.Text = dt.Rows[0]["Age"].ToString();

            txt_oldPassword.Text = txt_newPassword.Text = txt_confirmPassword.Text = "";

            pnl_changePassword.Visible = false;
            pnl_userInfo.Visible = true;
            pnl_updateInfo.Visible = false;
        }

        private void goToHome()
        {
            homeForm homeform = new homeForm();
            homeform.StartPosition = FormStartPosition.Manual;
            homeform.Location = this.Location;
            homeform.Show();
            this.Close();
        }
        
        private void lbl_shopify_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void pB_logo_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void btn_favourites_Click(object sender, EventArgs e)
        {
            FavouritesForm favouritesForm = new FavouritesForm();
            favouritesForm.StartPosition = FormStartPosition.Manual;
            favouritesForm.Location = this.Location;
            favouritesForm.Show();
            this.Close();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            GlobalData.user_id = -1;
            GlobalData.startForm.StartPosition = FormStartPosition.Manual;
            GlobalData.startForm.Location = this.Location;
            GlobalData.startForm.Show();
            this.Close();
        }

        private void pb_profileImage_Click(object sender, EventArgs e)
        {
            if (menu)
            {
                btn_home.Visible = false;
                btn_logOut.Visible = false;
                btn_favourites.Visible = false;
                pnl_driver.Visible = false;
                menu = false;
            }
            else
            {
                btn_home.Visible = true;
                btn_logOut.Visible = true;
                btn_favourites.Visible = true;
                pnl_driver.Visible = true;
                menu = true;
            }
        }

        private void cbtn_savePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txt_oldPassword.Text;
            string newPassword = txt_newPassword.Text;
            string confirmPassword = txt_confirmPassword.Text;
            DataTable dt = userService.getUserById(GlobalData.user_id);
            if (dt.Rows[0]["Password"].ToString() == oldPassword)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Cofirm Password is not correct");
                }
                else
                {
                    if (!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.");
                    }
                    else
                    {
                        int x = userService.updateUserPassword(GlobalData.user_id, newPassword);
                        MessageBox.Show("Password Updated");
                        showInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("The old Password is not correct");
            }
        }

        private void cbtn_cancelPassword_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void cbtn_saveProfile_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string email = txt_email.Text;
            string address = txt_address.Text;
            int age = (int)nud_age.Value;
            try
            {
                int flag = 1;
                if (!Regex.IsMatch(username, @"^[a-zA-Z0-9 ]{3,}$"))
                {
                    flag = 0;
                    MessageBox.Show("Username must be at least 3 characters long and contain only letters and numbers");
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
                if (flag == 1)
                {
                    int x = userService.updateUser(GlobalData.user_id, username, email, age, address, "User");
                    MessageBox.Show("Updated");
                    showInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        private void pb_cancelProfile_Click(object sender, EventArgs e)
        {
            showInfo();

        }

        private void cbtn_editProfile_Click(object sender, EventArgs e)
        {
            pnl_updateInfo.Visible = true;
            pnl_userInfo.Visible = false;
            pnl_changePassword.Visible = false;
        }

        private void cbtn_changePassword_Click(object sender, EventArgs e)
        {
            pnl_changePassword.Visible = true;
            pnl_userInfo.Visible = false;
            pnl_updateInfo.Visible = false; ;
        }
    }
}
