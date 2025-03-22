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
    public partial class adminManageCategories : Form
    {
        CategoryServices categoryServices;
        int id;
        public adminManageCategories()
        {
            InitializeComponent();
            categoryServices = new CategoryServices(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            id = -1;
        }

        private void adminManageCategories_Load(object sender, EventArgs e)
        {
            dgv_categories.DataSource = categoryServices.getCategories();
            HideLabelsAndInputs();
        }


        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    adminHomeForm adminHomeForm = new adminHomeForm();
        //    adminHomeForm.StartPosition = FormStartPosition.Manual;
        //    adminHomeForm.Location = this.Location;
        //    adminHomeForm.Show();
        //    this.Close();
        //}

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            string categoryName = txt_category.Text;
            int x = categoryServices.insertCategory(categoryName);

            if (!Regex.IsMatch(categoryName, @"^[a-zA-Z0-9& ]{3,}$"))
            {
                MessageBox.Show("Category name must be at least 3 characters long and contain only letters and numbers");
            }
            else
            {
                if (x > 0)
                {
                    tm_addedSuccessfully.Interval = 1500;
                    tm_addedSuccessfully.Tick += new System.EventHandler(this.tm_addedSuccessfully_Tick);
                    tm_addedSuccessfully.Start();
                    btn_addedSuccessfully.Visible = true;

                    txt_category.Text = "";
                    dgv_categories.DataSource = categoryServices.getCategories();
                    HideLabelsAndInputs();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void dgv_categories_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_categories.SelectedRows[0].Cells[0].Value;
            txt_category.Text = dgv_categories.SelectedRows[0].Cells["Category"].Value.ToString();

            ShowLabelsAndInputs();
            pnl_updatecat.Visible = pnl_deletecategory.Visible =
            btn_update.Visible = btn_delete.Visible = true;
            pnl_createcategory.Visible = btn_insert.Visible = false;
            lbl_enterCategoryData.Visible = false;
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string categoryName = txt_category.Text;
            if (id == -1)
            {
                MessageBox.Show("Select category to update");
            }
            else
            {
                int x = categoryServices.updateCategory(id, categoryName);
                if (x > 0)
                {

                    tm1_update.Interval = 1500;
                    tm1_update.Tick += new System.EventHandler(this.tm1_update_Tick);
                    btn_updatedSuccessfully.Visible = true;
                    tm1_update.Start();

                    txt_category.Text = "";
                    dgv_categories.DataSource = categoryServices.getCategories();
                    id = -1;

                    HideLabelsAndInputs();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Select category to delete");
            }
            else
            {
                if (MessageBox.Show("are you sure to delete this category\nand all the products in it?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = categoryServices.deleteCategory(id);
                    if (x > 0)
                    {
                        tm_deletedSuccessfully.Interval = 1500;
                        tm_deletedSuccessfully.Tick += new System.EventHandler(this.tm_deletedSuccessfully_Tick);
                        tm_deletedSuccessfully.Start();
                        btn_deletedSuccessfully.Visible = true;

                        txt_category.Text = "";
                        dgv_categories.DataSource = categoryServices.getCategories();
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

        private void HideLabelsAndInputs()
        {
            pnl_deletecategory.Visible = pnl_updatecat.Visible = pnl_createcategory.Visible =
            btn_delete.Visible = btn_update.Visible = btn_insert.Visible =
                lbl_categoryName.Visible = lbl_enterCategoryData.Visible =
                txt_category.Visible =
                panel1.Visible =
                false;
            pnl_addnewcategory.Visible = btn_addNewCategory.Visible = true;
        }

        private void ShowLabelsAndInputs()
        {
            pnl_createcategory.Visible =
            btn_insert.Visible =
                lbl_categoryName.Visible = lbl_enterCategoryData.Visible =
                txt_category.Visible =
                panel1.Visible =
                true;
            pnl_addnewcategory.Visible =
            btn_addNewCategory.Visible = false;
        }

        private void btn_addNewCategory_Click(object sender, EventArgs e)
        {
            txt_category.Select();
            ShowLabelsAndInputs();
        }

        private void btn_userManagment_Click(object sender, EventArgs e)
        {
            adminManageUsers adminManageUsers = new adminManageUsers();
            adminManageUsers.StartPosition = FormStartPosition.Manual;
            adminManageUsers.Location = this.Location;
            adminManageUsers.Show();
            this.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            adminManageProduct adminManageProduct = new adminManageProduct();
            adminManageProduct.StartPosition = FormStartPosition.Manual;
            adminManageProduct.Location = this.Location;
            adminManageProduct.Show();
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
