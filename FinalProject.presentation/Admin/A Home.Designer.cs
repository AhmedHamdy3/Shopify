namespace Shopify.presentation
{
    partial class adminHomeForm
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
            btn_products = new Button();
            btn_users = new Button();
            btn_category = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.FromArgb(0, 124, 127);
            btn_products.Cursor = Cursors.Hand;
            btn_products.FlatAppearance.BorderSize = 0;
            btn_products.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 127);
            btn_products.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 124, 127);
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.ForeColor = Color.White;
            btn_products.Location = new Point(652, 152);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(268, 66);
            btn_products.TabIndex = 0;
            btn_products.Text = "Manage Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // btn_users
            // 
            btn_users.BackColor = Color.FromArgb(0, 124, 127);
            btn_users.Cursor = Cursors.Hand;
            btn_users.FlatAppearance.BorderSize = 0;
            btn_users.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 127);
            btn_users.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 124, 127);
            btn_users.FlatStyle = FlatStyle.Flat;
            btn_users.ForeColor = Color.White;
            btn_users.Location = new Point(652, 298);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(268, 66);
            btn_users.TabIndex = 1;
            btn_users.Text = "Manage Users";
            btn_users.UseVisualStyleBackColor = false;
            btn_users.Click += btn_users_Click;
            // 
            // btn_category
            // 
            btn_category.BackColor = Color.FromArgb(0, 124, 127);
            btn_category.Cursor = Cursors.Hand;
            btn_category.FlatAppearance.BorderSize = 0;
            btn_category.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 127);
            btn_category.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 124, 127);
            btn_category.FlatStyle = FlatStyle.Flat;
            btn_category.ForeColor = Color.White;
            btn_category.Location = new Point(652, 444);
            btn_category.Name = "btn_category";
            btn_category.Size = new Size(268, 66);
            btn_category.TabIndex = 2;
            btn_category.Text = "Manage Category";
            btn_category.UseVisualStyleBackColor = false;
            btn_category.Click += btn_category_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3918950;
            pictureBox2.Location = new Point(47, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 504);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // adminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 663);
            Controls.Add(pictureBox2);
            Controls.Add(btn_category);
            Controls.Add(btn_users);
            Controls.Add(btn_products);
            Location = new Point(1, 1);
            Name = "adminHomeForm";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_products;
        private Button btn_users;
        private Button btn_category;
        private PictureBox pictureBox2;
    }
}