namespace Shopify.presentation
{
    partial class FavouritesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_delete = new Button();
            btn_logOut = new Button();
            btn_profile = new Button();
            pnl_driver = new FlowLayoutPanel();
            dgv_favourites = new DataGridView();
            panel7 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_shopify = new Label();
            pB_logo = new PictureBox();
            pb_profileImage = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btn_home = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_favourites).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Control;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.FromArgb(180, 59, 59);
            btn_delete.Location = new Point(2, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(268, 66);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete From Favourite";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_logOut
            // 
            btn_logOut.BackColor = Color.FromArgb(225, 225, 225);
            btn_logOut.Cursor = Cursors.Hand;
            btn_logOut.FlatAppearance.BorderSize = 0;
            btn_logOut.FlatStyle = FlatStyle.Flat;
            btn_logOut.Location = new Point(821, 173);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(135, 47);
            btn_logOut.TabIndex = 64;
            btn_logOut.Text = "Log Out";
            btn_logOut.TextAlign = ContentAlignment.MiddleLeft;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Visible = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(225, 225, 225);
            btn_profile.Cursor = Cursors.Hand;
            btn_profile.FlatAppearance.BorderSize = 0;
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.Location = new Point(821, 122);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(135, 49);
            btn_profile.TabIndex = 1;
            btn_profile.Text = "Profile";
            btn_profile.TextAlign = ContentAlignment.MiddleLeft;
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Visible = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // pnl_driver
            // 
            pnl_driver.BackColor = Color.FromArgb(205, 205, 205);
            pnl_driver.Location = new Point(824, 170);
            pnl_driver.Name = "pnl_driver";
            pnl_driver.Size = new Size(129, 3);
            pnl_driver.TabIndex = 65;
            pnl_driver.Visible = false;
            // 
            // dgv_favourites
            // 
            dgv_favourites.AllowUserToAddRows = false;
            dgv_favourites.AllowUserToDeleteRows = false;
            dgv_favourites.AllowUserToResizeRows = false;
            dgv_favourites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_favourites.BackgroundColor = Color.White;
            dgv_favourites.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_favourites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_favourites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_favourites.GridColor = SystemColors.Control;
            dgv_favourites.Location = new Point(28, 96);
            dgv_favourites.MultiSelect = false;
            dgv_favourites.Name = "dgv_favourites";
            dgv_favourites.RowHeadersWidth = 30;
            dgv_favourites.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_favourites.RowTemplate.DividerHeight = 1;
            dgv_favourites.RowTemplate.Height = 35;
            dgv_favourites.Size = new Size(643, 551);
            dgv_favourites.TabIndex = 61;
            dgv_favourites.RowHeaderMouseDoubleClick += dgv_favourites_RowHeaderMouseDoubleClick_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Location = new Point(687, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 548);
            panel7.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(28, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 556);
            panel1.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 124, 127);
            panel2.Controls.Add(lbl_shopify);
            panel2.Controls.Add(pB_logo);
            panel2.Controls.Add(pb_profileImage);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 82);
            panel2.TabIndex = 74;
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
            lbl_shopify.Size = new Size(122, 40);
            lbl_shopify.TabIndex = 40;
            lbl_shopify.Text = "Shopify";
            lbl_shopify.Click += lbl_shopify_Click_1;
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
            pB_logo.Click += pB_logo_Click_1;
            // 
            // pb_profileImage
            // 
            pb_profileImage.Cursor = Cursors.Hand;
            pb_profileImage.Image = Properties.Resources.User_white;
            pb_profileImage.Location = new Point(900, 14);
            pb_profileImage.Name = "pb_profileImage";
            pb_profileImage.Size = new Size(69, 58);
            pb_profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_profileImage.TabIndex = 68;
            pb_profileImage.TabStop = false;
            pb_profileImage.Click += pb_profileImage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(711, 100);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 75;
            label2.Text = "Double click on an item to ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(711, 128);
            label3.Name = "label3";
            label3.Size = new Size(254, 28);
            label3.TabIndex = 76;
            label3.Text = "delete it from the favourites";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(219, 147, 147);
            panel3.Controls.Add(btn_delete);
            panel3.Location = new Point(709, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 70);
            panel3.TabIndex = 77;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(225, 225, 225);
            btn_home.Cursor = Cursors.Hand;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Location = new Point(821, 74);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(135, 49);
            btn_home.TabIndex = 78;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Visible = false;
            btn_home.Click += btn_home_Click;
            // 
            // FavouritesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 663);
            Controls.Add(btn_home);
            Controls.Add(pnl_driver);
            Controls.Add(btn_logOut);
            Controls.Add(panel7);
            Controls.Add(btn_profile);
            Controls.Add(dgv_favourites);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel3);
            Location = new Point(1, 1);
            Name = "FavouritesForm";
            Text = "Favourites";
            Load += Favourites_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_favourites).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_delete;
        private DataGridView dgv_favourites;
        private Panel panel7;
        private FlowLayoutPanel pnl_driver;
        private Button btn_profile;
        private Button btn_logOut;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_shopify;
        private PictureBox pB_logo;
        private PictureBox pb_profileImage;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Button btn_home;
        //private DataGridView dgv_favourites;
    }
}