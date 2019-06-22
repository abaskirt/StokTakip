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
    public partial class adminUserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public adminUserControl()
        {
            InitializeComponent();
        }

        private void reminderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifrenin ilk haneleri adın, gerisi de bildiğimiz rakamlar :)","Uyari",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        public static class UserInfo
        {
            public static string UserName { get; set; }
            public static bool IsLogin { get; set; }
            
        }
        private void passControl(string pass)
        {
            if (pass == "")
            {
                MessageBox.Show("Hatalı kullanıcı adı girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Cipher.Decrypt(pass, "True") != adminPassword.Text)
            {
                MessageBox.Show("Hatalı şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else    //Login successful
            {
                UserInfo.UserName = adminName.Text;
                UserInfo.IsLogin = true;
                adminPassword.Enabled = false;
                this.SendToBack();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(adminName.Text =="" || adminPassword.Text == "")
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_admin";
                cmd.Parameters.Clear();
                var userName = adminName.Text.ToString();
                cmd.Parameters.AddWithValue("@userName", userName);
                //var password = Cipher.Encrypt(adminPassword.Text.ToString(), "True");
                cmd.Parameters.AddWithValue("@password", adminPassword.Text.ToString());
                cmd.Parameters.AddWithValue("@control", 2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string pass = "";
                string authority;
                foreach (DataRow row in dt.Rows)
                {
                    pass = (row["password"]).ToString();
                    authority = (row["authority"]).ToString();
                }
                passControl(pass);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void adminName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(null, null);
            }
        }

        private void adminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(null, null);
            }
        }

        private void adminUserControl_Enter(object sender, EventArgs e)
        {
            adminPassword.Enabled = true;
            adminPassword.Text = "";
        }
    }
}
