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
    public partial class SalesPrintForm : Form
    {
        List<CartObject> _list;
        string _orderID;

        public SalesPrintForm(string orderID, List<CartObject> list)
        {
            InitializeComponent();
            _orderID = orderID;
            _list = list;
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesPrintForm_Load(object sender, EventArgs e)
        {
            rptCart1.SetDataSource(_list);
            rptCart1.SetParameterValue("pOrderID", _orderID);
            rptCart1.SetParameterValue("pDate", DateTime.Now.Date);
            crystalReportViewer1.ReportSource = rptCart1;
            crystalReportViewer1.Refresh();
        }
    }
}
