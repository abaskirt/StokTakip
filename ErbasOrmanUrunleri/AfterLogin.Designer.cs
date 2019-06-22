namespace ErbasOrmanUrunleri
{
    partial class AfterLogin
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
            this.loginSuccess = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.adminList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addNewUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginSuccess
            // 
            this.loginSuccess.AutoSize = true;
            this.loginSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginSuccess.Location = new System.Drawing.Point(657, 14);
            this.loginSuccess.Name = "loginSuccess";
            this.loginSuccess.Size = new System.Drawing.Size(71, 17);
            this.loginSuccess.TabIndex = 0;
            this.loginSuccess.Text = "Hoşgeldin";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.exitLabel.Location = new System.Drawing.Point(735, 42);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(42, 17);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Çıkış";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 368);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Kullanıcı Listesi";
            // 
            // adminList
            // 
            this.adminList.BackColor = System.Drawing.SystemColors.Control;
            this.adminList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.adminList.Location = new System.Drawing.Point(35, 416);
            this.adminList.MultiSelect = false;
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(348, 132);
            this.adminList.TabIndex = 4;
            this.adminList.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            // 
            // addUserName
            // 
            this.addUserName.BorderColorFocused = System.Drawing.Color.Blue;
            this.addUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.addUserName.BorderThickness = 1;
            this.addUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserName.isPassword = false;
            this.addUserName.Location = new System.Drawing.Point(444, 416);
            this.addUserName.Margin = new System.Windows.Forms.Padding(4);
            this.addUserName.Name = "addUserName";
            this.addUserName.Size = new System.Drawing.Size(347, 44);
            this.addUserName.TabIndex = 7;
            this.addUserName.Text = "Kullanıcı Adı";
            this.addUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUserName.Enter += new System.EventHandler(this.addUserName_Enter);
            this.addUserName.Leave += new System.EventHandler(this.addUserName_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(440, 368);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(165, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Yeni Kullanıcı Ekle";
            // 
            // addPassword
            // 
            this.addPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.addPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.addPassword.BorderThickness = 1;
            this.addPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPassword.isPassword = false;
            this.addPassword.Location = new System.Drawing.Point(444, 504);
            this.addPassword.Margin = new System.Windows.Forms.Padding(4);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(347, 44);
            this.addPassword.TabIndex = 9;
            this.addPassword.Text = "Şifre";
            this.addPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addPassword.Enter += new System.EventHandler(this.addPassword_Enter);
            this.addPassword.Leave += new System.EventHandler(this.addPassword_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ErbasOrmanUrunleri.Properties.Resources.user_delete;
            this.pictureBox2.Location = new System.Drawing.Point(444, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // addNewUser
            // 
            this.addNewUser.BackColor = System.Drawing.Color.SeaGreen;
            this.addNewUser.FlatAppearance.BorderSize = 0;
            this.addNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewUser.Image = global::ErbasOrmanUrunleri.Properties.Resources.user_add_ico;
            this.addNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewUser.Location = new System.Drawing.Point(555, 580);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(236, 52);
            this.addNewUser.TabIndex = 6;
            this.addNewUser.Text = "Yeni Kullanıcı Ekle";
            this.addNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewUser.UseVisualStyleBackColor = false;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteUser.FlatAppearance.BorderSize = 0;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUser.Image = global::ErbasOrmanUrunleri.Properties.Resources.warning_admin;
            this.deleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUser.Location = new System.Drawing.Point(147, 580);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(236, 52);
            this.deleteUser.TabIndex = 5;
            this.deleteUser.Text = "Kullanıcı Yetkisini Kaldır";
            this.deleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ErbasOrmanUrunleri.Properties.Resources.add_user2;
            this.pictureBox1.Location = new System.Drawing.Point(35, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(191, 36);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Admin Paneli";
            // 
            // AfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addPassword);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.addUserName);
            this.Controls.Add(this.addNewUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.adminList);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.loginSuccess);
            this.Name = "AfterLogin";
            this.Size = new System.Drawing.Size(900, 720);
            this.Load += new System.EventHandler(this.AfterLogin_Load);
            this.Enter += new System.EventHandler(this.AfterLogin_Enter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AfterLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel loginSuccess;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ListView adminList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addNewUser;
        private Bunifu.Framework.UI.BunifuMetroTextbox addUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox addPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
