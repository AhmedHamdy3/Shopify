namespace Shopify.presentation
{
    partial class adminManageCategories
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            header = new Panel();
            cbtn_logout = new CustomControls.CustomButton();
            btn_userManagment = new Button();
            lbl_shopify = new Label();
            pB_logo = new PictureBox();
            btn_categories = new Button();
            btn_products = new Button();
            panel7 = new Panel();
            btn_addNewCategory = new Button();
            lbl_enterCategoryData = new Label();
            panel1 = new Panel();
            txt_category = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_insert = new Button();
            lbl_categoryName = new Label();
            dgv_categories = new DataGridView();
            pnl_addnewcategory = new Panel();
            pnl_deletecategory = new Panel();
            pnl_updatecat = new Panel();
            pnl_createcategory = new Panel();
            tm1_update = new System.Windows.Forms.Timer(components);
            tm_addedSuccessfully = new System.Windows.Forms.Timer(components);
            tm_deletedSuccessfully = new System.Windows.Forms.Timer(components);
            btn_deletedSuccessfully = new Button();
            btn_addedSuccessfully = new Button();
            btn_updatedSuccessfully = new Button();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            pnl_addnewcategory.SuspendLayout();
            pnl_deletecategory.SuspendLayout();
            pnl_updatecat.SuspendLayout();
            pnl_createcategory.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 124, 127);
            header.Controls.Add(cbtn_logout);
            header.Controls.Add(btn_userManagment);
            header.Controls.Add(lbl_shopify);
            header.Controls.Add(pB_logo);
            header.Controls.Add(btn_categories);
            header.Controls.Add(btn_products);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1004, 82);
            header.TabIndex = 39;
            // 
            // cbtn_logout
            // 
            cbtn_logout.BackColor = Color.FromArgb(0, 124, 127);
            cbtn_logout.BorderColor = Color.Black;
            cbtn_logout.BorderRadius = 0;
            cbtn_logout.BorderSize = 0;
            cbtn_logout.Cursor = Cursors.Hand;
            cbtn_logout.FlatAppearance.BorderSize = 0;
            cbtn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 127);
            cbtn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 124, 127);
            cbtn_logout.FlatStyle = FlatStyle.Flat;
            cbtn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_logout.ForeColor = Color.White;
            cbtn_logout.Image = Properties.Resources.Logout1;
            cbtn_logout.ImageAlign = ContentAlignment.TopCenter;
            cbtn_logout.Location = new Point(877, 6);
            cbtn_logout.Name = "cbtn_logout";
            cbtn_logout.Size = new Size(88, 71);
            cbtn_logout.TabIndex = 90;
            cbtn_logout.Text = "Logout";
            cbtn_logout.TextAlign = ContentAlignment.BottomCenter;
            cbtn_logout.UseVisualStyleBackColor = false;
            cbtn_logout.Click += cbtn_logout_Click;
            // 
            // btn_userManagment
            // 
            btn_userManagment.BackColor = Color.FromArgb(0, 124, 127);
            btn_userManagment.Cursor = Cursors.Hand;
            btn_userManagment.FlatAppearance.BorderSize = 0;
            btn_userManagment.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btn_userManagment.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_userManagment.FlatStyle = FlatStyle.Flat;
            btn_userManagment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_userManagment.ForeColor = Color.White;
            btn_userManagment.Location = new Point(629, 0);
            btn_userManagment.Name = "btn_userManagment";
            btn_userManagment.Size = new Size(118, 82);
            btn_userManagment.TabIndex = 41;
            btn_userManagment.Text = "Users";
            btn_userManagment.UseVisualStyleBackColor = false;
            btn_userManagment.Click += btn_userManagment_Click;
            // 
            // lbl_shopify
            // 
            lbl_shopify.AutoSize = true;
            lbl_shopify.BackColor = Color.Transparent;
            lbl_shopify.Cursor = Cursors.Hand;
            lbl_shopify.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl_shopify.ForeColor = Color.White;
            lbl_shopify.Location = new Point(95, 23);
            lbl_shopify.Name = "lbl_shopify";
            lbl_shopify.Size = new Size(178, 40);
            lbl_shopify.TabIndex = 40;
            lbl_shopify.Text = "Shopify Pro";
            lbl_shopify.Click += lbl_shopify_Click;
            // 
            // pB_logo
            // 
            pB_logo.BackColor = Color.Transparent;
            pB_logo.Cursor = Cursors.Hand;
            pB_logo.Image = Properties.Resources.Shopping_Cart_white;
            pB_logo.Location = new Point(28, 14);
            pB_logo.Name = "pB_logo";
            pB_logo.Size = new Size(72, 58);
            pB_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pB_logo.TabIndex = 39;
            pB_logo.TabStop = false;
            pB_logo.Click += pB_logo_Click;
            // 
            // btn_categories
            // 
            btn_categories.BackColor = Color.DarkCyan;
            btn_categories.Cursor = Cursors.Hand;
            btn_categories.FlatAppearance.BorderSize = 0;
            btn_categories.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btn_categories.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_categories.FlatStyle = FlatStyle.Flat;
            btn_categories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_categories.ForeColor = Color.White;
            btn_categories.Location = new Point(753, 0);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(118, 82);
            btn_categories.TabIndex = 37;
            btn_categories.Text = "Categories";
            btn_categories.UseVisualStyleBackColor = false;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.FromArgb(0, 124, 127);
            btn_products.Cursor = Cursors.Hand;
            btn_products.FlatAppearance.BorderSize = 0;
            btn_products.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btn_products.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_products.ForeColor = Color.White;
            btn_products.Location = new Point(506, 0);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(118, 82);
            btn_products.TabIndex = 36;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Location = new Point(687, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 548);
            panel7.TabIndex = 62;
            // 
            // btn_addNewCategory
            // 
            btn_addNewCategory.BackColor = SystemColors.Control;
            btn_addNewCategory.FlatAppearance.BorderSize = 0;
            btn_addNewCategory.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_addNewCategory.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_addNewCategory.FlatStyle = FlatStyle.Flat;
            btn_addNewCategory.ForeColor = Color.FromArgb(0, 124, 127);
            btn_addNewCategory.Location = new Point(1, 1);
            btn_addNewCategory.Name = "btn_addNewCategory";
            btn_addNewCategory.Size = new Size(268, 36);
            btn_addNewCategory.TabIndex = 69;
            btn_addNewCategory.Text = "Add New Category";
            btn_addNewCategory.UseVisualStyleBackColor = false;
            btn_addNewCategory.Click += btn_addNewCategory_Click;
            // 
            // lbl_enterCategoryData
            // 
            lbl_enterCategoryData.AutoSize = true;
            lbl_enterCategoryData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_enterCategoryData.Location = new Point(711, 99);
            lbl_enterCategoryData.Name = "lbl_enterCategoryData";
            lbl_enterCategoryData.Size = new Size(229, 31);
            lbl_enterCategoryData.TabIndex = 64;
            lbl_enterCategoryData.Text = "Enter Category Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_category);
            panel1.Location = new Point(713, 169);
            panel1.Margin = new Padding(3, 3, 3, 15);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(268, 36);
            panel1.TabIndex = 68;
            // 
            // txt_category
            // 
            txt_category.BorderStyle = BorderStyle.None;
            txt_category.Location = new Point(12, 8);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(241, 20);
            txt_category.TabIndex = 11;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Control;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_delete.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.FromArgb(180, 59, 59);
            btn_delete.Location = new Point(1, 1);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(268, 36);
            btn_delete.TabIndex = 67;
            btn_delete.Text = "Delete Category";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_update.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.FromArgb(0, 124, 127);
            btn_update.Location = new Point(1, 1);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(268, 36);
            btn_update.TabIndex = 66;
            btn_update.Text = "Update Category";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = SystemColors.Control;
            btn_insert.FlatAppearance.BorderSize = 0;
            btn_insert.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_insert.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.ForeColor = Color.FromArgb(0, 124, 127);
            btn_insert.Location = new Point(1, 1);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(268, 36);
            btn_insert.TabIndex = 65;
            btn_insert.Text = "Create New Category";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click_1;
            // 
            // lbl_categoryName
            // 
            lbl_categoryName.AutoSize = true;
            lbl_categoryName.Location = new Point(710, 147);
            lbl_categoryName.Margin = new Padding(3, 0, 3, 8);
            lbl_categoryName.Name = "lbl_categoryName";
            lbl_categoryName.Size = new Size(113, 20);
            lbl_categoryName.TabIndex = 63;
            lbl_categoryName.Text = "Category Name";
            // 
            // dgv_categories
            // 
            dgv_categories.AllowUserToAddRows = false;
            dgv_categories.AllowUserToDeleteRows = false;
            dgv_categories.AllowUserToResizeRows = false;
            dgv_categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categories.BackgroundColor = Color.White;
            dgv_categories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.GridColor = SystemColors.Control;
            dgv_categories.Location = new Point(28, 96);
            dgv_categories.MultiSelect = false;
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 30;
            dgv_categories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_categories.RowTemplate.DividerHeight = 1;
            dgv_categories.RowTemplate.Height = 35;
            dgv_categories.Size = new Size(643, 553);
            dgv_categories.TabIndex = 70;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick_1;
            // 
            // pnl_addnewcategory
            // 
            pnl_addnewcategory.BackColor = Color.FromArgb(0, 124, 127);
            pnl_addnewcategory.Controls.Add(btn_addNewCategory);
            pnl_addnewcategory.Cursor = Cursors.Hand;
            pnl_addnewcategory.Location = new Point(709, 96);
            pnl_addnewcategory.Name = "pnl_addnewcategory";
            pnl_addnewcategory.Size = new Size(270, 38);
            pnl_addnewcategory.TabIndex = 84;
            // 
            // pnl_deletecategory
            // 
            pnl_deletecategory.BackColor = Color.FromArgb(219, 147, 147);
            pnl_deletecategory.Controls.Add(btn_delete);
            pnl_deletecategory.Cursor = Cursors.Hand;
            pnl_deletecategory.Location = new Point(709, 96);
            pnl_deletecategory.Name = "pnl_deletecategory";
            pnl_deletecategory.Size = new Size(270, 38);
            pnl_deletecategory.TabIndex = 80;
            // 
            // pnl_updatecat
            // 
            pnl_updatecat.BackColor = Color.FromArgb(0, 124, 127);
            pnl_updatecat.Controls.Add(btn_update);
            pnl_updatecat.Cursor = Cursors.Hand;
            pnl_updatecat.Location = new Point(710, 224);
            pnl_updatecat.Name = "pnl_updatecat";
            pnl_updatecat.Size = new Size(270, 38);
            pnl_updatecat.TabIndex = 85;
            // 
            // pnl_createcategory
            // 
            pnl_createcategory.BackColor = Color.FromArgb(0, 124, 127);
            pnl_createcategory.Controls.Add(btn_insert);
            pnl_createcategory.Cursor = Cursors.Hand;
            pnl_createcategory.Location = new Point(710, 224);
            pnl_createcategory.Name = "pnl_createcategory";
            pnl_createcategory.Size = new Size(270, 38);
            pnl_createcategory.TabIndex = 85;
            // 
            // tm1_update
            // 
            tm1_update.Interval = 1000;
            tm1_update.Tick += tm1_update_Tick;
            // 
            // tm_addedSuccessfully
            // 
            tm_addedSuccessfully.Tick += tm_addedSuccessfully_Tick;
            // 
            // tm_deletedSuccessfully
            // 
            tm_deletedSuccessfully.Tick += tm_deletedSuccessfully_Tick;
            // 
            // btn_deletedSuccessfully
            // 
            btn_deletedSuccessfully.BackColor = Color.FromArgb(248, 215, 218);
            btn_deletedSuccessfully.FlatAppearance.BorderColor = Color.FromArgb(245, 198, 203);
            btn_deletedSuccessfully.FlatAppearance.MouseDownBackColor = Color.FromArgb(248, 215, 218);
            btn_deletedSuccessfully.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 215, 218);
            btn_deletedSuccessfully.FlatStyle = FlatStyle.Flat;
            btn_deletedSuccessfully.ForeColor = Color.FromArgb(114, 28, 36);
            btn_deletedSuccessfully.Location = new Point(712, 152);
            btn_deletedSuccessfully.Name = "btn_deletedSuccessfully";
            btn_deletedSuccessfully.Size = new Size(270, 53);
            btn_deletedSuccessfully.TabIndex = 93;
            btn_deletedSuccessfully.Text = "Category Deleted Successfully";
            btn_deletedSuccessfully.UseVisualStyleBackColor = false;
            btn_deletedSuccessfully.Visible = false;
            // 
            // btn_addedSuccessfully
            // 
            btn_addedSuccessfully.BackColor = Color.FromArgb(212, 237, 218);
            btn_addedSuccessfully.FlatAppearance.BorderColor = Color.FromArgb(195, 230, 203);
            btn_addedSuccessfully.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 237, 218);
            btn_addedSuccessfully.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 237, 218);
            btn_addedSuccessfully.FlatStyle = FlatStyle.Flat;
            btn_addedSuccessfully.ForeColor = Color.FromArgb(21, 87, 36);
            btn_addedSuccessfully.Location = new Point(712, 152);
            btn_addedSuccessfully.Name = "btn_addedSuccessfully";
            btn_addedSuccessfully.Size = new Size(270, 53);
            btn_addedSuccessfully.TabIndex = 94;
            btn_addedSuccessfully.Text = "Category Added Successfully";
            btn_addedSuccessfully.UseVisualStyleBackColor = false;
            btn_addedSuccessfully.Visible = false;
            // 
            // btn_updatedSuccessfully
            // 
            btn_updatedSuccessfully.BackColor = Color.FromArgb(212, 237, 218);
            btn_updatedSuccessfully.FlatAppearance.BorderColor = Color.FromArgb(195, 230, 203);
            btn_updatedSuccessfully.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 237, 218);
            btn_updatedSuccessfully.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 237, 218);
            btn_updatedSuccessfully.FlatStyle = FlatStyle.Flat;
            btn_updatedSuccessfully.ForeColor = Color.FromArgb(21, 87, 36);
            btn_updatedSuccessfully.Location = new Point(712, 152);
            btn_updatedSuccessfully.Name = "btn_updatedSuccessfully";
            btn_updatedSuccessfully.Size = new Size(270, 53);
            btn_updatedSuccessfully.TabIndex = 95;
            btn_updatedSuccessfully.Text = "Category Updated Successfully";
            btn_updatedSuccessfully.UseVisualStyleBackColor = false;
            btn_updatedSuccessfully.Visible = false;
            // 
            // adminManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(pnl_updatecat);
            Controls.Add(panel1);
            Controls.Add(lbl_categoryName);
            Controls.Add(panel7);
            Controls.Add(header);
            Controls.Add(pnl_addnewcategory);
            Controls.Add(pnl_createcategory);
            Controls.Add(dgv_categories);
            Controls.Add(lbl_enterCategoryData);
            Controls.Add(pnl_deletecategory);
            Controls.Add(btn_updatedSuccessfully);
            Controls.Add(btn_addedSuccessfully);
            Controls.Add(btn_deletedSuccessfully);
            Location = new Point(1, 1);
            Name = "adminManageCategories";
            Text = "Categories";
            Load += adminManageCategories_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            pnl_addnewcategory.ResumeLayout(false);
            pnl_deletecategory.ResumeLayout(false);
            pnl_updatecat.ResumeLayout(false);
            pnl_createcategory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private DataGridView dgv_categories;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private Label lbl_categoryName;
        private TextBox txt_category;
        private Panel header;
        private Button btn_userManagment;
        private Label lbl_shopify;
        private PictureBox pB_logo;
        private Button btn_categories;
        private Button btn_products;
        private Panel panel7;
        private Button btn_addNewCategory;
        private Label lbl_enterCategoryData;
        private Panel panel1;
        private Panel pnl_addnewcategory;
        private Panel pnl_deletecategory;
        private Panel pnl_updatecat;
        private Panel pnl_createcategory;
        private System.Windows.Forms.Timer tm1_update;
        private System.Windows.Forms.Timer tm_addedSuccessfully;
        private System.Windows.Forms.Timer tm_deletedSuccessfully;
        private CustomControls.CustomButton cbtn_logout;
        private Button btn_deletedSuccessfully;
        private Button btn_addedSuccessfully;
        private Button btn_updatedSuccessfully;
    }
}