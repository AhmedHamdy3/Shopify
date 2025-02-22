using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopify.presentation
{
    public partial class adminHomeForm : Form
    {
        public adminHomeForm()
        {
            InitializeComponent();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            adminManageProduct adminManageProduct = new adminManageProduct();
            adminManageProduct.StartPosition = FormStartPosition.Manual;
            adminManageProduct.Location = this.Location;
            adminManageProduct.Show();
            this.Close();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            adminManageUsers adminManageUsers = new adminManageUsers();
            adminManageUsers.StartPosition = FormStartPosition.Manual;
            adminManageUsers.Location = this.Location;
            adminManageUsers.Show();
            this.Close();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            adminManageCategories adminManageCategories = new adminManageCategories();
            adminManageCategories.StartPosition = FormStartPosition.Manual;
            adminManageCategories.Location = this.Location;
            adminManageCategories.Show();
            this.Close();
        }
    }
}
