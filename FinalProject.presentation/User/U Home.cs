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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shopify.presentation
{
    public partial class homeForm : Form
    {
        ProductService productService;
        FavouritesServices favouritesServices;
        bool menu;
        public homeForm()
        {
            InitializeComponent();
            productService = new ProductService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            favouritesServices = new FavouritesServices(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            productId = -1;
            menu = false;
            panel1.Visible = false;
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            DataTable dt = productService.getProducts();
            dgv_products.DataSource = dt;
            dgv_products.Columns["ID"].Visible = false;
        }

        int productId;
        //private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //productId = (int)dgv_products.SelectedRows[0].Cells[0].Value;
        //}

        private void dgv_products_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            productId = (int)dgv_products.SelectedRows[0].Cells[0].Value;
            panel1.Visible = true;
        }

        private void btn_addToFavourite_Click(object sender, EventArgs e)
        {
            try
            {
                if (productId == -1)
                {
                    MessageBox.Show($"Select Product to be added");
                }
                else
                {
                    int x = favouritesServices.insertFavourite(GlobalData.user_id, productId);
                    MessageBox.Show($"Added to favourite");
                    panel1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Already in the favourites");
                panel1.Visible = false;
            }
        }

        private void pb_profileImage_Click(object sender, EventArgs e)
        {
            if (menu)
            {
                btn_favourite.Visible = false;
                btn_logout.Visible = false;
                btn_profile.Visible = false;
                pnl_driver.Visible = false;
                menu = false;
            }
            else
            {
                btn_favourite.Visible = true;
                btn_logout.Visible = true;
                btn_profile.Visible = true;
                pnl_driver.Visible = true;
                menu = true;
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profileForm profile = new profileForm();
            profile.StartPosition = FormStartPosition.Manual;
            profile.Location = this.Location;
            profile.Show();
            this.Close();
        }
        private void btn_favourite_Click(object sender, EventArgs e)
        {
            FavouritesForm favourites = new FavouritesForm();
            favourites.StartPosition = FormStartPosition.Manual;
            favourites.Location = this.Location;
            favourites.Show();
            this.Close();
        }
        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            GlobalData.user_id = -1;
            GlobalData.startForm.StartPosition = FormStartPosition.Manual;
            GlobalData.startForm.Location = this.Location;
            GlobalData.startForm.Show();
            this.Close();
        }

        //private void btn_showFavourites_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_showProfile_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_logout_Click(object sender, EventArgs e)
        //{

        //}

        //private void pb_profile_Click(object sender, EventArgs e)
        //{

        //}
    }
}
