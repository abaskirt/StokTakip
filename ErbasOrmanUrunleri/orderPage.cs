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
using Dapper;

namespace ErbasOrmanUrunleri
{
    public partial class orderPage : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public orderPage()
        {
            InitializeComponent();
        }

        private void orderPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void orderPage_Enter(object sender, EventArgs e)
        {
            mainProductDrop.Clear();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_listMainProuduct";
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                mainProductDrop.AddItem((row["mainProductName"]).ToString());
            }
        }

        private void mainProductDrop_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_listProduct";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mainProductName", mainProductDrop.selectedValue.ToString());
                cmd.Parameters.AddWithValue("@selection", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productGrid.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    productGrid.Rows.Add(row["productId"],
                                         row["productName"],
                                         row["productQuantity"]);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void addToProduct_Click(object sender, EventArgs e)
        {
            if (numOfProduct.Text == "" || numOfProduct.Text == "0")
            {
                MessageBox.Show("Lütfen adet giriniz!");
                return;
            }
            if(productGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen satır seçin!");
                return;
            }
            if (orderList.Items.Count != 0)
            {
                var idIdx = 0;
                var codeIdx = 2;
                int sayi1;
                int sayi2;
                bool isTrue = true;
                foreach (ListViewItem itemList in orderList.Items)
                {
                    if (itemList.SubItems[idIdx].Text == productGrid.SelectedCells[0].Value.ToString())
                    {
                        sayi1 = Int32.Parse(itemList.SubItems[codeIdx].Text);
                        sayi2 = Int32.Parse(numOfProduct.Text);
                        itemList.SubItems[codeIdx].Text = (sayi1 + sayi2).ToString();
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    ListViewItem item = new ListViewItem(productGrid.SelectedCells[0].Value.ToString());
                    item.SubItems.Add(productGrid.SelectedCells[1].Value.ToString());
                    item.SubItems.Add(numOfProduct.Text.ToString());
                    orderList.Items.Add(item);
                }
            }
            else
            {
                ListViewItem item = new ListViewItem(productGrid.SelectedCells[0].Value.ToString());
                item.SubItems.Add(productGrid.SelectedCells[1].Value.ToString());
                item.SubItems.Add(numOfProduct.Text.ToString());
                orderList.Items.Add(item);
            }
        }

        private void deleteFromList_Click(object sender, EventArgs e)
        {
            if(orderList.Items.Count == 0)
            {
                MessageBox.Show("Silinebilecek eleman yok!");
                return;
            }
            orderList.FocusedItem.Remove();
        }
        private void saveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                bool report = false;
                DialogResult dr = MessageBox.Show("İşlem sonucunda rapor istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    report = true;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_addOrder";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orderBy", orderBy.Text.ToString());
                cmd.Parameters.AddWithValue("@orderDate", orderDate.Value);
                cmd.Parameters.AddWithValue("@orderPrice", Int32.Parse(orderPrice.Text.ToString()));
                cmd.Parameters.AddWithValue("@orderAdress", orderAdress.Text.ToString());
                cmd.Parameters.AddWithValue("@orderExplanation", orderExplanation.Text.ToString());
                cmd.Parameters.AddWithValue("@orderSite", siteList.selectedValue.ToString());
                cmd.Parameters.Add("@orderId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int orderId = Convert.ToInt32(cmd.Parameters["@orderId"].Value);
                foreach (ListViewItem itemList in orderList.Items)
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_addOrderProduct";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@productId", Int32.Parse(itemList.SubItems[0].Text.ToString()));
                    cmd.Parameters.AddWithValue("@quantity",Int32.Parse(itemList.SubItems[2].Text.ToString()));
                    cmd.ExecuteNonQuery();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_decProductStock";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@productId", Int32.Parse(itemList.SubItems[0].Text.ToString()));
                    cmd.Parameters.AddWithValue("@productQuantity", Int32.Parse(itemList.SubItems[2].Text.ToString()));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("İşlem başarıyla tamamlandı. Sipariş Numarası : " + orderId.ToString());
                productGrid.Rows.Clear();
                if (report)
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_listOrder";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@orderId", orderId);
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
                    orders.orderId = orderId;
                    orders.orderBy = orderBy.Text.ToString();
                    orders.orderAdress = orderAdress.Text.ToString();
                    orders.orderDate = orderDate.Value.ToString();
                    orders.orderPrice = Int32.Parse(orderPrice.Text.ToString());
                    orders.orderExplaination = orderExplanation.Text.ToString();
                    orders.orderSite = siteList.selectedValue.ToString();
                    rptOrder rpo = new rptOrder();
                    rpo.Database.Tables["productDataTable"].SetDataSource(dt);
                    ReportForm pdf = new ReportForm(orderDetailList, orders);
                    pdf.ShowDialog();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
