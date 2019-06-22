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
    public partial class AfterLogin : UserControl
    {
        SqlConnection con = new SqlConnection("Server =.;Trusted_Connection = True; Initial Catalog= Erbas; User ID = sa; Password= 1234;");
        SqlCommand cmd = new SqlCommand();
        public AfterLogin()
        {
            InitializeComponent();
        }

        private void AfterLogin_Enter(object sender, EventArgs e)
        {
            if (!adminUserControl.UserInfo.IsLogin)
            {
                this.SendToBack();
                return;
            }
            else
            {
                this.Visible = true;
                this.BringToFront();
                loginSuccess.Text = "Hoşgeldiniz " + adminUserControl.UserInfo.UserName;
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            adminUserControl.UserInfo.UserName = "";
            adminUserControl.UserInfo.IsLogin = false;
            this.SendToBack();
        }

        private void AfterLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!adminUserControl.UserInfo.IsLogin)
            {
                this.SendToBack();
                return;
            }
            else
            {
                this.Visible = true;
                this.BringToFront();
                loginSuccess.Text = "Hoşgeldiniz " + adminUserControl.UserInfo.UserName;
            }
        }
        private void rescanList()
        {
            adminList.Items.Clear();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ab_adminList";
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                adminList.Items.Add((row["userName"]).ToString());
            }
        }
        private void AfterLogin_Load(object sender, EventArgs e)
        {
            rescanList();
        }

        private void addUserName_Enter(object sender, EventArgs e)
        {
            if(addUserName.Text == "Kullanıcı Adı")
            {
                addUserName.Text = "";
            }
        }

        private void addUserName_Leave(object sender, EventArgs e)
        {
            if (addUserName.Text == "")
            {
                addUserName.Text = "Kullanıcı Adı";
            }
        }

        private void addPassword_Enter(object sender, EventArgs e)
        {
            if (addPassword.Text == "Şifre")
            {
                addPassword.Text = "";
            }
        }

        private void addPassword_Leave(object sender, EventArgs e)
        {
            if (addPassword.Text == "")
            {
                addPassword.Text = "Şifre";
            }
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            if(addUserName.Text == "" || addPassword.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(addUserName.Text == "Kullanıcı Adı" || addPassword.Text == "Şifre")
            {
                MessageBox.Show("Lütfen alanları doğru şekilde doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(ListViewItem item in adminList.Items)
            {
                if(item.Text.ToString() == addUserName.Text)
                {
                    MessageBox.Show("Bu kullanıcı zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_admin";
                cmd.Parameters.Clear();
                var userName = addUserName.Text.ToString();
                cmd.Parameters.AddWithValue("@userName", userName);
                var password = Cipher.Encrypt(addPassword.Text.ToString(), "True");
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@control", 1);
                cmd.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                rescanList();
                MessageBox.Show("Yeni kullanıcı başarıyla eklendi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ab_adminUpdate";
                cmd.Parameters.Clear();
                var userName = adminList.SelectedItems[0].Text;
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                MessageBox.Show("Kullanıcı silme işlemi başarılı.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rescanList();
            }
        }
    }
}
