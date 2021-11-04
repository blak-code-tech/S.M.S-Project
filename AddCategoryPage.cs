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
    public partial class AddCategoryPage : Form
    {
        private category categoryModel = new category();
        public AddCategoryPage()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
            {
                string msg = "Please make sure all the fields are filled.";
                MessageBox.Show(msg, "Error");
            }
            else
            {
                using (var db = new smsEntities())
                {
                    categoryModel.category1 = nameTxt.Text;
                    db.categories.Add(categoryModel);
                    db.SaveChanges();
                    string msg = "Category Created Successfully.";
                    MessageBox.Show(msg, "Success");
                    nameTxt.Text = "";
                }
            }
        }
    }
}
