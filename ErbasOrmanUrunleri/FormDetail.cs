using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace ErbasOrmanUrunleri
{
    public partial class FormDetail : Form
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        DataTable dtTemp = new DataTable();
        public FormDetail()
        {
            InitializeComponent();
            gridList();
        }
        public void gridList()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_listOrderDetail";
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            allOrderListDataGrid.DataSource = dt;
            dtTemp = dt;
            allOrderListDataGrid.Columns[0].HeaderText = "Sipariş No";
            allOrderListDataGrid.Columns[1].HeaderText = "Sipariş Veren";
            allOrderListDataGrid.Columns[2].HeaderText = "Sipariş Tarihi";
            allOrderListDataGrid.Columns[3].HeaderText = "Sipariş Ücreti";
            allOrderListDataGrid.Columns[4].HeaderText = "Sipariş Adresi";
            allOrderListDataGrid.Columns[5].HeaderText = "Açıklama";
            allOrderListDataGrid.Columns[6].HeaderText = "Site";
            allOrderListDataGrid.Columns[7].HeaderText = "Ürün No";
            allOrderListDataGrid.Columns[8].HeaderText = "Ürün Adı";
            allOrderListDataGrid.Columns[9].HeaderText = "Ürün Adedi";
        }

        private void orderByProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    DataView dv = dtTemp.DefaultView;
                    dv.RowFilter = string.Format("Name like '%{0}%'", orderByProduct.Text);
                    allOrderListDataGrid.DataSource = dv.ToTable();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.ToString());
                }
            }
        }
        
        private void orderProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    DataView dv = dtTemp.DefaultView;
                    dv.RowFilter = "productId = " + orderProductId.Text;
                    allOrderListDataGrid.DataSource = dv.ToTable();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.ToString());
                }
            }
            
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Siparişleri yazdırmak istiyor musunuz?", "Uyarı",
                                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel && dr == DialogResult.No)
            {
                return;
            }
            DataGridView dgv = new DataGridView();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Siparişler ve Ürünler";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Tüm Liste";
            printer.FooterSpacing = 15;
            dgv = allOrderListDataGrid;
            printer.PrintDataGridView(dgv);
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili satırı (NO : "+ 
                allOrderListDataGrid.CurrentRow.Cells[0].Value.ToString()+ ") silmek istiyor musunuz?", "Uyarı",
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
    }
}
