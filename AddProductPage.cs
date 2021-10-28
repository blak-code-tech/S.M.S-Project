using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class AddProductPage : Form
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.smsDataSet.categories);

        }

        private void selectedCategoryBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void change_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
