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
    public partial class FavouritesForm : Form
    {
        FavouritesServices favouritesServices;
        ProductService productService;
        bool menu = false;
        int productId;

        public FavouritesForm()
        {
            InitializeComponent();
            favouritesServices = new FavouritesServices(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            productService = new ProductService(ConfigurationManager.ConnectionStrings["Shopify"].ConnectionString);
            panel3.Visible = false;
        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            DataTable dt = favouritesServices.getFavourites(GlobalData.user_id);
            dgv_favourites.DataSource = dt;
            dgv_favourites.Columns["ID"].Visible = false;

        }

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    homeForm homeForm = new homeForm();
        //    homeForm.StartPosition = FormStartPosition.Manual;
        //    homeForm.Location = this.Location;
        //    homeForm.Show();
        //    this.Close();
        //}

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int AffectedRows = favouritesServices.deleteFavourite(GlobalData.user_id, productId);
            if (AffectedRows > 0)
            {
                MessageBox.Show("Delete Favourite");
                DataTable dt = favouritesServices.getFavourites(GlobalData.user_id);
                dgv_favourites.DataSource = dt;
                dgv_favourites.Columns["ID"].Visible = false;
                panel3.Visible = false;
            }
            else
            {
                MessageBox.Show("Data Not Deleted");
            }
        }

        private void dgv_favourites_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            productId = (int)dgv_favourites.SelectedRows[0].Cells[0].Value;
            panel3.Visible = true;
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            goToHome();
        }
        private void goToHome()
        {
            homeForm homeform = new homeForm();
            homeform.StartPosition = FormStartPosition.Manual;
            homeform.Location = this.Location;
            homeform.Show();
            this.Close();
        }

        private void pB_logo_Click_1(object sender, EventArgs e)
        {
            goToHome();
        }

        private void lbl_shopify_Click_1(object sender, EventArgs e)
        {
            goToHome();
        }

        private void pb_profileImage_Click(object sender, EventArgs e)
        {
            if (menu)
            {
                btn_home.Visible = false;
                btn_logOut.Visible = false;
                btn_profile.Visible = false;
                pnl_driver.Visible = false;
                menu = false;
            }
            else
            {
                btn_home.Visible = true;
                btn_logOut.Visible = true;
                btn_profile.Visible = true;
                pnl_driver.Visible = true;
                menu = true;
            }
        }
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            GlobalData.user_id = -1;
            GlobalData.startForm.StartPosition = FormStartPosition.Manual;
            GlobalData.startForm.Location = this.Location;
            GlobalData.startForm.Show();
            this.Close();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profileForm profile = new profileForm();
            profile.StartPosition = FormStartPosition.Manual;
            profile.Location = this.Location;
            profile.Show();
            this.Close();
        }
    }
}
