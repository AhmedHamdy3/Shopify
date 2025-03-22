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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shopify.presentation
{
    public partial class adminManageProduct : Form
    {
        ProductService productService;
        CategoryServices categoryServices;
        int id;
        public adminManageProduct()
        {
            InitializeComponent();
            productService = new ProductService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            categoryServices = new CategoryServices(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            id = -1;
        }

        private void adminManageProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = productService.getProducts();
            dgv_products.DataSource = dt;
            cb_category.DataSource = categoryServices.getCategories();
            cb_category.DisplayMember = "Category";
            cb_category.ValueMember = "ID";
            HideLabelsAndInputs();
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            adminHomeForm adminHomeForm = new adminHomeForm();
            adminHomeForm.StartPosition = FormStartPosition.Manual;
            adminHomeForm.Location = this.Location;
            adminHomeForm.Show();
            this.Close();
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            string productName = txt_prodcutName.Text;
            string priceText = txt_price.Text;
            double price;
            int category = (int)cb_category.SelectedValue;
            int flag = 1;
            if (!Regex.IsMatch(productName, @"^[a-zA-Z0-9 ]{3,}$"))
            {
                flag = 0;
                MessageBox.Show("Product name must be at least 3 characters long and contain only letters and numbers");
            }
            if (!Regex.IsMatch(priceText, @"^\d*\.?\d+$"))
            {
                flag = 0;
                MessageBox.Show("The price must be a number");
            }
            if (flag == 1)
            {
                price = Convert.ToDouble(priceText);
                int x = productService.insertProduct(productName, price, category);
                if (x > 0)
                {
                    //MessageBox.Show("Added");

                    tm_addedSuccessfully.Interval = 1500;
                    tm_addedSuccessfully.Tick += new System.EventHandler(this.tm_addedSuccessfully_Tick);
                    tm_addedSuccessfully.Start();
                    btn_addedSuccessfully.Visible = true;

                    DataTable dt = productService.getProducts();
                    dgv_products.DataSource = dt;
                    txt_prodcutName.Text = txt_price.Text = "";
                    cb_category.SelectedIndex = 0;
                    HideLabelsAndInputs();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void dgv_products_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_products.SelectedRows[0].Cells["ID"].Value;
            txt_prodcutName.Text = dgv_products.SelectedRows[0].Cells["Product"].Value.ToString();
            txt_price.Text = dgv_products.SelectedRows[0].Cells["Price"].Value.ToString();
            cb_category.SelectedIndex = cb_category.FindStringExact(dgv_products.SelectedRows[0].Cells["Category"].Value.ToString());
            ShowLabelsAndInputs();
            btn_update.Visible = btn_delete.Visible =
                pnl_updateproduct.Visible = pnl_deleteproduct.Visible = true;

            btn_insert.Visible = lbl_enterProductData.Visible = false;
        }
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Select product to be updated");
            }
            else
            {

                string productName = txt_prodcutName.Text;
                string priceText = txt_price.Text;
                double price;
                int category = (int)cb_category.SelectedValue;
                int flag = 1;

                if (!Regex.IsMatch(productName, @"^[a-zA-Z0-9 ]{3,}$"))
                {
                    flag = 0;
                    MessageBox.Show("Product name must be at least 3 characters long and contain only letters and numbers");
                }
                if (!Regex.IsMatch(priceText, @"^\d*\.?\d+$"))
                {
                    flag = 0;
                    MessageBox.Show("The price must be a number");
                }
                if (flag == 1)
                {
                    price = Convert.ToDouble(priceText);

                    int x = productService.updateProduct(id, productName, price, category);
                    if (x > 0)
                    {
                        //MessageBox.Show("Updated");

                        tm1_update.Interval = 1500;
                        tm1_update.Tick += new System.EventHandler(this.tm1_update_Tick);
                        btn_updatedSuccessfully.Visible = true;
                        tm1_update.Start();

                        DataTable dt = productService.getProducts();
                        dgv_products.DataSource = dt;
                        txt_prodcutName.Text = txt_price.Text = "";
                        cb_category.SelectedIndex = 0;
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

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("You should select product to delete");
            }
            else
            {
                if (MessageBox.Show("are you sure to delete this Product?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = productService.deleteProduct(id);
                    if (x > 0)
                    {
                        //MessageBox.Show("Deleted");
                        tm_deletedSuccessfully.Interval = 1500;
                        tm_deletedSuccessfully.Tick += new System.EventHandler(this.tm_deletedSuccessfully_Tick);
                        tm_deletedSuccessfully.Start();
                        btn_deletedSuccessfully.Visible = true;

                        DataTable dt = productService.getProducts();
                        dgv_products.DataSource = dt;
                        txt_prodcutName.Text = txt_price.Text = "";
                        cb_category.SelectedIndex = 0;
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
            pnl_deleteproduct.Visible = pnl_updateproduct.Visible = pnl_createnewproduct.Visible =
            btn_delete.Visible = btn_update.Visible = btn_insert.Visible =
                lbl_category.Visible = lbl_productName.Visible = lbl_price.Visible = lbl_enterProductData.Visible =
                txt_price.Visible = txt_prodcutName.Visible = cb_category.Visible =
                 panel1.Visible = panel2.Visible = panel6.Visible =
                false;
            pnl_addnewproduct.Visible = btn_addNewUser.Visible = true;
        }

        private void ShowLabelsAndInputs()
        {
            pnl_createnewproduct.Visible =
            btn_insert.Visible =
            lbl_category.Visible = lbl_productName.Visible = lbl_price.Visible = lbl_enterProductData.Visible =
            txt_price.Visible = txt_prodcutName.Visible = cb_category.Visible =
             panel1.Visible = panel2.Visible = panel6.Visible =
            true;
            pnl_addnewproduct.Visible = btn_addNewUser.Visible = false;
        }

        private void btn_addNewUser_Click(object sender, EventArgs e)
        {
            txt_prodcutName.Select();
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
