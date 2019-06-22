using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErbasOrmanUrunleri
{
    public partial class ReportForm : Form
    {
        List<OrderDetail> _list;
        Orders _orders;
        public ReportForm(List<OrderDetail>list, Orders orders)
        {
            InitializeComponent();
            _list = list;
            _orders = orders;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            rptOrder1.SetDataSource(_list);
            rptOrder1.SetParameterValue("orderId", _orders.orderId);
            rptOrder1.SetParameterValue("orderBy", _orders.orderBy.ToString());
            rptOrder1.SetParameterValue("orderAdress", _orders.orderAdress.ToString());
            rptOrder1.SetParameterValue("orderDate", _orders.orderDate.ToString());
            rptOrder1.SetParameterValue("orderExplaination", _orders.orderExplaination);
            rptOrder1.SetParameterValue("orderPrice", _orders.orderPrice);
            rptOrder1.SetParameterValue("orderSite", _orders.orderSite);
            crystalReportViewer1.ReportSource = rptOrder1;
        }
    }
}
