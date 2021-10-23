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
    public partial class SalesManagement : Form
    {
        public SalesManagement()
        {
            InitializeComponent();
        }

        private void CloseTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
