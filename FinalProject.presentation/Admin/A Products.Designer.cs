namespace Shopify.presentation
{
    partial class adminManageProduct
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
            btn_back = new Button();
            header = new Panel();
            cbtn_logout = new CustomControls.CustomButton();
            btn_userManagment = new Button();
            lbl_shopify = new Label();
            pB_logo = new PictureBox();
            btn_categories = new Button();
            btn_products = new Button();
            panel6 = new Panel();
            cb_category = new ComboBox();
            panel2 = new Panel();
            txt_price = new TextBox();
            panel1 = new Panel();
            txt_prodcutName = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_insert = new Button();
            lbl_price = new Label();
            lbl_productName = new Label();
            lbl_category = new Label();
            btn_addNewUser = new Button();
            dgv_products = new DataGridView();
            panel7 = new Panel();
            panel8 = new Panel();
            pnl_deleteproduct = new Panel();
            lbl_enterProductData = new Label();
            pnl_createnewproduct = new Panel();
            pnl_addnewproduct = new Panel();
            pnl_updateproduct = new Panel();
            tm1_update = new System.Windows.Forms.Timer(components);
            tm_addedSuccessfully = new System.Windows.Forms.Timer(components);
            tm_deletedSuccessfully = new System.Windows.Forms.Timer(components);
            btn_updatedSuccessfully = new Button();
            btn_addedSuccessfully = new Button();
            btn_deletedSuccessfully = new Button();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            pnl_deleteproduct.SuspendLayout();
            pnl_createnewproduct.SuspendLayout();
            pnl_addnewproduct.SuspendLayout();
            pnl_updateproduct.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(487, 435);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 13;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
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
            header.TabIndex = 38;
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
            cbtn_logout.TabIndex = 92;
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
            btn_categories.BackColor = Color.FromArgb(0, 124, 127);
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
            btn_categories.Click += btn_categories_Click;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.DarkCyan;
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
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(cb_category);
            panel6.Location = new Point(712, 320);
            panel6.Margin = new Padding(3, 3, 3, 15);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(268, 36);
            panel6.TabIndex = 55;
            // 
            // cb_category
            // 
            cb_category.FlatStyle = FlatStyle.Flat;
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(11, 6);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(250, 28);
            cb_category.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_price);
            panel2.Location = new Point(712, 244);
            panel2.Margin = new Padding(3, 3, 3, 15);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(268, 36);
            panel2.TabIndex = 51;
            // 
            // txt_price
            // 
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Location = new Point(12, 8);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(241, 20);
            txt_price.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_prodcutName);
            panel1.Location = new Point(713, 168);
            panel1.Margin = new Padding(3, 3, 3, 15);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(268, 36);
            panel1.TabIndex = 50;
            // 
            // txt_prodcutName
            // 
            txt_prodcutName.BorderStyle = BorderStyle.None;
            txt_prodcutName.Location = new Point(12, 8);
            txt_prodcutName.Name = "txt_prodcutName";
            txt_prodcutName.Size = new Size(241, 20);
            txt_prodcutName.TabIndex = 11;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Control;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_delete.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.FromArgb(180, 59, 59);
            btn_delete.Location = new Point(1, 1);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(268, 36);
            btn_delete.TabIndex = 48;
            btn_delete.Text = "Delete Product";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_update.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.FromArgb(0, 124, 127);
            btn_update.Location = new Point(1, 1);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(268, 36);
            btn_update.TabIndex = 47;
            btn_update.Text = "Update Product";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = SystemColors.Control;
            btn_insert.Cursor = Cursors.Hand;
            btn_insert.FlatAppearance.BorderSize = 0;
            btn_insert.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_insert.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.ForeColor = Color.FromArgb(0, 124, 127);
            btn_insert.Location = new Point(1, 1);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(268, 36);
            btn_insert.TabIndex = 46;
            btn_insert.Text = "Create New Product";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click_1;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(710, 223);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(41, 20);
            lbl_price.TabIndex = 40;
            lbl_price.Text = "Price";
            // 
            // lbl_productName
            // 
            lbl_productName.AutoSize = true;
            lbl_productName.Location = new Point(710, 147);
            lbl_productName.Margin = new Padding(3, 0, 3, 8);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(104, 20);
            lbl_productName.TabIndex = 39;
            lbl_productName.Text = "Product Name";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(710, 299);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(69, 20);
            lbl_category.TabIndex = 58;
            lbl_category.Text = "Category";
            // 
            // btn_addNewUser
            // 
            btn_addNewUser.BackColor = SystemColors.Control;
            btn_addNewUser.Cursor = Cursors.Hand;
            btn_addNewUser.FlatAppearance.BorderSize = 0;
            btn_addNewUser.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_addNewUser.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_addNewUser.FlatStyle = FlatStyle.Flat;
            btn_addNewUser.ForeColor = Color.FromArgb(0, 124, 127);
            btn_addNewUser.Location = new Point(1, 1);
            btn_addNewUser.Name = "btn_addNewUser";
            btn_addNewUser.Size = new Size(268, 36);
            btn_addNewUser.TabIndex = 59;
            btn_addNewUser.Text = "Add New Product";
            btn_addNewUser.UseVisualStyleBackColor = false;
            btn_addNewUser.Click += btn_addNewUser_Click;
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
            dgv_products.TabIndex = 60;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Location = new Point(687, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 548);
            panel7.TabIndex = 61;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Location = new Point(28, 96);
            panel8.Name = "panel8";
            panel8.Size = new Size(648, 556);
            panel8.TabIndex = 72;
            // 
            // pnl_deleteproduct
            // 
            pnl_deleteproduct.BackColor = Color.FromArgb(219, 147, 147);
            pnl_deleteproduct.Controls.Add(btn_delete);
            pnl_deleteproduct.Cursor = Cursors.Hand;
            pnl_deleteproduct.Location = new Point(709, 96);
            pnl_deleteproduct.Name = "pnl_deleteproduct";
            pnl_deleteproduct.Size = new Size(270, 38);
            pnl_deleteproduct.TabIndex = 79;
            // 
            // lbl_enterProductData
            // 
            lbl_enterProductData.AutoSize = true;
            lbl_enterProductData.BackColor = SystemColors.Control;
            lbl_enterProductData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_enterProductData.Location = new Point(709, 100);
            lbl_enterProductData.Name = "lbl_enterProductData";
            lbl_enterProductData.Size = new Size(217, 31);
            lbl_enterProductData.TabIndex = 80;
            lbl_enterProductData.Text = "Enter Product Data";
            // 
            // pnl_createnewproduct
            // 
            pnl_createnewproduct.BackColor = Color.FromArgb(0, 124, 127);
            pnl_createnewproduct.Controls.Add(btn_insert);
            pnl_createnewproduct.Cursor = Cursors.Hand;
            pnl_createnewproduct.Location = new Point(713, 387);
            pnl_createnewproduct.Name = "pnl_createnewproduct";
            pnl_createnewproduct.Size = new Size(270, 38);
            pnl_createnewproduct.TabIndex = 81;
            // 
            // pnl_addnewproduct
            // 
            pnl_addnewproduct.BackColor = Color.FromArgb(0, 124, 127);
            pnl_addnewproduct.Controls.Add(btn_addNewUser);
            pnl_addnewproduct.Cursor = Cursors.Hand;
            pnl_addnewproduct.Location = new Point(709, 96);
            pnl_addnewproduct.Name = "pnl_addnewproduct";
            pnl_addnewproduct.Size = new Size(270, 38);
            pnl_addnewproduct.TabIndex = 82;
            // 
            // pnl_updateproduct
            // 
            pnl_updateproduct.BackColor = Color.FromArgb(0, 124, 127);
            pnl_updateproduct.Controls.Add(btn_update);
            pnl_updateproduct.Cursor = Cursors.Hand;
            pnl_updateproduct.Location = new Point(713, 387);
            pnl_updateproduct.Name = "pnl_updateproduct";
            pnl_updateproduct.Size = new Size(270, 38);
            pnl_updateproduct.TabIndex = 83;
            // 
            // tm1_update
            // 
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
            btn_updatedSuccessfully.TabIndex = 98;
            btn_updatedSuccessfully.Text = "Product Updated Successfully";
            btn_updatedSuccessfully.UseVisualStyleBackColor = false;
            btn_updatedSuccessfully.Visible = false;
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
            btn_addedSuccessfully.TabIndex = 97;
            btn_addedSuccessfully.Text = "Product Added Successfully";
            btn_addedSuccessfully.UseVisualStyleBackColor = false;
            btn_addedSuccessfully.Visible = false;
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
            btn_deletedSuccessfully.TabIndex = 96;
            btn_deletedSuccessfully.Text = "Product Deleted Successfully";
            btn_deletedSuccessfully.UseVisualStyleBackColor = false;
            btn_deletedSuccessfully.Visible = false;
            // 
            // adminManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(panel7);
            Controls.Add(dgv_products);
            Controls.Add(lbl_category);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_price);
            Controls.Add(lbl_productName);
            Controls.Add(header);
            Controls.Add(btn_back);
            Controls.Add(panel8);
            Controls.Add(pnl_addnewproduct);
            Controls.Add(pnl_updateproduct);
            Controls.Add(pnl_createnewproduct);
            Controls.Add(lbl_enterProductData);
            Controls.Add(pnl_deleteproduct);
            Controls.Add(btn_updatedSuccessfully);
            Controls.Add(btn_addedSuccessfully);
            Controls.Add(btn_deletedSuccessfully);
            Location = new Point(1, 1);
            Name = "adminManageProduct";
            Text = "Products";
            Load += adminManageProduct_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            pnl_deleteproduct.ResumeLayout(false);
            pnl_createnewproduct.ResumeLayout(false);
            pnl_addnewproduct.ResumeLayout(false);
            pnl_updateproduct.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_prodcutName;
        private Label lbl_category;
        private ComboBox cb_category;
        private TextBox txt_price;
        private Button btn_back;
        private Panel header;
        private Button btn_userManagment;
        private Label lbl_shopify;
        private PictureBox pB_logo;
        private Button btn_categories;
        private Button btn_products;
        //private Label lbl_enterProductData;
        private Panel pnl_createnewproduct;
        private Panel pnl_updateproduct;
        private Button button2;
        private Panel pnl_addnewuser;
        private Panel panel6;
        private ComboBox cb_role;
        private Panel panel5;
        private TextBox txt_address;
        private Panel panel4;
        private NumericUpDown nud_age;
        private Panel pnl_addnewproduct;
        private TextBox txt_password;
        private Panel panel2;
        private TextBox txt_email;
        private Panel panel1;
        private TextBox txt_username;
        private Button d;
        private Button button3;
        private Label lbl_password;
        private Label lbl_address;
        private Label lbl_age;
        private Label lbl_price;
        private Label lbl_productName;
        private Button btn_addNewUser;
        private DataGridView dgv_products;
        private Panel panel7;
        private Panel panel8;
        private Panel pnl_deleteproduct;
        private Label lbl_enterProductData;
        private System.Windows.Forms.Timer tm1_update;
        private System.Windows.Forms.Timer tm_addedSuccessfully;
        private System.Windows.Forms.Timer tm_deletedSuccessfully;
        private CustomControls.CustomButton cbtn_logout;
        private Button btn_updatedSuccessfully;
        private Button btn_addedSuccessfully;
        private Button btn_deletedSuccessfully;
    }
}