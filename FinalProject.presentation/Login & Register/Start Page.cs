
namespace Shopify.presentation
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(350, 130);
            GlobalData.startForm = this;
        }

        //private void register_Click(object sender, EventArgs e)
        //{
        //    registerForm registerForm = new registerForm();
        //    registerForm.StartPosition = FormStartPosition.Manual;
        //    registerForm.Location = this.Location;
        //    registerForm.Show();
        //    this.Hide();
        //}

        private void login_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
            this.Hide();
        }

    }
}
