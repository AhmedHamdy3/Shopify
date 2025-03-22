namespace Shopify.presentation
{
    partial class startForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(0, 124, 127);
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 127);
            login.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 124, 127);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(101, 428);
            login.Name = "login";
            login.Size = new Size(268, 66);
            login.TabIndex = 0;
            login.Text = "Get Started";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources._3516854;
            pictureBox2.Location = new Point(451, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 504);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.8000011F);
            label1.Location = new Point(67, 207);
            label1.Name = "label1";
            label1.Size = new Size(136, 60);
            label1.TabIndex = 6;
            label1.Text = "YOUR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(79, 255);
            label2.Name = "label2";
            label2.Size = new Size(311, 60);
            label2.TabIndex = 7;
            label2.Text = "E-COMMERCE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 25.8000011F);
            label3.Location = new Point(113, 315);
            label3.Name = "label3";
            label3.Size = new Size(240, 60);
            label3.TabIndex = 8;
            label3.Text = "PLATFORM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            label4.Location = new Point(187, 207);
            label4.Name = "label4";
            label4.Size = new Size(218, 60);
            label4.TabIndex = 9;
            label4.Text = "TRUSTED";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Shopping_Cart;
            pictureBox1.Location = new Point(48, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 124, 127);
            label5.Location = new Point(113, 34);
            label5.Name = "label5";
            label5.Size = new Size(143, 46);
            label5.TabIndex = 11;
            label5.Text = "Shopify";
            // 
            // startForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 663);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(login);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Location = new Point(600, 350);
            Name = "startForm";
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
