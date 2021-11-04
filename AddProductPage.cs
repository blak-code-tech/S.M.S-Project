using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class AddProductPage : Form
    {
        private category model = new category();
        private product productModel = new product();
        private category categorySelected = new category();

        public category CategorySelected
        {
            get { return categorySelected; }
            set { categorySelected = value; }
        }

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
            int id;

            try
            {
                id = (int)categoryDGV.CurrentRow.Cells[0].Value;
                fetchCategory(id);
                bunifuPages1.SetPage(1);
                selectedCategoryBtn.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void fetchCategory(int id)
        {
            string query = "";

            query = "select * from dbo.categories where id = '" + id + "'";

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

            try
            {
                using (var conn = new SqlConnection(connInfo))
                {
                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    int i = ds.Tables[0].Rows.Count;
                    if (i == 1)
                    {
                        using (var db = new smsEntities())
                        {
                            model = db.categories.Where(x => x.id == id).FirstOrDefault();

                            CategorySelected.id = model.id;
                            CategorySelected.category1 = model.category1;
                            categoryTxt.Text = model.category1;
                        }
                    }
                    else
                    {
                        string msg = "Sorry, there id is not unique!!";
                        MessageBox.Show(msg, "Error");

                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(quantityTxt.Text) || string.IsNullOrEmpty(priceTxt.Text))
            {
                string msg = "Please make sure all the fields are filled.";
                MessageBox.Show(msg, "Error");
            }
            else
            {
                using (var db = new smsEntities())
                {
                    productModel.name = nameTxt.Text;
                    productModel.price = float.Parse(priceTxt.Text);
                    productModel.quantity = int.Parse(quantityTxt.Text);
                    productModel.category = CategorySelected.id;
                    db.products.Add(productModel);
                    db.SaveChanges();
                    string msg = "Product Added Successfully.";
                    MessageBox.Show(msg, "Success");
                    nameTxt.Text = "";
                    priceTxt.Text = "";
                    quantityTxt.Text = "";
                }

                bunifuPages1.SetPage(0);
            }

        }

        private void categoryDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategoryBtn.Enabled = true;
        }
    }
}
