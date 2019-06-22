using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErbasOrmanUrunleri
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        
        public Form1()
        {
            InitializeComponent();
            adminUserControl1.BringToFront();
            afterLogin1.SendToBack();
            loginPlease1.Visible = false;
            operation1.Visible = false;
            addMainProduct1.Visible = false;
            stockView1.Visible = false;
            orderPage1.Visible = false;
            orderListAll1.Visible = false;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminUserControl1.Focus();
            panelSlider.Top = adminButton.Top;
            if (adminUserControl.UserInfo.IsLogin)
            {
                operation1.Visible = false;
                loginPlease1.Visible = false;

                orderListAll1.Visible = false;
                orderPage1.Visible = false;
                stockView1.Visible = false;

                afterLogin1.Visible = true;
                afterLogin1.BringToFront();
            }
            else
            {
                operation1.Visible = false;
                loginPlease1.Visible = false;
                adminUserControl1.BringToFront();
            }
        }

        private void operatingButton_Click(object sender, EventArgs e)
        {
            panelSlider.Top = operatingButton.Top;
            if (adminUserControl.UserInfo.IsLogin)
            {
                operation1.Visible = true;
                operation1.BringToFront();
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void goInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.instagram.com");
        }

        private void goFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com");
        }

        private void goTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitter.com");
        }

        private void addMainProductButton_Click(object sender, EventArgs e)
        {
            panelSlider.Top = addMainProductButton.Top;
            panelSlider.BringToFront();
            if (adminUserControl.UserInfo.IsLogin)
            {
                addMainProduct1.Visible = true;
                addMainProduct1.BringToFront();
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            panelSlider.Top = viewButton.Top;
            panelSlider.BringToFront();
            if (adminUserControl.UserInfo.IsLogin)
            {
                stockView1.Visible = true;
                stockView1.BringToFront();
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            popUpPanel.Visible = true;
            popUpPanel.BringToFront();
            if (adminUserControl.UserInfo.IsLogin)
            {
                
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void orderButton_MouseEnter(object sender, EventArgs e)
        {
            popUpPanel.Visible = true;
            popUpPanel.BringToFront();
        }

        private void orderButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void all_MouseEnter(object sender, EventArgs e)
        {
            popUpPanel.Visible = false;
            popUpPanel.SendToBack();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            panelSlider.Top = orderButton.Top;
            panelSlider.BringToFront();
            if (adminUserControl.UserInfo.IsLogin)
            {
                orderPage1.Visible = true;
                orderPage1.BringToFront();
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void popUpPanel_Leave(object sender, EventArgs e)
        {
            popUpPanel.Visible = false;
            popUpPanel.SendToBack();
        }
        private void viewDetail_Click(object sender, EventArgs e)
        {
            panelSlider.Top = orderButton.Top;
            panelSlider.BringToFront();
            if (adminUserControl.UserInfo.IsLogin)
            {
                orderListAll1.Visible = true;
                orderListAll1.Focus();
                orderListAll1.BringToFront();
            }
            else
            {
                loginPlease1.Visible = true;
                loginPlease1.BringToFront();
            }
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Program kapatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No || dr == DialogResult.Cancel)
            {
                return;
            }
            Form1.ActiveForm.Close();
        }
    }
}
