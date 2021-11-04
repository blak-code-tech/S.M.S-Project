using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class SalesManagement : Form
    {
        private product model = new product();
        double total_cost = 0.0;
        double unit_cost = 0.0;
        private product productSelected = new product();
        private string orderID = "";

        private history historyModel = new history();

        public product ProductSelected
        {
            get { return productSelected; }
            set { productSelected = value; }
        }

        private List<history> cart;
        private List<CartObject> tempCart;

        public SalesManagement()
        {
            InitializeComponent();

            cart = new List<history>();
            tempCart = new List<CartObject>();
        }

        private void CloseTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.smsDataSet.products);
            searchRecords(productsSearchBox.Text);

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            CreatingGrid();
            AttendantView.SetPage(1);
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            AttendantView.SetPage(0);
        }

        private void productsSearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(productsSearchBox.Text);
        }

        public void searchRecords(string keyword)
        {

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {
                try
                {
                    ///Our query to be run
                    string query = "";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = @"select dbo.products.id,dbo.products.name
                                          ,dbo.products.price,dbo.products.quantity,
                                            dbo.categories.category from products inner join
                                            categories on dbo.categories.id = dbo.products.category
                                            where name like '" + keyword + "%' " +
                                        "or dbo.categories.category like '" + keyword + "';";
                    }
                    else
                    {
                        query = @"select dbo.products.id,dbo.products.name
                                          ,dbo.products.price,dbo.products.quantity,
                                            dbo.categories.category from products inner join
                                            categories on dbo.categories.id = dbo.products.category;";
                    }


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    productsDGV.ReadOnly = true;

                    productsDGV.AutoGenerateColumns = false;
                    /// Assigning a data source
                    productsDGV.DataSource = ds.Tables[0];

                    numRowsCheck();
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }

            }
        }

        private void numRowsCheck()
        {
            if (productsDGV.RowCount >= 1)
            {
                txtProductAvailable.Visible = false;
            }
            else
            {
                txtProductAvailable.Visible = true;
            }
        }

        private void productsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelectProduct.Enabled = true;
        }

        private void fetchProduct(int id)
        {
            string query = "";

            query = "select * from dbo.products where id = '" + id + "'";

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
                            model = db.products.Where(x => x.id == id).FirstOrDefault();

                            ProductSelected.id = model.id;
                            ProductSelected.category1 = model.category1;
                            ProductSelected.name = model.name;
                            ProductSelected.price = model.price;
                            productSelected.quantity = model.quantity;
                            txtProdName.Text = model.name;
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

        private void logout_Click(object sender, EventArgs e)
        {
            ChooseUserPage cup = new ChooseUserPage();
            cup.Show();
            this.Close();
        }

        private void txtProdQuantity_TextChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtProdQuantity.Text, "^[0-9]*$"))
            {
                try
                {
                    var quantity = int.Parse(txtProdQuantity.Text);
                    if (quantity > ProductSelected.quantity)
                    {
                        var available = quantity - ProductSelected.quantity;
                        var msg = @"The requested quantity is " + available + " more than what is available";
                        btnAddToCart.Enabled = false;
                        MessageBox.Show(msg, "Invalid Input");
                    }
                    else
                    {
                        unit_cost = ProductSelected.price;

                        total_cost = quantity * unit_cost;

                        txtProdCost.Text = total_cost.ToString();
                        btnAddToCart.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    btnAddToCart.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Only numbers are allowed", "Invalid Input");
                txtProdQuantity.Text = "";
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            history obj = new history();
            CartObject cartObj = new CartObject();

            obj.date = DateTime.Now.Date;
            obj.product = ProductSelected.id;
            obj.product1 = ProductSelected;
            obj.quantity = int.Parse(txtProdQuantity.Text);
            obj.cost = total_cost;

            cartObj.total_cost = total_cost;
            cartObj.name = ProductSelected.name;
            cartObj.quantity = txtProdQuantity.Text;
            cartObj.unit_cost = unit_cost;

            btnAddToCart.Enabled = false;
            txtProdQuantity.Enabled = false;
            txtProdQuantity.Text = "";

            cart.Add(obj);
            tempCart.Add(cartObj);

            btnViewCart.Enabled = true;
        }

        public void CreatingGrid()
        {
            var source = new BindingSource();
            cartDGV.AutoGenerateColumns = false;
            cartDGV.AllowUserToAddRows = false;
            source.DataSource = tempCart;
            cartDGV.DataSource = source;
        }

        public string CreateID()
        {
            var id = Guid.NewGuid().ToString();
            return id;
        }

        private void saveTransaction(List<history> transactions)
        {
            using (var db = new smsEntities())
            {
                foreach (var transaction in transactions)
                {
                    historyModel.order_id = orderID;
                    historyModel.product = transaction.product;
                    historyModel.date = DateTime.Now.Date;
                    historyModel.quantity = transaction.quantity;
                    historyModel.cost = transaction.cost;

                    db.histories.Add(historyModel);
                    db.SaveChanges();
                }
                string msg = "Transaction Added Successfully.";
                MessageBox.Show(msg, "Success");
                tempCart = new List<CartObject>();
                cart = new List<history>();
                txtProdCost.Text = "";
                btnViewCart.Enabled = false;
            }
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            txtLoading.Text = "Loading...";
            AttendantView.SetPage(2);
            orderID = CreateID();
            SalesPrintForm spf = new SalesPrintForm(orderID, tempCart);
            spf.ShowDialog();
            txtLoading.Text = "Processing transaction...";
            saveTransaction(cart);
            AttendantView.SetPage(0);
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = (int)productsDGV.CurrentRow.Cells[0].Value;
                fetchProduct(id);
                btnAddToCart.Enabled = false;
                txtProdQuantity.Enabled = true;
                btnViewCart.Enabled = false;
                btnSelectProduct.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }
    }

    public class CartObject
    {
        public string id { get; set; }

        public string name { get; set; }

        public string quantity { get; set; }

        public double total_cost { get; set; }

        public double unit_cost { get; set; }
    }
}
