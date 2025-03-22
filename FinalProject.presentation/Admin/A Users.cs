using Shopify.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shopify.presentation
{
    public partial class adminManageUsers : Form
    {
        UserService userService;
        public adminManageUsers()
        {
            InitializeComponent();
            userService = new UserService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            id = -1;
        }

        private void adminManageUsers_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = userService.getAllUsers();
            cb_role.DataSource = new List<Object>
            {
                new { Name = "Admin", Value = "Admin" },
                new { Name = "User", Value = "User" }
            };
            cb_role.DisplayMember = "Name";
            cb_role.ValueMember = "Value";
            HideLabelsAndInputs();
            //btn_update.Visible = btn_delete.Visible = false;
            pnl_updateuser.Visible = pnl_deleteuser.Visible = false;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string password = txt_password.Text;
                string email = txt_email.Text;
                string address = txt_address.Text;
                int age = (int)nud_age.Value;
                string role = cb_role.SelectedValue.ToString();
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
                if (flag == 1)
                {
                    userService.insertUser(username, email, password, age, address, role);
                    //MessageBox.Show("Added");

                    tm_addedSuccessfully.Interval = 1500;
                    tm_addedSuccessfully.Tick += new System.EventHandler(this.tm_addedSuccessfully_Tick);
                    tm_addedSuccessfully.Start();
                    btn_addedSuccessfully.Visible = true;

                    txt_username.Text = txt_password.Text = txt_email.Text = txt_address.Text = "";
                    nud_age.Value = 0;
                    cb_role.SelectedIndex = 0;
                    dgv_users.DataSource = userService.getAllUsers();
                    HideLabelsAndInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int id;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_users.SelectedRows[0].Cells[0].Value;
            txt_username.Text = dgv_users.SelectedRows[0].Cells["Username"].Value.ToString();
            txt_password.Text = dgv_users.SelectedRows[0].Cells["Password"].Value.ToString();
            txt_email.Text = dgv_users.SelectedRows[0].Cells["Email"].Value.ToString();
            nud_age.Value = (int)dgv_users.SelectedRows[0].Cells["Age"].Value;
            txt_address.Text = dgv_users.SelectedRows[0].Cells["Address"].Value.ToString();
            cb_role.SelectedValue = dgv_users.SelectedRows[0].Cells["Role"].Value.ToString();
            ShowLabelsAndInputs();
            btn_insert.Visible = false;

            btn_update.Visible = btn_delete.Visible = true;
            pnl_updateuser.Visible = pnl_deleteuser.Visible = true;
            pnl_createnewuser.Visible = lbl_enterUserData.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string address = txt_address.Text;
            int age = (int)nud_age.Value;
            string role = cb_role.SelectedValue.ToString();
            if (id == -1)
            {
                MessageBox.Show("Select user to update");
            }
            else
            {

                int x = userService.updateUser(id, username, email, age, address, role);
                if (x > 0)
                {
                    //MessageBox.Show("Updated");

                    tm1_update.Interval = 1500;
                    tm1_update.Tick += new System.EventHandler(this.tm1_update_Tick);
                    btn_updatedSuccessfully.Visible = true;
                    tm1_update.Start();

                    txt_username.Text = txt_password.Text = txt_email.Text = txt_address.Text = "";
                    nud_age.Value = 0;
                    cb_role.SelectedIndex = 0;
                    dgv_users.DataSource = userService.getAllUsers();
                    id = -1;
                    HideLabelsAndInputs();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Select user to delete");
            }
            else
            {
                if (MessageBox.Show("are you sure to delete this User?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = userService.deleteUser(id);
                    if (x > 0)
                    {
                        //MessageBox.Show("Deleted");

                        tm_deletedSuccessfully.Interval = 1500;
                        tm_deletedSuccessfully.Tick += new System.EventHandler(this.tm_deletedSuccessfully_Tick);
                        tm_deletedSuccessfully.Start();
                        btn_deletedSuccessfully.Visible = true;

                        txt_username.Text = txt_password.Text = txt_email.Text = txt_address.Text = "";
                        nud_age.Value = 0;
                        cb_role.SelectedIndex = 0;
                        dgv_users.DataSource = userService.getAllUsers();
                        id = -1;
                        HideLabelsAndInputs();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            adminHomeForm adminHomeForm = new adminHomeForm();
            adminHomeForm.StartPosition = FormStartPosition.Manual;
            adminHomeForm.Location = this.Location;
            adminHomeForm.Show();
            this.Close();
        }



        private void HideLabelsAndInputs()
        {
            btn_delete.Visible = btn_update.Visible = btn_insert.Visible =
                pnl_deleteuser.Visible = pnl_updateuser.Visible = pnl_createnewuser.Visible =
                lbl_enterUserData.Visible = txt_address.Visible = txt_email.Visible =
                txt_username.Visible = nud_age.Visible = cb_role.Visible = txt_password.Visible =
                lbl_address.Visible = lbl_age.Visible = lbl_email.Visible = lbl_username.Visible =
                lbl_password.Visible = lbl_role.Visible = panel1.Visible = pnl_email.Visible = pnl_password.Visible =
                panel4.Visible = panel5.Visible = pnl_role.Visible =
                false;
            btn_addNewUser.Visible = pnl_addnewuser.Visible = true;
        }

        private void ShowLabelsAndInputs()
        {
            btn_insert.Visible = pnl_createnewuser.Visible =
                lbl_enterUserData.Visible = txt_address.Visible = txt_email.Visible =
                txt_username.Visible = nud_age.Visible = cb_role.Visible = txt_password.Visible =
                lbl_address.Visible = lbl_age.Visible = lbl_email.Visible = lbl_username.Visible =
                lbl_password.Visible = lbl_role.Visible = panel1.Visible = pnl_email.Visible = pnl_password.Visible =
                panel4.Visible = panel5.Visible = pnl_role.Visible =
                true;
            btn_addNewUser.Visible = pnl_addnewuser.Visible = false;

        }

        private void btn_addNewUser_Click(object sender, EventArgs e)
        {
            ShowLabelsAndInputs();
            txt_username.Select();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            adminManageProduct adminManageProduct = new adminManageProduct();
            adminManageProduct.StartPosition = FormStartPosition.Manual;
            adminManageProduct.Location = this.Location;
            adminManageProduct.Show();
            this.Close();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            adminManageCategories adminManageCategories = new adminManageCategories();
            adminManageCategories.StartPosition = FormStartPosition.Manual;
            adminManageCategories.Location = this.Location;
            adminManageCategories.Show();
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
        private void goToHome()
        {
            adminHomeForm adminHomeForm = new adminHomeForm();
            adminHomeForm.StartPosition = FormStartPosition.Manual;
            adminHomeForm.Location = this.Location;
            adminHomeForm.Show();
            this.Close();
        }

        private void tm1_update_Tick(object sender, EventArgs e)
        {
            tm1_update.Stop();
            btn_updatedSuccessfully.Visible = false;
        }

        private void tm_addedSuccessfully_Tick(object sender, EventArgs e)
        {
            tm_addedSuccessfully.Stop();
            btn_addedSuccessfully.Visible = false;
        }

        private void tm_deletedSuccessfully_Tick(object sender, EventArgs e)
        {
            tm_deletedSuccessfully.Stop();
            btn_deletedSuccessfully.Visible = false;
        }

        private void cbtn_logout_Click(object sender, EventArgs e)
        {
            GlobalData.user_id = -1;
            GlobalData.startForm.StartPosition = FormStartPosition.Manual;
            GlobalData.startForm.Location = this.Location;
            GlobalData.startForm.Show();
            this.Close();
        }
    }
}
