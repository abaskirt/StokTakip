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
    public partial class addMainProduct : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public addMainProduct()
        {
            InitializeComponent();
        }
        public void fillCombobox()
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

        private void addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (productName.Text.ToString() == "")
                {
                    MessageBox.Show("Lütfen ürün ismi giriniz");
                    return;
                }
                DialogResult dr = MessageBox.Show("Bu ana ürünü gerçekten eklemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.No || dr == DialogResult.Cancel)
                {
                    return;
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_addMainProduct";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mainProductName", productName.Text.ToString());
                cmd.Parameters.Add("@mainProductId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int mainProductId;
                bool success = Int32.TryParse(cmd.Parameters["@mainProductId"].Value.ToString(), out mainProductId);
                if (!success)
                {
                    MessageBox.Show("Bu ana ürün grubu zaten eklenmiş!");
                }
                else
                {
                    fillCombobox();
                    MessageBox.Show("(" + productName.Text.ToString() + ") Ana Ürün Grubuna Eklendi");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void digitText(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addMainProduct_Load(object sender, EventArgs e)
        {
            fillCombobox();
        }

        private void addMaterial_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@selection", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int mainProductId = 0;
                foreach (DataRow row in dt.Rows)
                {
                    mainProductId = Int32.Parse((row["mainProductId"]).ToString());
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_addMainProductMaterial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@materialName", product1.Text.ToString());
                cmd.Parameters.AddWithValue("@color", Color1.Text.ToString());
                cmd.Parameters.AddWithValue("@measure", measureProduct1.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", Int32.Parse(sideQuantity1.Text.ToString()));
                cmd.Parameters.AddWithValue("@vida", Int32.Parse(vida1.Text.ToString()));
                cmd.Parameters.AddWithValue("@explaination", explaination1.Text.ToString());
                cmd.Parameters.AddWithValue("@mainProductId", Int32.Parse(mainProductId.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            materialGridDoldur();
        }
        public void materialGridDoldur()
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
        private void mainProductDrop_onItemSelected(object sender, EventArgs e)
        {
            materialGridDoldur();
        }

        private void deleteMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (mainProductDrop.selectedIndex.ToString() == "-1" || materialGrid.CurrentCell == null)
                {
                    MessageBox.Show("Seçim Yapınız");
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_deleteMainProductMaterial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@materialId",
                        Int32.Parse(materialGrid.SelectedRows[0].Cells["Urun"].Value.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
                materialGridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void addMainProduct_MouseEnter(object sender, EventArgs e)
        {
            if (!adminUserControl.UserInfo.IsLogin)
            {
                this.SendToBack();
            }
        }
    }
}
