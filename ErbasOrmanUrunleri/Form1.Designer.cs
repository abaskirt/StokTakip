namespace ErbasOrmanUrunleri
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.viewButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.addMainProductButton = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.goTwitter = new System.Windows.Forms.PictureBox();
            this.goFacebook = new System.Windows.Forms.PictureBox();
            this.goInstagram = new System.Windows.Forms.PictureBox();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.operatingButton = new System.Windows.Forms.Button();
            this.closeMenu = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminUserControl1 = new ErbasOrmanUrunleri.adminUserControl();
            this.popUpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.viewDetail = new System.Windows.Forms.Button();
            this.orderPage1 = new ErbasOrmanUrunleri.orderPage();
            this.stockView1 = new ErbasOrmanUrunleri.stockView();
            this.addMainProduct1 = new ErbasOrmanUrunleri.addMainProduct();
            this.loginPlease1 = new ErbasOrmanUrunleri.LoginPlease();
            this.afterLogin1 = new ErbasOrmanUrunleri.AfterLogin();
            this.operation1 = new ErbasOrmanUrunleri.Operation();
            this.orderListAll1 = new ErbasOrmanUrunleri.OrderListAll();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goInstagram)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.popUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.miniButton);
            this.topPanel.Controls.Add(this.closeButton);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ErbasOrmanUrunleri.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // miniButton
            // 
            this.miniButton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.miniButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.miniButton, "miniButton");
            this.miniButton.BorderRadius = 0;
            this.miniButton.ButtonText = "-";
            this.miniButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniButton.DisabledColor = System.Drawing.Color.Gray;
            this.miniButton.Iconcolor = System.Drawing.Color.Transparent;
            this.miniButton.Iconimage = null;
            this.miniButton.Iconimage_right = null;
            this.miniButton.Iconimage_right_Selected = null;
            this.miniButton.Iconimage_Selected = null;
            this.miniButton.IconMarginLeft = 0;
            this.miniButton.IconMarginRight = 0;
            this.miniButton.IconRightVisible = true;
            this.miniButton.IconRightZoom = 0D;
            this.miniButton.IconVisible = true;
            this.miniButton.IconZoom = 90D;
            this.miniButton.IsTab = false;
            this.miniButton.Name = "miniButton";
            this.miniButton.Normalcolor = System.Drawing.Color.Transparent;
            this.miniButton.OnHovercolor = System.Drawing.Color.LightBlue;
            this.miniButton.OnHoverTextColor = System.Drawing.Color.White;
            this.miniButton.selected = false;
            this.miniButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.miniButton.Textcolor = System.Drawing.Color.White;
            this.miniButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Activecolor = System.Drawing.Color.Red;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BorderRadius = 0;
            this.closeButton.ButtonText = "X";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DisabledColor = System.Drawing.Color.Gray;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.closeButton.Iconimage = null;
            this.closeButton.Iconimage_right = null;
            this.closeButton.Iconimage_right_Selected = null;
            this.closeButton.Iconimage_Selected = null;
            this.closeButton.IconMarginLeft = 0;
            this.closeButton.IconMarginRight = 0;
            this.closeButton.IconRightVisible = true;
            this.closeButton.IconRightZoom = 0D;
            this.closeButton.IconVisible = true;
            this.closeButton.IconZoom = 90D;
            this.closeButton.IsTab = false;
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Textcolor = System.Drawing.Color.White;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.sidePanel.Controls.Add(this.viewButton);
            this.sidePanel.Controls.Add(this.orderButton);
            this.sidePanel.Controls.Add(this.addMainProductButton);
            this.sidePanel.Controls.Add(this.bunifuCustomLabel1);
            this.sidePanel.Controls.Add(this.goTwitter);
            this.sidePanel.Controls.Add(this.goFacebook);
            this.sidePanel.Controls.Add(this.goInstagram);
            this.sidePanel.Controls.Add(this.panelSlider);
            this.sidePanel.Controls.Add(this.operatingButton);
            this.sidePanel.Controls.Add(this.closeMenu);
            this.sidePanel.Controls.Add(this.adminButton);
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.Name = "sidePanel";
            // 
            // viewButton
            // 
            resources.ApplyResources(this.viewButton, "viewButton");
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.stock;
            this.viewButton.Name = "viewButton";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            this.viewButton.MouseEnter += new System.EventHandler(this.all_MouseEnter);
            // 
            // orderButton
            // 
            resources.ApplyResources(this.orderButton, "orderButton");
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.operating;
            this.orderButton.Name = "orderButton";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            this.orderButton.MouseEnter += new System.EventHandler(this.orderButton_MouseEnter);
            this.orderButton.MouseLeave += new System.EventHandler(this.orderButton_MouseLeave);
            // 
            // addMainProductButton
            // 
            resources.ApplyResources(this.addMainProductButton, "addMainProductButton");
            this.addMainProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMainProductButton.FlatAppearance.BorderSize = 0;
            this.addMainProductButton.ForeColor = System.Drawing.Color.White;
            this.addMainProductButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.addMainPro;
            this.addMainProductButton.Name = "addMainProductButton";
            this.addMainProductButton.UseVisualStyleBackColor = true;
            this.addMainProductButton.Click += new System.EventHandler(this.addMainProductButton_Click);
            this.addMainProductButton.MouseEnter += new System.EventHandler(this.all_MouseEnter);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // goTwitter
            // 
            this.goTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTwitter.Image = global::ErbasOrmanUrunleri.Properties.Resources.twitter;
            resources.ApplyResources(this.goTwitter, "goTwitter");
            this.goTwitter.Name = "goTwitter";
            this.goTwitter.TabStop = false;
            this.goTwitter.Click += new System.EventHandler(this.goTwitter_Click);
            // 
            // goFacebook
            // 
            this.goFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goFacebook.Image = global::ErbasOrmanUrunleri.Properties.Resources.facebook;
            resources.ApplyResources(this.goFacebook, "goFacebook");
            this.goFacebook.Name = "goFacebook";
            this.goFacebook.TabStop = false;
            this.goFacebook.Click += new System.EventHandler(this.goFacebook_Click);
            // 
            // goInstagram
            // 
            this.goInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goInstagram.Image = global::ErbasOrmanUrunleri.Properties.Resources.Instagram;
            resources.ApplyResources(this.goInstagram, "goInstagram");
            this.goInstagram.Name = "goInstagram";
            this.goInstagram.TabStop = false;
            this.goInstagram.Click += new System.EventHandler(this.goInstagram_Click);
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.panelSlider, "panelSlider");
            this.panelSlider.Name = "panelSlider";
            // 
            // operatingButton
            // 
            resources.ApplyResources(this.operatingButton, "operatingButton");
            this.operatingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.operatingButton.FlatAppearance.BorderSize = 0;
            this.operatingButton.ForeColor = System.Drawing.Color.White;
            this.operatingButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.addStock;
            this.operatingButton.Name = "operatingButton";
            this.operatingButton.UseVisualStyleBackColor = true;
            this.operatingButton.Click += new System.EventHandler(this.operatingButton_Click);
            this.operatingButton.MouseEnter += new System.EventHandler(this.all_MouseEnter);
            // 
            // closeMenu
            // 
            resources.ApplyResources(this.closeMenu, "closeMenu");
            this.closeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeMenu.FlatAppearance.BorderSize = 0;
            this.closeMenu.ForeColor = System.Drawing.Color.White;
            this.closeMenu.Image = global::ErbasOrmanUrunleri.Properties.Resources.close2;
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.UseVisualStyleBackColor = true;
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // adminButton
            // 
            resources.ApplyResources(this.adminButton, "adminButton");
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.redAdmin;
            this.adminButton.Name = "adminButton";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            this.adminButton.MouseEnter += new System.EventHandler(this.all_MouseEnter);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.Window;
            this.adminPanel.Controls.Add(this.adminUserControl1);
            this.adminPanel.Controls.Add(this.popUpPanel);
            this.adminPanel.Controls.Add(this.orderPage1);
            this.adminPanel.Controls.Add(this.stockView1);
            this.adminPanel.Controls.Add(this.addMainProduct1);
            this.adminPanel.Controls.Add(this.loginPlease1);
            this.adminPanel.Controls.Add(this.afterLogin1);
            this.adminPanel.Controls.Add(this.operation1);
            this.adminPanel.Controls.Add(this.orderListAll1);
            resources.ApplyResources(this.adminPanel, "adminPanel");
            this.adminPanel.Name = "adminPanel";
            // 
            // adminUserControl1
            // 
            resources.ApplyResources(this.adminUserControl1, "adminUserControl1");
            this.adminUserControl1.Name = "adminUserControl1";
            // 
            // popUpPanel
            // 
            this.popUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.popUpPanel.Controls.Add(this.addOrderButton);
            this.popUpPanel.Controls.Add(this.viewDetail);
            resources.ApplyResources(this.popUpPanel, "popUpPanel");
            this.popUpPanel.Name = "popUpPanel";
            this.popUpPanel.Leave += new System.EventHandler(this.popUpPanel_Leave);
            // 
            // addOrderButton
            // 
            resources.ApplyResources(this.addOrderButton, "addOrderButton");
            this.addOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrderButton.FlatAppearance.BorderSize = 0;
            this.addOrderButton.ForeColor = System.Drawing.Color.White;
            this.addOrderButton.Image = global::ErbasOrmanUrunleri.Properties.Resources.addOrder;
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // viewDetail
            // 
            resources.ApplyResources(this.viewDetail, "viewDetail");
            this.viewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDetail.FlatAppearance.BorderSize = 0;
            this.viewDetail.ForeColor = System.Drawing.Color.White;
            this.viewDetail.Image = global::ErbasOrmanUrunleri.Properties.Resources.allStok;
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.UseVisualStyleBackColor = true;
            this.viewDetail.Click += new System.EventHandler(this.viewDetail_Click);
            // 
            // orderPage1
            // 
            resources.ApplyResources(this.orderPage1, "orderPage1");
            this.orderPage1.Name = "orderPage1";
            // 
            // stockView1
            // 
            resources.ApplyResources(this.stockView1, "stockView1");
            this.stockView1.Name = "stockView1";
            // 
            // addMainProduct1
            // 
            resources.ApplyResources(this.addMainProduct1, "addMainProduct1");
            this.addMainProduct1.Name = "addMainProduct1";
            // 
            // loginPlease1
            // 
            resources.ApplyResources(this.loginPlease1, "loginPlease1");
            this.loginPlease1.Name = "loginPlease1";
            // 
            // afterLogin1
            // 
            resources.ApplyResources(this.afterLogin1, "afterLogin1");
            this.afterLogin1.Name = "afterLogin1";
            // 
            // operation1
            // 
            resources.ApplyResources(this.operation1, "operation1");
            this.operation1.Name = "operation1";
            // 
            // orderListAll1
            // 
            resources.ApplyResources(this.orderListAll1, "orderListAll1");
            this.orderListAll1.Name = "orderListAll1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goInstagram)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.popUpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton miniButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button operatingButton;
        private System.Windows.Forms.Button closeMenu;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel panelSlider;
        private adminUserControl adminUserControl1;
        private Operation operation1;
        private AfterLogin afterLogin1;
        private LoginPlease loginPlease1;
        private System.Windows.Forms.PictureBox goInstagram;
        private System.Windows.Forms.PictureBox goFacebook;
        private System.Windows.Forms.PictureBox goTwitter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button addMainProductButton;
        private addMainProduct addMainProduct1;
        private stockView stockView1;
        private System.Windows.Forms.FlowLayoutPanel popUpPanel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button viewDetail;
        private orderPage orderPage1;
        private OrderListAll orderListAll1;
    }
}

