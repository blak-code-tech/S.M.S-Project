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
    public partial class ChooseUserPage : Form
    {
        public ChooseUserPage()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminLoginPage admin = new AdminLoginPage();
            admin.Show();
            this.Hide();
        }

        private void AttendantBtn_Click(object sender, EventArgs e)
        {
            AttendantLoginPage attendant = new AttendantLoginPage();
            attendant.Show();
            this.Hide();
        }

        private void CloseTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
