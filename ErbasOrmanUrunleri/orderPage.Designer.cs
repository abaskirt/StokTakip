namespace ErbasOrmanUrunleri
{
    partial class orderPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderPage));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addOrderPanel = new System.Windows.Forms.Panel();
            this.productGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteList = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.saveOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteFromList = new System.Windows.Forms.Button();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addToProduct = new System.Windows.Forms.Button();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numOfProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderList = new System.Windows.Forms.ListView();
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mainProductDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderExplanation = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderAdress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderBy = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(212, 36);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Sipariş Sayfası";
            // 
            // addOrderPanel
            // 
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel14);
            this.addOrderPanel.Controls.Add(this.productGrid);
            this.addOrderPanel.Controls.Add(this.siteList);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel13);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel12);
            this.addOrderPanel.Controls.Add(this.orderDate);
            this.addOrderPanel.Controls.Add(this.saveOrder);
            this.addOrderPanel.Controls.Add(this.deleteFromList);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel11);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel10);
            this.addOrderPanel.Controls.Add(this.addToProduct);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel9);
            this.addOrderPanel.Controls.Add(this.numOfProduct);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel8);
            this.addOrderPanel.Controls.Add(this.orderList);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel6);
            this.addOrderPanel.Controls.Add(this.mainProductDrop);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel7);
            this.addOrderPanel.Controls.Add(this.bunifuSeparator1);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel15);
            this.addOrderPanel.Controls.Add(this.orderPrice);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel5);
            this.addOrderPanel.Controls.Add(this.orderExplanation);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel4);
            this.addOrderPanel.Controls.Add(this.orderAdress);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel3);
            this.addOrderPanel.Controls.Add(this.bunifuCustomLabel2);
            this.addOrderPanel.Controls.Add(this.orderBy);
            this.addOrderPanel.Location = new System.Drawing.Point(19, 79);
            this.addOrderPanel.Name = "addOrderPanel";
            this.addOrderPanel.Size = new System.Drawing.Size(866, 623);
            this.addOrderPanel.TabIndex = 4;
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productGrid.BackgroundColor = System.Drawing.Color.White;
            this.productGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.ProductName,
            this.Quantity});
            this.productGrid.DoubleBuffered = true;
            this.productGrid.EnableHeadersVisualStyles = false;
            this.productGrid.GridColor = System.Drawing.Color.Black;
            this.productGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.productGrid.HeaderForeColor = System.Drawing.Color.Yellow;
            this.productGrid.Location = new System.Drawing.Point(13, 262);
            this.productGrid.Margin = new System.Windows.Forms.Padding(0);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(351, 225);
            this.productGrid.TabIndex = 102;
            // 
            // UrunId
            // 
            this.UrunId.HeaderText = "Ürün No";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Stok Adeti";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // siteList
            // 
            this.siteList.BackColor = System.Drawing.Color.Transparent;
            this.siteList.BorderRadius = 3;
            this.siteList.DisabledColor = System.Drawing.Color.Gray;
            this.siteList.ForeColor = System.Drawing.Color.White;
            this.siteList.Items = new string[] {
        "Hepsiburada.com",
        "Gittigidiyor.com",
        "N11.com",
        "Yok"};
            this.siteList.Location = new System.Drawing.Point(299, 141);
            this.siteList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteList.Name = "siteList";
            this.siteList.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.siteList.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.siteList.selectedIndex = 3;
            this.siteList.Size = new System.Drawing.Size(200, 28);
            this.siteList.TabIndex = 121;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(260, 152);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(32, 17);
            this.bunifuCustomLabel13.TabIndex = 120;
            this.bunifuCustomLabel13.Text = "Site";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(517, 152);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel12.TabIndex = 118;
            this.bunifuCustomLabel12.Text = "Tarih";
            // 
            // orderDate
            // 
            this.orderDate.BackColor = System.Drawing.Color.SeaGreen;
            this.orderDate.BorderRadius = 0;
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderDate.ForeColor = System.Drawing.Color.White;
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate.FormatCustom = null;
            this.orderDate.Location = new System.Drawing.Point(565, 139);
            this.orderDate.Margin = new System.Windows.Forms.Padding(4);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(213, 30);
            this.orderDate.TabIndex = 117;
            this.orderDate.Value = new System.DateTime(2019, 3, 19, 0, 0, 0, 0);
            // 
            // saveOrder
            // 
            this.saveOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveOrder.BorderRadius = 0;
            this.saveOrder.ButtonText = "Siparişi Kaydet";
            this.saveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveOrder.DisabledColor = System.Drawing.Color.Gray;
            this.saveOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.saveOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveOrder.Iconimage")));
            this.saveOrder.Iconimage_right = null;
            this.saveOrder.Iconimage_right_Selected = null;
            this.saveOrder.Iconimage_Selected = null;
            this.saveOrder.IconMarginLeft = 0;
            this.saveOrder.IconMarginRight = 0;
            this.saveOrder.IconRightVisible = true;
            this.saveOrder.IconRightZoom = 0D;
            this.saveOrder.IconVisible = true;
            this.saveOrder.IconZoom = 90D;
            this.saveOrder.IsTab = false;
            this.saveOrder.Location = new System.Drawing.Point(571, 561);
            this.saveOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.saveOrder.selected = false;
            this.saveOrder.Size = new System.Drawing.Size(205, 39);
            this.saveOrder.TabIndex = 116;
            this.saveOrder.Text = "Siparişi Kaydet";
            this.saveOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveOrder.Textcolor = System.Drawing.Color.White;
            this.saveOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // deleteFromList
            // 
            this.deleteFromList.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteFromList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFromList.FlatAppearance.BorderSize = 0;
            this.deleteFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromList.ForeColor = System.Drawing.Color.White;
            this.deleteFromList.Location = new System.Drawing.Point(725, 229);
            this.deleteFromList.Margin = new System.Windows.Forms.Padding(0);
            this.deleteFromList.Name = "deleteFromList";
            this.deleteFromList.Size = new System.Drawing.Size(53, 30);
            this.deleteFromList.TabIndex = 115;
            this.deleteFromList.Text = "-";
            this.deleteFromList.UseVisualStyleBackColor = false;
            this.deleteFromList.Click += new System.EventHandler(this.deleteFromList_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(585, 236);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel11.TabIndex = 114;
            this.bunifuCustomLabel11.Text = "Seçili Olanı Kaldır";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(393, 217);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(106, 17);
            this.bunifuCustomLabel10.TabIndex = 112;
            this.bunifuCustomLabel10.Text = "Sipariş Genel";
            // 
            // addToProduct
            // 
            this.addToProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.addToProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToProduct.FlatAppearance.BorderSize = 0;
            this.addToProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToProduct.ForeColor = System.Drawing.Color.White;
            this.addToProduct.Location = new System.Drawing.Point(313, 505);
            this.addToProduct.Margin = new System.Windows.Forms.Padding(0);
            this.addToProduct.Name = "addToProduct";
            this.addToProduct.Size = new System.Drawing.Size(53, 30);
            this.addToProduct.TabIndex = 111;
            this.addToProduct.Text = "+";
            this.addToProduct.UseVisualStyleBackColor = false;
            this.addToProduct.Click += new System.EventHandler(this.addToProduct_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(218, 518);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel9.TabIndex = 110;
            this.bunifuCustomLabel9.Text = "Adet Ekle";
            // 
            // numOfProduct
            // 
            this.numOfProduct.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.numOfProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numOfProduct.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.numOfProduct.BorderThickness = 1;
            this.numOfProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numOfProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.numOfProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numOfProduct.isPassword = false;
            this.numOfProduct.Location = new System.Drawing.Point(138, 505);
            this.numOfProduct.Margin = new System.Windows.Forms.Padding(4);
            this.numOfProduct.Name = "numOfProduct";
            this.numOfProduct.Size = new System.Drawing.Size(73, 30);
            this.numOfProduct.TabIndex = 109;
            this.numOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numOfProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderPrice_KeyPress);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(12, 518);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(119, 17);
            this.bunifuCustomLabel8.TabIndex = 108;
            this.bunifuCustomLabel8.Text = "Seçili Üründen ";
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.productName1,
            this.quantity1});
            this.orderList.FullRowSelect = true;
            this.orderList.GridLines = true;
            this.orderList.Location = new System.Drawing.Point(396, 262);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(382, 273);
            this.orderList.TabIndex = 107;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            // 
            // productId
            // 
            this.productId.Text = "Ürün No";
            this.productId.Width = 105;
            // 
            // productName1
            // 
            this.productName1.Text = "Ürün Adı";
            this.productName1.Width = 225;
            // 
            // quantity1
            // 
            this.quantity1.Text = "Ürün Adet";
            this.quantity1.Width = 95;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(10, 21);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(155, 25);
            this.bunifuCustomLabel6.TabIndex = 105;
            this.bunifuCustomLabel6.Text = "Sipariş Oluştur";
            // 
            // mainProductDrop
            // 
            this.mainProductDrop.BackColor = System.Drawing.Color.Transparent;
            this.mainProductDrop.BorderRadius = 3;
            this.mainProductDrop.DisabledColor = System.Drawing.Color.Gray;
            this.mainProductDrop.ForeColor = System.Drawing.Color.White;
            this.mainProductDrop.Items = new string[0];
            this.mainProductDrop.Location = new System.Drawing.Point(128, 206);
            this.mainProductDrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainProductDrop.Name = "mainProductDrop";
            this.mainProductDrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.mainProductDrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.mainProductDrop.selectedIndex = -1;
            this.mainProductDrop.Size = new System.Drawing.Size(200, 28);
            this.mainProductDrop.TabIndex = 104;
            this.mainProductDrop.onItemSelected += new System.EventHandler(this.mainProductDrop_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(13, 217);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel7.TabIndex = 103;
            this.bunifuCustomLabel7.Text = "Ana Ürün Seç : ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 177);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(763, 21);
            this.bunifuSeparator1.TabIndex = 92;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(489, 62);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(38, 17);
            this.bunifuCustomLabel15.TabIndex = 88;
            this.bunifuCustomLabel15.Text = "Fiyat";
            // 
            // orderPrice
            // 
            this.orderPrice.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.orderPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderPrice.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.orderPrice.BorderThickness = 1;
            this.orderPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderPrice.isPassword = false;
            this.orderPrice.Location = new System.Drawing.Point(492, 93);
            this.orderPrice.Margin = new System.Windows.Forms.Padding(4);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(64, 30);
            this.orderPrice.TabIndex = 80;
            this.orderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderPrice_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(562, 62);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel5.TabIndex = 89;
            this.bunifuCustomLabel5.Text = "Açıklama";
            // 
            // orderExplanation
            // 
            this.orderExplanation.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.orderExplanation.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderExplanation.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.orderExplanation.BorderThickness = 1;
            this.orderExplanation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderExplanation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderExplanation.isPassword = false;
            this.orderExplanation.Location = new System.Drawing.Point(565, 93);
            this.orderExplanation.Margin = new System.Windows.Forms.Padding(4);
            this.orderExplanation.Name = "orderExplanation";
            this.orderExplanation.Size = new System.Drawing.Size(214, 30);
            this.orderExplanation.TabIndex = 82;
            this.orderExplanation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(256, 62);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel4.TabIndex = 85;
            this.bunifuCustomLabel4.Text = "Adres";
            // 
            // orderAdress
            // 
            this.orderAdress.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.orderAdress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderAdress.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.orderAdress.BorderThickness = 1;
            this.orderAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderAdress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderAdress.isPassword = false;
            this.orderAdress.Location = new System.Drawing.Point(258, 93);
            this.orderAdress.Margin = new System.Windows.Forms.Padding(4);
            this.orderAdress.Name = "orderAdress";
            this.orderAdress.Size = new System.Drawing.Size(226, 30);
            this.orderAdress.TabIndex = 78;
            this.orderAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(74, 62);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(96, 17);
            this.bunifuCustomLabel3.TabIndex = 90;
            this.bunifuCustomLabel3.Text = "Siparişi Veren";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel2.TabIndex = 87;
            this.bunifuCustomLabel2.Text = "Sipariş";
            // 
            // orderBy
            // 
            this.orderBy.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.orderBy.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderBy.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.orderBy.BorderThickness = 1;
            this.orderBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderBy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderBy.isPassword = false;
            this.orderBy.Location = new System.Drawing.Point(77, 93);
            this.orderBy.Margin = new System.Windows.Forms.Padding(4);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(173, 30);
            this.orderBy.TabIndex = 77;
            this.orderBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(13, 572);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(273, 13);
            this.bunifuCustomLabel14.TabIndex = 122;
            this.bunifuCustomLabel14.Text = "*Sipariş Listesine Seçili Üründen Girilen Adet Kadar Ekler";
            // 
            // orderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addOrderPanel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "orderPage";
            this.Size = new System.Drawing.Size(900, 720);
            this.Enter += new System.EventHandler(this.orderPage_Enter);
            this.addOrderPanel.ResumeLayout(false);
            this.addOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel addOrderPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderExplanation;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderAdress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderBy;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox numOfProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader productName1;
        private System.Windows.Forms.ColumnHeader quantity1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDropdown mainProductDrop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Button addToProduct;
        private System.Windows.Forms.Button deleteFromList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuFlatButton saveOrder;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuDatepicker orderDate;
        private Bunifu.Framework.UI.BunifuDropdown siteList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
    }
}
