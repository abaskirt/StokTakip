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
using System.IO;

namespace ErbasOrmanUrunleri
{
    public partial class Operation : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public Operation()
        {
            InitializeComponent();
        }
        private void digitText(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_addMaterial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@materialName", product1.Text.ToString());
                cmd.Parameters.AddWithValue("@color", Color1.Text.ToString());
                cmd.Parameters.AddWithValue("@measure", measureProduct1.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", Int32.Parse(sideQuantity1.Text.ToString()));
                cmd.Parameters.AddWithValue("@vida", Int32.Parse(vida1.Text.ToString()));
                cmd.Parameters.AddWithValue("@explaination", explaination1.Text.ToString());
                cmd.Parameters.Add("@materialId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int materialId = Convert.ToInt32(cmd.Parameters["@materialId"].Value);
                materialGrid.Rows.Add(materialId.ToString(),
                                      product1.Text.ToString(),
                                      Color1.Text.ToString(),
                                      measureProduct1.Text.ToString(),
                                      sideQuantity1.Text.ToString(),
                                      vida1.Text.ToString(),
                                      explaination1.Text.ToString());
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (mainProductDrop.Items.ToString() == "")
                {
                    MessageBox.Show("Ana Ürün Seçiniz");
                    return;
                }
                if(materialGrid.Rows.Count == 0)
                {
                    MessageBox.Show("Malzeme Girişi Yapın");
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_findMainProductId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mainProductName", mainProductDrop.selectedValue.ToString());
                cmd.Parameters.Add("@mainProductId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int mainProductId = Convert.ToInt32(cmd.Parameters["@mainProductId"].Value);
                ImageConverter imgc = new ImageConverter();
                byte[] img = (byte[])imgc.ConvertTo(productPhoto.Image, Type.GetType("System.Byte[]"));
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_addProduct";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productName", productName.Text.ToString());
                cmd.Parameters.AddWithValue("@productQuantity", Int32.Parse(orderTotal.Text.ToString()));
                cmd.Parameters.AddWithValue("@productDate", productDatePicker.Value);
                cmd.Parameters.AddWithValue("@productMainId", mainProductId);
                cmd.Parameters.AddWithValue("@productPhoto", img);
                cmd.Parameters.Add("@productId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int productId = Convert.ToInt32(cmd.Parameters["@productId"].Value);
                foreach (DataGridViewRow gdr in materialGrid.Rows)
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_addProductMaterial";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@materialId",Int32.Parse(gdr.Cells["Urun"].Value.ToString()));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ürün Başarıyla Eklendi","Tebrikler",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
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
                if (mainProductDrop.selectedValue.ToString() == "")
                {
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_listMainProductMaterial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mainProductName", mainProductDrop.selectedValue.ToString());
                cmd.Parameters.AddWithValue("@selection", 2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<int> list = new List<int>();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(Int32.Parse((row["materialId"]).ToString()));
                }
                materialGrid.Rows.Clear();
                foreach (int id in list)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_listMaterial";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@materialId", id);
                    SqlDataAdapter daList = new SqlDataAdapter(cmd);
                    DataTable dtList = new DataTable();
                    daList.Fill(dtList);
                    foreach (DataRow rowData in dtList.Rows)
                    {
                        materialGrid.Rows.Add(rowData["materialId"]
                                              , rowData["materialName"]
                                              , rowData["color"]
                                              , rowData["measure"]
                                              , rowData["quantity"]
                                              , rowData["vida"]
                                              , rowData["explaination"]);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Operation_Enter(object sender, EventArgs e)
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

        private void Operation_MouseEnter(object sender, EventArgs e)
        {
            if (!adminUserControl.UserInfo.IsLogin)
            {
                this.SendToBack();
            }
        }
        private void addPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files|*.*", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    productPhoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
