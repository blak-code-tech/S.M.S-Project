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
    public partial class AttendantLoginPage : Form
    {
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SalesManagement sales = new SalesManagement();
            sales.Show();
            this.Hide();
        }
    }
}