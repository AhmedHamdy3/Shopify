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

namespace Shopify.presentation
{
    public partial class chPasswordForm : Form
    {
        UserService userService;
        public chPasswordForm()
        {
            InitializeComponent();
            userService = new UserService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
        }

        private void btn_change_Click(object sender, EventArgs e)
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
                    if(!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.");
                    }
                    else
                    {
                        int x = userService.updateUserPassword(GlobalData.user_id, newPassword);
                        MessageBox.Show("Password Updated");
                        profileForm profile = new profileForm();
                        profile.StartPosition = FormStartPosition.Manual;
                        profile.Location = this.Location;
                        profile.Show();
                        this.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("The old Password is not correct");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            profileForm profile = new profileForm();
            profile.StartPosition = FormStartPosition.Manual;
            profile.Location = this.Location;
            profile.Show();
            this.Close();
        }
    }
}
