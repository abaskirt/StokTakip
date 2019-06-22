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
    public partial class stockView : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public stockView()
        {
            InitializeComponent();
        }
        public void fillCombobox()
        {
            try
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
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void stockView_Load(object sender, EventArgs e)
        {
            fillCombobox();
        }
        public void fillGrid()
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
                materialGrid.Rows.Clear();
                int sumStock = 0;
                foreach (DataRow row in dt.Rows)
                {
                    productGrid.Rows.Add(row["productId"],
                                         row["productName"],
                                         row["productQuantity"],
                                         row["productDate"]);
                    sumStock += Int32.Parse(row["productQuantity"].ToString());
                }
                stockSum.Text = "Toplam Stok : " + sumStock.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void mainProductDrop_onItemSelected(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void stockView_Enter(object sender, EventArgs e)
        {

        }

        private void productGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(productGrid.CurrentRow.Cells[0].Value == null ||
                   productGrid.CurrentRow.Cells[1].Value == null ||
                   productGrid.CurrentRow.Cells[2].Value == null ||
                   productGrid.CurrentRow.Cells[3].Value == null || (
                   firstValueColumn0 == productGrid.CurrentRow.Cells[0].Value.ToString() &&
                   firstValueColumn1 == productGrid.CurrentRow.Cells[1].Value.ToString() &&
                   firstValueColumn2 == productGrid.CurrentRow.Cells[2].Value.ToString() &&
                   firstValueColumn3 == productGrid.CurrentRow.Cells[3].Value.ToString()))
                {
                    return;
                }
                DialogResult dr = MessageBox.Show("Ürünü güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel || dr == DialogResult.No)
                {
                    return;
                }
                DateTime tryDate = new DateTime();
                int tryInt;
                bool isTrue = true;
                if(productGrid.CurrentCell.ColumnIndex == 3)
                {
                    if (DateTime.TryParse(productGrid.CurrentRow.Cells[3].Value.ToString(), out tryDate))
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                    }
                }
                if (productGrid.CurrentCell.ColumnIndex == 2)
                {
                    if (Int32.TryParse(productGrid.CurrentRow.Cells[2].Value.ToString(), out tryInt))
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ab_updateProduct";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@productId", productGrid.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@productName", productGrid.CurrentRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@productQuantity", Int32.Parse
                                               (productGrid.CurrentRow.Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@productDate", productGrid.CurrentRow.Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Değişiklik başarılıyla tamamlandı. Değişiklikleri görmek için lütfen ana ürünü değiştiriniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hatalı değer girdiniz. Lütfen kontrol ediniz");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        string firstValueColumn0;
        string firstValueColumn1;
        string firstValueColumn2;
        string firstValueColumn3;

        private void productGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            firstValueColumn0 = productGrid.CurrentRow.Cells[0].Value.ToString();
            firstValueColumn1 = productGrid.CurrentRow.Cells[1].Value.ToString();
            firstValueColumn2 = productGrid.CurrentRow.Cells[2].Value.ToString();
            firstValueColumn3 = productGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void productGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_listMaterialWithProduct";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@productId", productGrid.CurrentRow.Cells[0].Value.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            materialGrid.Rows.Clear();
            foreach (DataRow rowData in dt.Rows)
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
        string firstValueMaterial0;
        string firstValueMaterial1;
        string firstValueMaterial2;
        string firstValueMaterial3;
        string firstValueMaterial4;
        string firstValueMaterial5;
        string firstValueMaterial6;
        private void materialGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            firstValueMaterial0 = materialGrid.CurrentRow.Cells[0].Value.ToString();
            firstValueMaterial1 = materialGrid.CurrentRow.Cells[1].Value.ToString();
            firstValueMaterial2 = materialGrid.CurrentRow.Cells[2].Value.ToString();
            firstValueMaterial3 = materialGrid.CurrentRow.Cells[3].Value.ToString();
            firstValueMaterial4 = materialGrid.CurrentRow.Cells[4].Value.ToString();
            firstValueMaterial5 = materialGrid.CurrentRow.Cells[5].Value.ToString();
            firstValueMaterial6 = materialGrid.CurrentRow.Cells[6].Value.ToString();
        }

        private void materialGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (materialGrid.CurrentRow.Cells[0].Value == null ||
                productGrid.CurrentRow.Cells[1].Value == null || (
                firstValueMaterial0 == materialGrid.CurrentRow.Cells[0].Value.ToString() &&
                firstValueMaterial1 == materialGrid.CurrentRow.Cells[1].Value.ToString() &&
                firstValueMaterial2 == materialGrid.CurrentRow.Cells[2].Value.ToString() &&
                firstValueMaterial3 == materialGrid.CurrentRow.Cells[3].Value.ToString() &&
                firstValueMaterial4 == materialGrid.CurrentRow.Cells[4].Value.ToString() &&
                firstValueMaterial5 == materialGrid.CurrentRow.Cells[5].Value.ToString() &&
                firstValueMaterial6 == materialGrid.CurrentRow.Cells[6].Value.ToString()))
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Malzemeyi güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                materialGrid.CurrentRow.Cells[0].Value= firstValueMaterial0;
                firstValueMaterial1 = materialGrid.CurrentRow.Cells[1].Value.ToString();
                firstValueMaterial2 = materialGrid.CurrentRow.Cells[2].Value.ToString();
                firstValueMaterial3 = materialGrid.CurrentRow.Cells[3].Value.ToString();
                firstValueMaterial4 = materialGrid.CurrentRow.Cells[4].Value.ToString();
                firstValueMaterial5 = materialGrid.CurrentRow.Cells[5].Value.ToString();
                firstValueMaterial6 = materialGrid.CurrentRow.Cells[6].Value.ToString();
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_updateMaterial";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@materialId", Int32.Parse(materialGrid.CurrentRow.Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@materialName", materialGrid.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@color", materialGrid.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@measure", materialGrid.CurrentRow.Cells[3].Value.ToString());
            cmd.Parameters.AddWithValue("@quantity", Int32.Parse(materialGrid.CurrentRow.Cells[4].Value.ToString()));
            cmd.Parameters.AddWithValue("@vida", Int32.Parse(materialGrid.CurrentRow.Cells[5].Value.ToString()));
            cmd.Parameters.AddWithValue("@explaination", materialGrid.CurrentRow.Cells[6].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Değişiklik başarılıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void stockView_MouseEnter(object sender, EventArgs e)
        {
            if (!adminUserControl.UserInfo.IsLogin)
            {
                this.SendToBack();
            }
        }

        private void productGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void productGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (productGrid.CurrentRow == null)
                {
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_getProductPhoto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productId", productGrid.CurrentRow.Cells[0].Value);
                cmd.Parameters.Add("@productPhoto", SqlDbType.VarBinary, 2147483647).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@productPhoto"].Value.ToString() == "")
                {
                    productPhoto.Image = ErbasOrmanUrunleri.Properties.Resources.resim_yok;
                    return;
                }
                byte[] pic = (byte[])cmd.Parameters["@productPhoto"].Value;
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    productPhoto.Image = Image.FromStream(ms);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        private void updateImage_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seçili Ürünün Resmini Güncellemek İstiyor musunuz","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.No)
                {
                    return;
                }
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files|*.*", Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        productPhoto.Image = Image.FromFile(ofd.FileName);
                    }
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (productGrid.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen Satır Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ImageConverter imgc = new ImageConverter();
                byte[] img = (byte[])imgc.ConvertTo(productPhoto.Image, Type.GetType("System.Byte[]"));
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_updateProductPhoto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productId", productGrid.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@productPhoto", img);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resim Güncellendi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        private void deleteMainProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Dikkat! Seçili Ürünü Gerçekten Kaldırmak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_deleteMainProduct";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mainProductName", mainProductDrop.selectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ana Ürün Silindi");
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }
    }
}
