namespace Shopify.presentation
{
    partial class adminManageUsers
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
            lbl_email = new Label();
            nud_age = new NumericUpDown();
            lbl_address = new Label();
            lbl_age = new Label();
            lbl_password = new Label();
            lbl_role = new Label();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            header = new Panel();
            cbtn_logout = new CustomControls.CustomButton();
            panel7 = new Panel();
            btn_userManagment = new Button();
            lbl_shopify = new Label();
            pB_logo = new PictureBox();
            btn_categories = new Button();
            btn_products = new Button();
            btn_addNewUser = new Button();
            pnl_password = new Panel();
            txt_password = new TextBox();
            btn_updatedSuccessfully = new Button();
            btn_addedSuccessfully = new Button();
            btn_deletedSuccessfully = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            txt_address = new TextBox();
            cb_role = new ComboBox();
            pnl_role = new Panel();
            lbl_enterUserData = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            pnl_deleteuser = new Panel();
            pnl_updateuser = new Panel();
            pnl_createnewuser = new Panel();
            pnl_addnewuser = new Panel();
            pnl_email = new Panel();
            txt_email = new TextBox();
            lbl_username = new Label();
            txt_username = new TextBox();
            panel1 = new Panel();
            dgv_users = new DataGridView();
            tm1_update = new System.Windows.Forms.Timer(components);
            tm_addedSuccessfully = new System.Windows.Forms.Timer(components);
            tm_deletedSuccessfully = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).BeginInit();
            pnl_password.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnl_role.SuspendLayout();
            pnl_deleteuser.SuspendLayout();
            pnl_updateuser.SuspendLayout();
            pnl_createnewuser.SuspendLayout();
            pnl_addnewuser.SuspendLayout();
            pnl_email.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(710, 223);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 10;
            lbl_email.Text = "Email";
            // 
            // nud_age
            // 
            nud_age.BorderStyle = BorderStyle.None;
            nud_age.Location = new Point(12, 8);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(250, 23);
            nud_age.TabIndex = 15;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(710, 527);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(62, 20);
            lbl_address.TabIndex = 16;
            lbl_address.Text = "Address";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(710, 451);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(36, 20);
            lbl_age.TabIndex = 15;
            lbl_age.Text = "Age";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(710, 299);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 20);
            lbl_password.TabIndex = 19;
            lbl_password.Text = "Password";
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Location = new Point(710, 375);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(39, 20);
            lbl_role.TabIndex = 21;
            lbl_role.Text = "Role";
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
            btn_insert.TabIndex = 23;
            btn_insert.Text = "Create New User";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
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
            btn_update.TabIndex = 24;
            btn_update.Text = "Update User";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
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
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete User";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 124, 127);
            header.Controls.Add(cbtn_logout);
            header.Controls.Add(panel7);
            header.Controls.Add(btn_userManagment);
            header.Controls.Add(lbl_shopify);
            header.Controls.Add(pB_logo);
            header.Controls.Add(btn_categories);
            header.Controls.Add(btn_products);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1004, 82);
            header.TabIndex = 27;
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
            cbtn_logout.TabIndex = 93;
            cbtn_logout.Text = "Logout";
            cbtn_logout.TextAlign = ContentAlignment.BottomCenter;
            cbtn_logout.UseVisualStyleBackColor = false;
            cbtn_logout.Click += cbtn_logout_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(215, 215, 215);
            panel7.Location = new Point(688, 96);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 548);
            panel7.TabIndex = 62;
            // 
            // btn_userManagment
            // 
            btn_userManagment.BackColor = Color.DarkCyan;
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
            // btn_addNewUser
            // 
            btn_addNewUser.BackColor = SystemColors.Control;
            btn_addNewUser.FlatAppearance.BorderSize = 0;
            btn_addNewUser.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_addNewUser.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_addNewUser.FlatStyle = FlatStyle.Flat;
            btn_addNewUser.Location = new Point(1, 1);
            btn_addNewUser.Name = "btn_addNewUser";
            btn_addNewUser.Size = new Size(268, 36);
            btn_addNewUser.TabIndex = 32;
            btn_addNewUser.Text = "Add An User";
            btn_addNewUser.UseVisualStyleBackColor = false;
            btn_addNewUser.Click += btn_addNewUser_Click;
            // 
            // pnl_password
            // 
            pnl_password.BackColor = Color.White;
            pnl_password.Controls.Add(txt_password);
            pnl_password.Location = new Point(712, 320);
            pnl_password.Margin = new Padding(3, 3, 3, 15);
            pnl_password.Name = "pnl_password";
            pnl_password.Padding = new Padding(10);
            pnl_password.Size = new Size(268, 36);
            pnl_password.TabIndex = 30;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(12, 8);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(241, 20);
            txt_password.TabIndex = 13;
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
            btn_updatedSuccessfully.Text = "User Updated Successfully";
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
            btn_addedSuccessfully.Text = "User Added Successfully";
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
            btn_deletedSuccessfully.Text = "User Deleted Successfully";
            btn_deletedSuccessfully.UseVisualStyleBackColor = false;
            btn_deletedSuccessfully.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(nud_age);
            panel4.Location = new Point(712, 472);
            panel4.Margin = new Padding(3, 3, 3, 15);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(268, 36);
            panel4.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txt_address);
            panel5.Location = new Point(714, 548);
            panel5.Margin = new Padding(3, 3, 3, 15);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(268, 36);
            panel5.TabIndex = 31;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.None;
            txt_address.Location = new Point(12, 8);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(241, 20);
            txt_address.TabIndex = 16;
            // 
            // cb_role
            // 
            cb_role.FlatStyle = FlatStyle.Flat;
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(11, 6);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(250, 28);
            cb_role.TabIndex = 14;
            // 
            // pnl_role
            // 
            pnl_role.BackColor = Color.White;
            pnl_role.Controls.Add(cb_role);
            pnl_role.Location = new Point(712, 396);
            pnl_role.Margin = new Padding(3, 3, 3, 15);
            pnl_role.Name = "pnl_role";
            pnl_role.Padding = new Padding(10);
            pnl_role.Size = new Size(268, 36);
            pnl_role.TabIndex = 31;
            // 
            // lbl_enterUserData
            // 
            lbl_enterUserData.AutoSize = true;
            lbl_enterUserData.BackColor = SystemColors.Control;
            lbl_enterUserData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_enterUserData.Location = new Point(709, 103);
            lbl_enterUserData.Name = "lbl_enterUserData";
            lbl_enterUserData.Size = new Size(180, 31);
            lbl_enterUserData.TabIndex = 12;
            lbl_enterUserData.Text = "Enter User Data";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 230, 230);
            panel8.Location = new Point(687, 99);
            panel8.Name = "panel8";
            panel8.Size = new Size(3, 548);
            panel8.TabIndex = 62;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Location = new Point(28, 96);
            panel9.Name = "panel9";
            panel9.Size = new Size(648, 556);
            panel9.TabIndex = 73;
            // 
            // pnl_deleteuser
            // 
            pnl_deleteuser.BackColor = Color.FromArgb(219, 147, 147);
            pnl_deleteuser.Controls.Add(btn_delete);
            pnl_deleteuser.Cursor = Cursors.Hand;
            pnl_deleteuser.Location = new Point(709, 96);
            pnl_deleteuser.Name = "pnl_deleteuser";
            pnl_deleteuser.Size = new Size(270, 38);
            pnl_deleteuser.TabIndex = 78;
            // 
            // pnl_updateuser
            // 
            pnl_updateuser.BackColor = Color.FromArgb(0, 124, 127);
            pnl_updateuser.Controls.Add(btn_update);
            pnl_updateuser.Cursor = Cursors.Hand;
            pnl_updateuser.Location = new Point(712, 607);
            pnl_updateuser.Name = "pnl_updateuser";
            pnl_updateuser.Size = new Size(270, 38);
            pnl_updateuser.TabIndex = 79;
            // 
            // pnl_createnewuser
            // 
            pnl_createnewuser.BackColor = Color.FromArgb(0, 124, 127);
            pnl_createnewuser.Controls.Add(btn_insert);
            pnl_createnewuser.Cursor = Cursors.Hand;
            pnl_createnewuser.Location = new Point(712, 607);
            pnl_createnewuser.Name = "pnl_createnewuser";
            pnl_createnewuser.Size = new Size(270, 38);
            pnl_createnewuser.TabIndex = 80;
            // 
            // pnl_addnewuser
            // 
            pnl_addnewuser.BackColor = Color.FromArgb(0, 124, 127);
            pnl_addnewuser.Controls.Add(btn_addNewUser);
            pnl_addnewuser.Cursor = Cursors.Hand;
            pnl_addnewuser.ForeColor = Color.FromArgb(0, 124, 127);
            pnl_addnewuser.Location = new Point(709, 96);
            pnl_addnewuser.Name = "pnl_addnewuser";
            pnl_addnewuser.Size = new Size(270, 38);
            pnl_addnewuser.TabIndex = 81;
            // 
            // pnl_email
            // 
            pnl_email.BackColor = Color.White;
            pnl_email.Controls.Add(txt_email);
            pnl_email.Location = new Point(712, 244);
            pnl_email.Margin = new Padding(3, 3, 3, 15);
            pnl_email.Name = "pnl_email";
            pnl_email.Padding = new Padding(10);
            pnl_email.Size = new Size(268, 36);
            pnl_email.TabIndex = 29;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Location = new Point(12, 8);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(241, 20);
            txt_email.TabIndex = 12;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(710, 147);
            lbl_username.Margin = new Padding(3, 0, 3, 8);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(67, 20);
            lbl_username.TabIndex = 9;
            lbl_username.Text = "Userame";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Location = new Point(12, 8);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(241, 20);
            txt_username.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(713, 168);
            panel1.Margin = new Padding(3, 3, 3, 15);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(268, 36);
            panel1.TabIndex = 28;
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AllowUserToDeleteRows = false;
            dgv_users.AllowUserToResizeRows = false;
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_users.BackgroundColor = Color.White;
            dgv_users.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.GridColor = SystemColors.Control;
            dgv_users.Location = new Point(28, 96);
            dgv_users.MultiSelect = false;
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 30;
            dgv_users.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_users.RowTemplate.DividerHeight = 1;
            dgv_users.RowTemplate.Height = 35;
            dgv_users.Size = new Size(643, 551);
            dgv_users.TabIndex = 0;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
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
            // adminManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pnl_role);
            Controls.Add(pnl_password);
            Controls.Add(pnl_email);
            Controls.Add(panel8);
            Controls.Add(header);
            Controls.Add(lbl_role);
            Controls.Add(lbl_password);
            Controls.Add(lbl_address);
            Controls.Add(lbl_age);
            Controls.Add(lbl_email);
            Controls.Add(dgv_users);
            Controls.Add(panel9);
            Controls.Add(pnl_createnewuser);
            Controls.Add(pnl_updateuser);
            Controls.Add(lbl_enterUserData);
            Controls.Add(pnl_addnewuser);
            Controls.Add(pnl_deleteuser);
            Controls.Add(lbl_username);
            Controls.Add(panel1);
            Controls.Add(btn_updatedSuccessfully);
            Controls.Add(btn_addedSuccessfully);
            Controls.Add(btn_deletedSuccessfully);
            Location = new Point(1, 1);
            Name = "adminManageUsers";
            Text = "Users";
            Load += adminManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).EndInit();
            pnl_password.ResumeLayout(false);
            pnl_password.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnl_role.ResumeLayout(false);
            pnl_deleteuser.ResumeLayout(false);
            pnl_updateuser.ResumeLayout(false);
            pnl_createnewuser.ResumeLayout(false);
            pnl_addnewuser.ResumeLayout(false);
            pnl_email.ResumeLayout(false);
            pnl_email.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_email;
        private NumericUpDown nud_age;
        private Label lbl_address;
        private Label lbl_age;
        private Label lbl_password;
        private Label lbl_role;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private Panel header;
        private Panel pnl_password;
        private TextBox txt_password;
        private Panel panel4;
        private Panel panel5;
        private TextBox txt_address;
        private Button btn_products;
        private ComboBox cb_role;
        private Panel pnl_role;
        private Button btn_categories;
        private PictureBox pB_logo;
        private Label lbl_shopify;
        private Label lbl_enterUserData;
        private Button btn_addNewUser;
        private Button btn_userManagment;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel pnl_deleteuser;
        private Panel pnl_updateuser;
        private Panel pnl_createnewuser;
        private Panel pnl_addnewuser;
        private Panel pnl_email;
        private TextBox txt_email;
        private Label lbl_username;
        private TextBox txt_username;
        private Panel panel1;
        private DataGridView dgv_users;
        private System.Windows.Forms.Timer tm1_update;
        private System.Windows.Forms.Timer tm_addedSuccessfully;
        private System.Windows.Forms.Timer tm_deletedSuccessfully;
        private CustomControls.CustomButton cbtn_logout;
        private Button btn_updatedSuccessfully;
        private Button btn_addedSuccessfully;
        private Button btn_deletedSuccessfully;
    }
}