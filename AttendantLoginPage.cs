using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.M.S_Project
{
    public partial class AttendantLoginPage : Form
    {
        private attendant model = new attendant();
        public AttendantLoginPage()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            ChooseUserPage cup = new ChooseUserPage();
            cup.Show();
            this.Close();
        }

        private void CloseTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region Sign In

        /// <summary>
        /// This functions is fired if the sign in button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void checkEnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateLogin();
            }
        }

        public void ValidateLogin()
        {
            if (userNameTxt.Text == "" || passwordTxt.Text == "")
            {
                string msg = "Please make sure all the fields are filled.";
                MessageBox.Show(msg, "Error");

            }
            else
            {
                verifyCred();
            }
        }

        /// <summary>
        /// Verify the credentials entered by the user
        /// </summary>
        /// <param name="Job"></param>
        public void verifyCred()
        {
            string query = "";

            query = "select username,password from dbo.attendants where username = '" +
                userNameTxt.Text + "' and password = '" + passwordTxt.Text
                      + "'";

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
                            model = db.attendants.Where(x => x.username == userNameTxt.Text).FirstOrDefault();

                            File.WriteAllText("username.txt", model.name);
                        }
                        SalesManagement sales = new SalesManagement();
                        sales.Show();
                        this.Hide();
                    }
                    else
                    {
                        string msg = "Sorry your credentials are incorrect !!";
                        MessageBox.Show(msg, "Error");

                        //Noti(msg, Notification.enmType.Error);
                    }
                }
            }
            catch (Exception a)
            {
                //Noti(a.ToString(), Notification.enmType.Info);
                MessageBox.Show(a.Message, "Error");
            }
        }
        #endregion
    }
}
