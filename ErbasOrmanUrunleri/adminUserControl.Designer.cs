namespace ErbasOrmanUrunleri
{
    partial class adminUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminUserControl));
            this.reminderButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.adminPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adminName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reminderButton
            // 
            this.reminderButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reminderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reminderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reminderButton.BorderRadius = 0;
            this.reminderButton.ButtonText = "Şifreyi Unuttum";
            this.reminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reminderButton.DisabledColor = System.Drawing.Color.Gray;
            this.reminderButton.Iconcolor = System.Drawing.Color.Transparent;
            this.reminderButton.Iconimage = global::ErbasOrmanUrunleri.Properties.Resources.warning2;
            this.reminderButton.Iconimage_right = null;
            this.reminderButton.Iconimage_right_Selected = null;
            this.reminderButton.Iconimage_Selected = null;
            this.reminderButton.IconMarginLeft = 0;
            this.reminderButton.IconMarginRight = 0;
            this.reminderButton.IconRightVisible = true;
            this.reminderButton.IconRightZoom = 0D;
            this.reminderButton.IconVisible = true;
            this.reminderButton.IconZoom = 90D;
            this.reminderButton.IsTab = false;
            this.reminderButton.Location = new System.Drawing.Point(459, 586);
            this.reminderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reminderButton.Name = "reminderButton";
            this.reminderButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reminderButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reminderButton.OnHoverTextColor = System.Drawing.Color.White;
            this.reminderButton.selected = false;
            this.reminderButton.Size = new System.Drawing.Size(218, 60);
            this.reminderButton.TabIndex = 16;
            this.reminderButton.Text = "Şifreyi Unuttum";
            this.reminderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reminderButton.Textcolor = System.Drawing.Color.White;
            this.reminderButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderButton.Click += new System.EventHandler(this.reminderButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "Onayla";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(120, 586);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(218, 60);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Onayla";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(115, 474);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(189, 29);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Admin Şifresi  :";
            // 
            // adminPassword
            // 
            this.adminPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.adminPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.adminPassword.BorderThickness = 3;
            this.adminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminPassword.isPassword = true;
            this.adminPassword.Location = new System.Drawing.Point(332, 462);
            this.adminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(345, 44);
            this.adminPassword.TabIndex = 13;
            this.adminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminPassword_KeyDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(115, 379);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(194, 29);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Admin Adı       : ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(144, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(596, 35);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Erbaş Orman Ürünleri Admin Paneli Giriş";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ErbasOrmanUrunleri.Properties.Resources.admin4;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(312, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // adminName
            // 
            this.adminName.BorderColorFocused = System.Drawing.Color.Blue;
            this.adminName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.adminName.BorderThickness = 3;
            this.adminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminName.isPassword = false;
            this.adminName.Location = new System.Drawing.Point(332, 367);
            this.adminName.Margin = new System.Windows.Forms.Padding(4);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(345, 44);
            this.adminName.TabIndex = 9;
            this.adminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminName_KeyDown);
            // 
            // adminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reminderButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.adminName);
            this.Name = "adminUserControl";
            this.Size = new System.Drawing.Size(900, 720);
            this.Enter += new System.EventHandler(this.adminUserControl_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton reminderButton;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox adminPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox adminName;
    }
}
