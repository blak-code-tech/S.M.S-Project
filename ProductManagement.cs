using System;
using System.Drawing;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class ProductManagement : Form
    {
        private bool accFromAdmin = false;

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.smsDataSet.categories);
            // TODO: This line of code loads data into the 'smsDataSet.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.smsDataSet.admins);
            // TODO: This line of code loads data into the 'smsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.smsDataSet.products);
            // TODO: This line of code loads data into the 'smsDataSet.attendants' table. You can move, or remove it, as needed.
            this.attendantsTableAdapter.Fill(this.smsDataSet.attendants);
            // TODO: This line of code loads data into the 'smsDataSet.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.smsDataSet.history);
            dashboard.ForeColor = Color.DarkGray;
            products.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
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

        private void products_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(4);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DarkGray;
            admins.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(0);
            dashboard.ForeColor = Color.DarkGray;
            products.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(5);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DarkGray;
        }

        private void changeCategory_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(2);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DarkGray;
            attendants.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DodgerBlue;
        }

        private void admins_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(3);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DarkGray;
        }

        private void newCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryPage acp = new AddCategoryPage();
            acp.ShowDialog();
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            AddProductPage app = new AddProductPage();
            app.ShowDialog();
        }

        private void categories_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(2);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DarkGray;
            attendants.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
        }

        private void newAdminBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(1);
            accFromAdmin = true;
        }

        private void newAttendantBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(1);
            accFromAdmin = false;
        }

        private void accountBackBtn_Click(object sender, EventArgs e)
        {
            if (accFromAdmin)
            {
                bunifuPages1.SelectTab(3);
            }
            else
            {
                bunifuPages1.SelectTab(5);
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(6);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
            admins.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DarkGray;
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(7);
        }

        private void editCategoryBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(8);
        }
    }
}
