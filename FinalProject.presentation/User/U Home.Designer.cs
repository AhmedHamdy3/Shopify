namespace Shopify.presentation
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_addToFavourite = new Button();
            pb_profileImage = new PictureBox();
            pnl_driver = new FlowLayoutPanel();
            btn_profile = new Button();
            btn_favourite = new Button();
            btn_logout = new Button();
            dgv_products = new DataGridView();
            panel7 = new Panel();
            header = new Panel();
            panel9 = new Panel();
            lbl_shopify = new Label();
            pB_logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_addToFavourite
            // 
            btn_addToFavourite.BackColor = SystemColors.Control;
            btn_addToFavourite.Cursor = Cursors.Hand;
            btn_addToFavourite.FlatAppearance.BorderSize = 0;
            btn_addToFavourite.FlatStyle = FlatStyle.Flat;
            btn_addToFavourite.ForeColor = Color.FromArgb(0, 124, 127);
            btn_addToFavourite.Location = new Point(2, 2);
            btn_addToFavourite.Name = "btn_addToFavourite";
            btn_addToFavourite.Size = new Size(268, 66);
            btn_addToFavourite.TabIndex = 2;
            btn_addToFavourite.Text = "Add To Favourite";
            btn_addToFavourite.UseVisualStyleBackColor = false;
            btn_addToFavourite.Click += btn_addToFavourite_Click;
            // 
            // pb_profileImage
            // 
            pb_profileImage.Cursor = Cursors.Hand;
            pb_profileImage.Image = (Image)resources.GetObject("pb_profileImage.Image");
            pb_profileImage.Location = new Point(879, 14);
            pb_profileImage.Name = "pb_profileImage";
            pb_profileImage.Size = new Size(97, 58);
            pb_profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_profileImage.TabIndex = 68;
            pb_profileImage.TabStop = false;
            pb_profileImage.Click += pb_profileImage_Click;
            // 
            // pnl_driver
            // 
            pnl_driver.BackColor = Color.FromArgb(205, 205, 205);
            pnl_driver.Location = new Point(824, 168);
            pnl_driver.Name = "pnl_driver";
            pnl_driver.Size = new Size(129, 3);
            pnl_driver.TabIndex = 70;
            pnl_driver.Visible = false;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(225, 225, 225);
            btn_profile.Cursor = Cursors.Hand;
            btn_profile.FlatAppearance.BorderSize = 0;
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Location = new Point(821, 74);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(135, 49);
            btn_profile.TabIndex = 67;
            btn_profile.Text = "Profile";
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Visible = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_favourite
            // 
            btn_favourite.BackColor = Color.FromArgb(225, 225, 225);
            btn_favourite.Cursor = Cursors.Hand;
            btn_favourite.FlatAppearance.BorderSize = 0;
            btn_favourite.FlatStyle = FlatStyle.Flat;
            btn_favourite.Location = new Point(821, 120);
            btn_favourite.Name = "btn_favourite";
            btn_favourite.Size = new Size(135, 49);
            btn_favourite.TabIndex = 66;
            btn_favourite.Text = "Favourites";
            btn_favourite.UseVisualStyleBackColor = false;
            btn_favourite.Visible = false;
            btn_favourite.Click += btn_favourite_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(225, 225, 225);
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Location = new Point(821, 171);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(135, 47);
            btn_logout.TabIndex = 69;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Visible = false;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.AllowUserToDeleteRows = false;
            dgv_products.AllowUserToResizeRows = false;
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_products.BackgroundColor = Color.White;
            dgv_products.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.GridColor = SystemColors.Control;
            dgv_products.Location = new Point(28, 96);
            dgv_products.MultiSelect = false;
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 30;
            dgv_products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_products.RowTemplate.DividerHeight = 1;
            dgv_products.RowTemplate.Height = 35;
            dgv_products.Size = new Size(643, 551);
            dgv_products.TabIndex = 40;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Location = new Point(687, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 548);
            panel7.TabIndex = 62;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 124, 127);
            header.Controls.Add(panel9);
            header.Controls.Add(lbl_shopify);
            header.Controls.Add(pB_logo);
            header.Controls.Add(pb_profileImage);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1004, 82);
            header.TabIndex = 39;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Location = new Point(28, 96);
            panel9.Name = "panel9";
            panel9.Size = new Size(648, 556);
            panel9.TabIndex = 74;
            // 
            // lbl_shopify
            // 
            lbl_shopify.AutoSize = true;
            lbl_shopify.BackColor = Color.Transparent;
            lbl_shopify.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl_shopify.ForeColor = Color.White;
            lbl_shopify.Location = new Point(91, 23);
            lbl_shopify.Name = "lbl_shopify";
            lbl_shopify.Size = new Size(122, 40);
            lbl_shopify.TabIndex = 40;
            lbl_shopify.Text = "Shopify";
            // 
            // pB_logo
            // 
            pB_logo.BackColor = Color.FromArgb(0, 123, 255);
            pB_logo.Image = (Image)resources.GetObject("pB_logo.Image");
            pB_logo.Location = new Point(28, 14);
            pB_logo.Name = "pB_logo";
            pB_logo.Size = new Size(72, 58);
            pB_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pB_logo.TabIndex = 39;
            pB_logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(711, 100);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 71;
            label1.Text = "Double click on an item to ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(711, 128);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 72;
            label2.Text = "add it to the favourites";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 124, 127);
            panel1.Controls.Add(btn_addToFavourite);
            panel1.Location = new Point(709, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 70);
            panel1.TabIndex = 73;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(28, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 556);
            panel2.TabIndex = 74;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(pnl_driver);
            Controls.Add(panel7);
            Controls.Add(btn_favourite);
            Controls.Add(btn_profile);
            Controls.Add(btn_logout);
            Controls.Add(dgv_products);
            Controls.Add(header);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            Name = "homeForm";
            Text = "Home";
            Load += homeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_products;
        private Button btn_addToFavourite;
        private Button btn_logout;
        //private DataGridView dgv_products;
        private Panel panel7;
        private FlowLayoutPanel pnl_driver;
        //private Button btn_logout;
        private Button btn_favourite;
        private PictureBox pb_profileImage;
        private Button btn_profile;
        private Panel header;
        private Label lbl_shopify;
        private PictureBox pB_logo;
        private Label label1;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Panel panel9;
        private Panel panel2;
    }
}