using System;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            AdminLoginPage admin = new AdminLoginPage();
            admin.Show();
            this.Hide();
        }

        private void CloseTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
