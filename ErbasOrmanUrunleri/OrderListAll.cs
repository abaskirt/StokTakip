using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ErbasOrmanUrunleri
{
    public partial class OrderListAll : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        DataTable dtTemp = new DataTable();

        public void gridList()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_listAllOrder";
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns[5].SetOrdinal(dt.Columns.Count - 1);
            allOrderListDataGrid.DataSource = dt;
            dtTemp = dt;
            allOrderListDataGrid.Columns[0].HeaderText = "Sipariş No";
            allOrderListDataGrid.Columns[0].Width = 50;
            allOrderListDataGrid.Columns[1].HeaderText = "Sipariş Veren";
            allOrderListDataGrid.Columns[2].HeaderText = "Sipariş Tarihi";
            allOrderListDataGrid.Columns[3].HeaderText = "Sipariş Ücreti";
            allOrderListDataGrid.Columns[4].HeaderText = "Sipariş Adresi";
            allOrderListDataGrid.Columns[5].HeaderText = "Site";
            allOrderListDataGrid.Columns[6].HeaderText = "Açıklama";
            allOrderListDataGrid.Columns[1].Width = 140;
            allOrderListDataGrid.Columns[2].Width = 120;
            allOrderListDataGrid.Columns[3].Width = 60;
            allOrderListDataGrid.Columns[4].Width = 160;
            allOrderListDataGrid.Columns[5].Width = 100;
            allOrderListDataGrid.Columns[6].Width = 130;
        }
        public OrderListAll()
        {
            InitializeComponent();
            gridList();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_filterOrderDate";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firstDate", firstDate.Value);
                cmd.Parameters.AddWithValue("@lastDate", lastDate.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                allOrderListDataGrid.DataSource = dt;
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        private void orderByText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    DataView dv = dtTemp.DefaultView;
                    dv.RowFilter = string.Format("orderBy like '%{0}%'", orderByText.Text);
                    allOrderListDataGrid.DataSource = dv.ToTable();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.ToString());
                }
            }
        }

        private void orderIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && orderIdText.Text != "")
            {
                try
                {
                    DataView dv = dtTemp.DefaultView;
                    dv.RowFilter = "orderId = " + orderIdText.Text;
                    allOrderListDataGrid.DataSource = dv.ToTable();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.ToString());
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            gridList();
        }

        private void allOrderListDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seçili satır için rapor yazdırmak istiyor musunuz?","Uyarı", 
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dr == DialogResult.Cancel)
                {
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_listOrder";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orderId", allOrderListDataGrid.CurrentRow.Cells[0].Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<OrderDetail> orderDetailList = new List<OrderDetail>();
                Orders orders = new Orders();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    OrderDetail ordDetail = new OrderDetail();
                    ordDetail.productId = Convert.ToInt32(dt.Rows[i]["productId"]);
                    ordDetail.productName = dt.Rows[i]["productName"].ToString();
                    ordDetail.mainProductName = dt.Rows[i]["mainProductName"].ToString();
                    ordDetail.quantity = Convert.ToInt32(dt.Rows[i]["quantity"]);
                    orderDetailList.Add(ordDetail);
                }
                orders.orderId = Int32.Parse(allOrderListDataGrid.CurrentRow.Cells[0].Value.ToString());
                orders.orderBy = allOrderListDataGrid.CurrentRow.Cells[1].Value.ToString();
                orders.orderAdress = allOrderListDataGrid.CurrentRow.Cells[4].Value.ToString();
                orders.orderDate = allOrderListDataGrid.CurrentRow.Cells[2].Value.ToString();
                orders.orderPrice = Int32.Parse(allOrderListDataGrid.CurrentRow.Cells[3].Value.ToString());
                orders.orderExplaination = allOrderListDataGrid.CurrentRow.Cells[6].Value.ToString();
                orders.orderSite = allOrderListDataGrid.CurrentRow.Cells[5].Value.ToString();
                rptOrder rpo = new rptOrder();
                rpo.Database.Tables["productDataTable"].SetDataSource(dt);
                ReportForm pdf = new ReportForm(orderDetailList, orders);
                pdf.ShowDialog();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        private void OrderListAll_Load(object sender, EventArgs e)
        {
            gridList();
        }

        private void OrderListAll_Enter(object sender, EventArgs e)
        {
            gridList();
        }
        Form stat = new FormStatistic();
        private void statButton_Click(object sender, EventArgs e)
        {
            if (stat.IsDisposed)
            {
                stat = new FormStatistic();
            }
            stat.Show();
        }
        Form detail = new FormDetail();
        private void detailButton_Click(object sender, EventArgs e)
        {
            if (detail.IsDisposed)
            {
                detail = new FormDetail();
            }
            detail.Show();
        }

        private void delOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seçili satırı (Sipariş No : " +
                allOrderListDataGrid.CurrentRow.Cells[0].Value.ToString() + ") silmek istiyor musunuz?", "Uyarı",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel || dr == DialogResult.No)
                {
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_deleteOrder";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orderId", allOrderListDataGrid.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                gridList();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }
    }
}
