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

namespace ErbasOrmanUrunleri
{
    public partial class FormStatistic : Form
    {
        SqlConnection con = new SqlConnection("Server =.; Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public FormStatistic()
        {
            InitializeComponent();
            try {
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_statProductSite";
                cmd.Parameters.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    chartSite.Series["Site"].Points.AddXY(row["orderSite"] + "(#PERCENT)", row["Quantity"]);
                    chartSite.Series["Site"]["PieLabelStyle"] = "Disabled";
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_statProduct";
                cmd.Parameters.Clear();
                SqlDataAdapter daPro = new SqlDataAdapter(cmd);
                DataTable dtPro = new DataTable();
                daPro.Fill(dtPro);
                foreach (DataRow rowPro in dtPro.Rows)
                {
                    chartProduct.Series["Product"].Points.AddXY(rowPro["Name"], rowPro["Quantity"]);
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        private void printProduct_Click(object sender, EventArgs e)
        {
            chartProduct.Printing.PrintPreview();
        }

        private void printSite_Click(object sender, EventArgs e)
        {
            chartSite.Printing.PrintPreview();
        }
    }
}
