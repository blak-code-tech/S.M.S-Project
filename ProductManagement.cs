using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class ProductManagement : Form
    {
        //Use timer class
        Timer tmr;

        private bool accFromAdmin = false;

        private admin adminModel = new admin();
        private attendant attendantModel = new attendant();
        private category categoryModel = new category();
        private product productModel = new product();

        AddCategoryPage acp = new AddCategoryPage();
        AddProductPage app = new AddProductPage();


        #region properties
        private category categorySelected = new category();

        public category CategorySelected
        {
            get { return categorySelected; }
            set { categorySelected = value; }
        }

        private product productSelected = new product();

        public product ProductSelected
        {
            get { return productSelected; }
            set { productSelected = value; }
        }

        private attendant attendantSelected = new attendant();

        public attendant AttendantSelected
        {
            get { return attendantSelected; }
            set { attendantSelected = value; }
        }

        private List<MBT> prodsForMBT;

        #endregion
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            searchRecords("", AdminPageEnum.Most_Bought_Today);

            searchRecords("", AdminPageEnum.Today);

            // TODO: This line of code loads data into the 'smsDataSet.categories' table. You can move, or remove it, as needed.
            //this.categoriesTableAdapter.Fill(this.smsDataSet.categories);
            searchRecords(categorySearchBox.Text, AdminPageEnum.Category);

            // TODO: This line of code loads data into the 'smsDataSet.admins' table. You can move, or remove it, as needed.
            //this.adminsTableAdapter.Fill(this.smsDataSet.admins);
            searchRecords(productsSearchBox.Text, AdminPageEnum.Admins);

            // TODO: This line of code loads data into the 'smsDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.smsDataSet.products);
            searchRecords(productsSearchBox.Text, AdminPageEnum.Products);

            // TODO: This line of code loads data into the 'smsDataSet.attendants' table. You can move, or remove it, as needed.
            //this.attendantsTableAdapter.Fill(this.smsDataSet.attendants);
            searchRecords(attendantsSearchBox.Text, AdminPageEnum.Attendants);

            // TODO: This line of code loads data into the 'smsDataSet.history' table. You can move, or remove it, as needed.
            //this.historyTableAdapter.Fill(this.smsDataSet.history);
            searchRecords(historySearchBox.Text, AdminPageEnum.History);

            dashboard.ForeColor = Color.DarkGray;

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
            this.productsTableAdapter.Fill(this.smsDataSet.products);

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
            this.categoriesTableAdapter.Fill(this.smsDataSet.categories);
        }

        private void admins_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(3);
            dashboard.ForeColor = Color.DodgerBlue;
            products.ForeColor = Color.DodgerBlue;
            attendants.ForeColor = Color.DodgerBlue;
            categories.ForeColor = Color.DodgerBlue;
            history.ForeColor = Color.DodgerBlue;
            this.adminsTableAdapter.Fill(this.smsDataSet.admins);
            admins.ForeColor = Color.DarkGray;
        }

        private void newCategoryBtn_Click(object sender, EventArgs e)
        {
            acp.ShowDialog();
            acp.FormClosed += CategoryRefresh;
        }

        private void CategoryRefresh(object sender, FormClosedEventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.smsDataSet.categories);
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            app.ShowDialog();
            app.FormClosed += ProductRefresh;
        }

        private void ProductRefresh(object sender, FormClosedEventArgs e)
        {
            this.productsTableAdapter.Fill(this.smsDataSet.products);
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
            int id;

            try
            {
                id = (int)productsDGV.CurrentRow.Cells[0].Value;
                fetchCategory(id, "prod");
                editProdNameTxt.Text = ProductSelected.name;
                editProdPriceTxt.Text = ProductSelected.price.ToString();
                editProdQuantityTxt.Text = ProductSelected.quantity.ToString();
                bunifuPages1.SelectTab(7);
                editProductBtn.Enabled = false;
                deleteProductBtn.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void editCategoryBtn_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = (int)categoryDGV.CurrentRow.Cells[0].Value;
                fetchCategory(id, "cat");
                categoryEditTxt.Text = CategorySelected.category1;
                bunifuPages1.SelectTab(8);
                editCategoryBtn.Enabled = false;
                deleteCategoryBtn.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void fetchCategory(int id, string type)
        {
            string query = "";

            if (type == "cat")
            {
                query = "select * from dbo.categories where id = '" + id + "'";
            }
            else if (type == "prod")
            {
                query = "select * from dbo.products where id = '" + id + "'";
            }
            else if (type == "att")
            {
                query = "select * from dbo.attendants where id = '" + id + "'";
            }

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
                            if (type == "cat")
                            {
                                categoryModel = db.categories.Where(x => x.id == id).FirstOrDefault();

                                CategorySelected.id = categoryModel.id;
                                CategorySelected.category1 = categoryModel.category1;
                            }
                            else if (type == "prod")
                            {
                                productModel = db.products.Where(x => x.id == id).FirstOrDefault();

                                ProductSelected.id = productModel.id;
                                ProductSelected.name = productModel.name;
                                ProductSelected.price = productModel.price;
                                ProductSelected.quantity = productModel.quantity;
                                ProductSelected.category = productModel.category;
                            }
                            else if (type == "att")
                            {
                                attendantModel = db.attendants.Where(x => x.id == id).FirstOrDefault();

                                AttendantSelected.id = attendantModel.id;
                                AttendantSelected.name = attendantModel.name;
                                AttendantSelected.password = attendantModel.password;
                                AttendantSelected.username = attendantModel.username;
                            }
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


        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || passwordTxt.Text == "" || confirmPasswordTxt.Text == "" || uNameTxt.Text == "")
            {
                string msg = "Please make sure all the fields are filled.";
                MessageBox.Show(msg, "Error");
            }
            else if (passwordTxt.Text != confirmPasswordTxt.Text)
            {
                string msg = "Passwords do not match";
                MessageBox.Show(msg, "Error");
            }
            else
            {
                using (var db = new smsEntities())
                {
                    if (accFromAdmin)
                    {
                        adminModel.name = nameTxt.Text;
                        adminModel.username = uNameTxt.Text;
                        adminModel.password = passwordTxt.Text;
                        db.admins.Add(adminModel);
                    }
                    else
                    {
                        attendantModel.name = nameTxt.Text;
                        attendantModel.username = uNameTxt.Text;
                        attendantModel.password = passwordTxt.Text;
                        db.attendants.Add(attendantModel);
                    }
                    db.SaveChanges();
                    this.attendantsTableAdapter.Fill(this.smsDataSet.attendants);
                    this.adminsTableAdapter.Fill(this.smsDataSet.admins);
                    string msg = "Account Created Successfully.";
                    MessageBox.Show(msg, "Success");
                    nameTxt.Text = "";
                    uNameTxt.Text = "";
                    passwordTxt.Text = "";
                    confirmPasswordTxt.Text = "";
                }
            }
        }

        private void categoryDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editCategoryBtn.Enabled = true;
            deleteCategoryBtn.Enabled = true;
        }

        private void productsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSelected.id = (int)productsDGV.CurrentRow.Cells[0].Value;
            editProductBtn.Enabled = true;
            deleteProductBtn.Enabled = true;
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            using (var db = new smsEntities())
            {
                productModel.name = editProdNameTxt.Text;
                productModel.price = float.Parse(editProdPriceTxt.Text);
                productModel.quantity = int.Parse(editProdQuantityTxt.Text);

                try
                {
                    db.Entry(productModel).State = EntityState.Modified;
                    db.SaveChanges();
                    editProdNameTxt.Text = "";
                    editProdPriceTxt.Text = "";
                    editProdQuantityTxt.Text = "";
                    MessageBox.Show("Product Updated Successfully !!", "Success");
                    this.productsTableAdapter.Fill(this.smsDataSet.products);
                    bunifuPages1.SetPage(4);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error");
                }
            }
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            using (var db = new smsEntities())
            {
                categoryModel.category1 = categoryEditTxt.Text;

                try
                {
                    db.Entry(categoryModel).State = EntityState.Modified;
                    db.SaveChanges();
                    categoryEditTxt.Text = "";
                    MessageBox.Show("Category Updated Successfully !!", "Success");
                    this.categoriesTableAdapter.Fill(this.smsDataSet.categories);
                    bunifuPages1.SetPage(2);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error");
                }
            }
        }

        private void ProductManagement_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 5000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.historyTableAdapter.Fill(this.smsDataSet.history);
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to delete the product?";
            string title = "Delete Product";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(msg, title, btn);
            if (res == DialogResult.Yes)
            {
                //deleteRecord(ProductSelected.id, AdminPageEnum.Products);
                using (var db = new smsEntities())
                {
                    var prod = db.products.Find(ProductSelected.id);
                    db.products.Remove(prod);
                    db.SaveChanges();
                    searchRecords(productsSearchBox.Text, AdminPageEnum.Products);
                    editProductBtn.Enabled = false;
                    deleteProductBtn.Enabled = false;
                }
            }
        }

        #region Search Records
        /// <summary>
        /// This method is used to search the database
        /// </summary>
        /// <param name="keyword"></param>
        public void searchRecords(string keyword, AdminPageEnum page)
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
                        switch (page)
                        {
                            case AdminPageEnum.Products:
                                query = @"select dbo.products.id,dbo.products.name
                                          ,dbo.products.price,dbo.products.quantity,
                                            dbo.categories.category from products inner join
                                            categories on dbo.categories.id = dbo.products.category
                                            where name like '" + keyword + "%' " +
                                        "or dbo.categories.category like '" + keyword + "';";
                                break;
                            case AdminPageEnum.Admins:
                                query = @"select * from dbo.admins where name like '" + keyword + "%' " +
                               "or username like '" + keyword + "%';";
                                break;
                            case AdminPageEnum.History:
                                query = @"select dbo.history.id,dbo.products.name
                                        ,dbo.history.cost,dbo.history.quantity,
                                        dbo.history.date from history inner join
                                        products on dbo.history.product = dbo.products.id
                                         where dbo.products.name like 'coffe%';";
                                break;
                            case AdminPageEnum.Category:
                                query = @"select * from dbo.categories where category like '" + keyword + "%';";
                                break;
                            case AdminPageEnum.Attendants:
                                query = @"select * from dbo.attendants where name like '" + keyword + "%'" +
                            "or username like '" + keyword + "%';";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case AdminPageEnum.Products:
                                query = @"select dbo.products.id,dbo.products.name
                                          ,dbo.products.price,dbo.products.quantity,
                                            dbo.categories.category from products inner join
                                            categories on dbo.categories.id = dbo.products.category;";
                                break;
                            case AdminPageEnum.Admins:
                                query = @"select * from dbo.admins;";
                                break;
                            case AdminPageEnum.History:
                                query = @"select dbo.history.id,dbo.products.name
                                        ,dbo.history.cost,dbo.history.quantity,
                                        dbo.history.date from history inner join
                                        products on dbo.history.product = dbo.products.id";
                                break;
                            case AdminPageEnum.Category:
                                query = @"select * from dbo.categories";
                                break;
                            case AdminPageEnum.Attendants:
                                query = @"select * from dbo.attendants;";
                                break;
                            case AdminPageEnum.Today:
                                var date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-";

                                if (+DateTime.Now.Day <=9 )
                                {
                                    date += "0" + DateTime.Now.Day.ToString();
                                }

                                query = @"select dbo.history.id,dbo.products.name
                                        ,dbo.history.cost,dbo.history.quantity,
                                        dbo.history.date from history inner join
                                        products on dbo.history.product = dbo.products.id
                                        where dbo.history.date like '"+date+"';";
                                break;
                            case AdminPageEnum.Most_Bought_Today:
                                query = @"SELECT dbo.products.name, 
                                          sum(dbo.history.quantity) as num, sum(dbo.history.cost) as total
                                          , dbo.products.price FROM history inner join
                                        products on dbo.history.product = dbo.products.id group by 
                                        dbo.products.price, dbo.products.name;";
                                break;
                            default:
                                break;
                        }
                    }


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    switch (page)
                    {
                        case AdminPageEnum.Products:
                            ///Rendering our data grid view to be read only
                            productsDGV.ReadOnly = true;

                            productsDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            productsDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.Admins:
                            ///Rendering our data grid view to be read only
                            adminDGV.ReadOnly = true;

                            adminDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            adminDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.History:
                            ///Rendering our data grid view to be read only
                            historyDGV.ReadOnly = true;

                            historyDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            historyDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.Category:
                            ///Rendering our data grid view to be read only
                            categoryDGV.ReadOnly = true;

                            categoryDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            categoryDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.Attendants:
                            ///Rendering our data grid view to be read only
                            attendantsDGV.ReadOnly = true;

                            attendantsDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            attendantsDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.Today:
                            ///Rendering our data grid view to be read only
                            todayDGV.ReadOnly = true;

                            todayDGV.AutoGenerateColumns = false;
                            /// Assigning a data source
                            todayDGV.DataSource = ds.Tables[0];
                            break;
                        case AdminPageEnum.Most_Bought_Today:
                            prodsForMBT = new List<MBT>();
                            DataTable dt = ds.Tables[0];
                            MBT mbt = new MBT();
                            int checker = 1;

                            foreach (var item in dt.AsEnumerable())
                            {
                                var value = item.Field<int>("num");
                                if (value > checker)
                                {
                                    checker = value;
                                    mbt.name = item.Field<string>("name");
                                    mbt.num = value;
                                    mbt.total = item.Field<double>("total");
                                    mbt.unit_price = item.Field<double>("price");
                                }
                            }

                            txtProdName.Text = mbt.name;
                            txtProdQuantity.Text = mbt.num.ToString();
                            txtProdUnitPrice.Text = mbt.unit_price.ToString();
                            txtProdAmount.Text = mbt.total.ToString();

                            break;
                        default:
                            break;
                    }

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
                deleteProductBtn.Visible = true;
                editProductBtn.Visible = true;
            }
            else
            {
                txtProductAvailable.Visible = true;
                deleteProductBtn.Visible = false;
                editProductBtn.Visible = false;
            }

            if (categoryDGV.RowCount >= 1)
            {
                txtCategory.Visible = false;
                deleteCategoryBtn.Visible = true;
                editCategoryBtn.Visible = true;
            }
            else
            {
                txtCategory.Visible = true;
                deleteCategoryBtn.Visible = false;
                editCategoryBtn.Visible = false;
            }

            if (adminDGV.RowCount >= 1)
            {
                txtAdminAvailable.Visible = false;
            }
            else
            {
                txtAdminAvailable.Visible = true;
            }

            if (attendantsDGV.RowCount >= 1)
            {
                txtAttendants.Visible = false;
            }
            else
            {
                txtAttendants.Visible = true;
            }

            if (historyDGV.RowCount >= 1)
            {
                txtTransaction.Visible = false;
            }
            else
            {
                txtTransaction.Visible = true;
            }

            if (todayDGV.RowCount >= 1)
            {
                txtTransactionAvailable.Visible = false;
            }
            else
            {
                txtTransactionAvailable.Visible = true;
            }
        }

        private void productsSearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(productsSearchBox.Text, AdminPageEnum.Products);
        }

        private void adminsSearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(adminsSearchBox.Text, AdminPageEnum.Admins);
        }

        private void categorySearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(categorySearchBox.Text, AdminPageEnum.Category);
        }

        private void attendantsSearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(attendantsSearchBox.Text, AdminPageEnum.Attendants);
        }

        private void historySearchBox_TextChange(object sender, EventArgs e)
        {
            searchRecords(historySearchBox.Text, AdminPageEnum.History);
        }

        #endregion

        #region Delete Record
        private void deleteRecord(int id, AdminPageEnum page)
        {
            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {

                ///Our query to be run
                string query = "";

                try
                {
                    switch (page)
                    {
                        case AdminPageEnum.Products:
                            query = @"delete from dbo.products where dbo.products.id =" + id + ";";
                            break;
                        case AdminPageEnum.Admins:
                            break;
                        case AdminPageEnum.History:
                            break;
                        case AdminPageEnum.Category:
                            break;
                        case AdminPageEnum.Attendants:
                            break;
                        default:
                            break;
                    }

                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }
            }

            numRowsCheck();
        }
        #endregion

        private void refreshProducts_Click(object sender, EventArgs e)
        {
            searchRecords(productsSearchBox.Text, AdminPageEnum.Products);
        }

        private void refreshCategories_Click(object sender, EventArgs e)
        {
            searchRecords(categorySearchBox.Text, AdminPageEnum.Category);
        }

        private void refreshAdmins_Click(object sender, EventArgs e)
        {
            searchRecords(adminsSearchBox.Text, AdminPageEnum.Admins);
        }

        private void refreshAttendants_Click(object sender, EventArgs e)
        {
            searchRecords(attendantsSearchBox.Text, AdminPageEnum.Attendants);
        }

        private void btnUpdateAttendant_Click(object sender, EventArgs e)
        {
            if (txtAttendantPassword.Text != txtAttendantConfirm.Text)
            {
                MessageBox.Show("Passwords do not match..", "Input Error");
            }
            else
            {
                using (var db = new smsEntities())
                {
                    attendantModel.name = txtAttendantName.Text;
                    attendantModel.username = txtAttendantUname.Text;
                    attendantModel.password = txtAttendantPassword.Text;
                    try
                    {
                        db.Entry(attendantModel).State = EntityState.Modified;
                        db.SaveChanges();
                        txtAttendantName.Text = "";
                        txtAttendantUname.Text = "";
                        txtAttendantPassword.Text = "";
                        MessageBox.Show("Attendant Profile Updated Successfully !!", "Success");
                        this.attendantsTableAdapter.Fill(this.smsDataSet.attendants);
                        bunifuPages1.SetPage(5);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error");
                    }
                }
            }
        }

        private void attendantsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendantSelected.id = (int)attendantsDGV.CurrentRow.Cells[0].Value;
            btnEditAttendant.Enabled = true;
            btnDeleteAttendant.Enabled = true;
        }

        private void btnEditAttendant_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = (int)attendantsDGV.CurrentRow.Cells[0].Value;
                fetchCategory(id, "att");
                txtAttendantName.Text = AttendantSelected.name;
                txtAttendantUname.Text = AttendantSelected.username;
                txtAttendantPassword.Text = AttendantSelected.password;
                txtAttendantConfirm.Text = AttendantSelected.password;
                bunifuPages1.SelectTab(9);
                btnEditAttendant.Enabled = false;
                btnDeleteAttendant.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void btnDeleteAttendant_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to delete the attendant?";
            string title = "Delete Attendant";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(msg, title, btn);
            if (res == DialogResult.Yes)
            {
                using (var db = new smsEntities())
                {
                    var att = db.attendants.Find(AttendantSelected.id);
                    db.attendants.Remove(att);
                    db.SaveChanges();
                    searchRecords(attendantsSearchBox.Text, AdminPageEnum.Attendants);
                    btnEditAttendant.Enabled = false;
                    btnDeleteAttendant.Enabled = false;
                }
            }
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            searchRecords("", AdminPageEnum.Most_Bought_Today);

            searchRecords("", AdminPageEnum.Today);
        }
    }

    public class MBT
    {
        public string name { get; set; }
        public int num { get; set; }
        public double unit_price { get; set; }
        public double total { get; set; }
    }
}
