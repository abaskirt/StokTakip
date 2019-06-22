namespace ErbasOrmanUrunleri
{
    partial class stockView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mainProductDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.productGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.productPhoto = new System.Windows.Forms.PictureBox();
            this.updateImage = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.deleteMainProduct = new System.Windows.Forms.Button();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 36);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Stok Görüntüleme Sayfası";
            // 
            // mainProductDrop
            // 
            this.mainProductDrop.BackColor = System.Drawing.Color.Transparent;
            this.mainProductDrop.BorderRadius = 3;
            this.mainProductDrop.DisabledColor = System.Drawing.Color.Gray;
            this.mainProductDrop.ForeColor = System.Drawing.Color.White;
            this.mainProductDrop.Items = new string[0];
            this.mainProductDrop.Location = new System.Drawing.Point(209, 116);
            this.mainProductDrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainProductDrop.Name = "mainProductDrop";
            this.mainProductDrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.mainProductDrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.mainProductDrop.selectedIndex = -1;
            this.mainProductDrop.Size = new System.Drawing.Size(200, 28);
            this.mainProductDrop.TabIndex = 100;
            this.mainProductDrop.onItemSelected += new System.EventHandler(this.mainProductDrop_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(13, 127);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(189, 17);
            this.bunifuCustomLabel7.TabIndex = 99;
            this.bunifuCustomLabel7.Text = "Ana Ürün Grubunu Seçiniz : ";
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productGrid.BackgroundColor = System.Drawing.Color.White;
            this.productGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.ProductName,
            this.Quantity,
            this.Date});
            this.productGrid.DoubleBuffered = true;
            this.productGrid.EnableHeadersVisualStyles = false;
            this.productGrid.GridColor = System.Drawing.Color.Black;
            this.productGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.productGrid.HeaderForeColor = System.Drawing.Color.Yellow;
            this.productGrid.Location = new System.Drawing.Point(16, 209);
            this.productGrid.Margin = new System.Windows.Forms.Padding(0);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(554, 204);
            this.productGrid.TabIndex = 101;
            this.productGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.productGrid_CellBeginEdit);
            this.productGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGrid_CellEndEdit);
            this.productGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGrid_RowEnter);
            this.productGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productGrid_RowHeaderMouseDoubleClick);
            this.productGrid.SelectionChanged += new System.EventHandler(this.productGrid_SelectionChanged);
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
            this.ProductName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Stok Adeti";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "En Son Eklenme Tarihi";
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // stockSum
            // 
            this.stockSum.AutoSize = true;
            this.stockSum.Location = new System.Drawing.Point(427, 123);
            this.stockSum.Name = "stockSum";
            this.stockSum.Size = new System.Drawing.Size(107, 17);
            this.stockSum.TabIndex = 102;
            this.stockSum.Text = "Toplam Stok : 0";
            // 
            // materialGrid
            // 
            this.materialGrid.AllowUserToAddRows = false;
            this.materialGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.materialGrid.BackgroundColor = System.Drawing.Color.White;
            this.materialGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.materialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Urun,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.materialGrid.DoubleBuffered = true;
            this.materialGrid.EnableHeadersVisualStyles = false;
            this.materialGrid.GridColor = System.Drawing.Color.Black;
            this.materialGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.materialGrid.HeaderForeColor = System.Drawing.Color.Yellow;
            this.materialGrid.Location = new System.Drawing.Point(16, 471);
            this.materialGrid.Margin = new System.Windows.Forms.Padding(0);
            this.materialGrid.Name = "materialGrid";
            this.materialGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.materialGrid.RowTemplate.Height = 24;
            this.materialGrid.Size = new System.Drawing.Size(844, 212);
            this.materialGrid.TabIndex = 103;
            this.materialGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.materialGrid_CellBeginEdit);
            this.materialGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGrid_CellEndEdit);
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Malzeme No";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Malzeme Adı";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Renk";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ebat";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adet";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vida";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Açıklama";
            this.Column6.MaxInputLength = 100;
            this.Column6.Name = "Column6";
            this.Column6.Width = 210;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 162);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(75, 25);
            this.bunifuCustomLabel2.TabIndex = 104;
            this.bunifuCustomLabel2.Text = "Ürünler";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(11, 430);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(186, 25);
            this.bunifuCustomLabel3.TabIndex = 105;
            this.bunifuCustomLabel3.Text = "Ürünün Malzemeleri";
            // 
            // productPhoto
            // 
            this.productPhoto.Image = global::ErbasOrmanUrunleri.Properties.Resources.resim_yok;
            this.productPhoto.Location = new System.Drawing.Point(573, 209);
            this.productPhoto.Name = "productPhoto";
            this.productPhoto.Size = new System.Drawing.Size(205, 204);
            this.productPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPhoto.TabIndex = 106;
            this.productPhoto.TabStop = false;
            // 
            // updateImage
            // 
            this.updateImage.BackColor = System.Drawing.Color.SeaGreen;
            this.updateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateImage.ForeColor = System.Drawing.Color.White;
            this.updateImage.Location = new System.Drawing.Point(573, 420);
            this.updateImage.Name = "updateImage";
            this.updateImage.Size = new System.Drawing.Size(205, 27);
            this.updateImage.TabIndex = 107;
            this.updateImage.Text = "Resmi Değiştir";
            this.updateImage.UseVisualStyleBackColor = false;
            this.updateImage.Click += new System.EventHandler(this.updateImage_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(92, 171);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(362, 13);
            this.bunifuCustomLabel4.TabIndex = 108;
            this.bunifuCustomLabel4.Text = "*Bir Hücreye Çift Tıklayarak Değişiklik Yapabilir Ve Stok Güncelleyebilirsiniz.";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(203, 439);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(250, 13);
            this.bunifuCustomLabel5.TabIndex = 109;
            this.bunifuCustomLabel5.Text = "*Bir Hücreye Çift Tıklayarak Değişiklik Yapabilirsiniz.";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(570, 193);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(102, 13);
            this.bunifuCustomLabel6.TabIndex = 110;
            this.bunifuCustomLabel6.Text = "Seçili Ürünün Resmi";
            // 
            // deleteMainProduct
            // 
            this.deleteMainProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteMainProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMainProduct.FlatAppearance.BorderSize = 0;
            this.deleteMainProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMainProduct.ForeColor = System.Drawing.Color.White;
            this.deleteMainProduct.Location = new System.Drawing.Point(732, 113);
            this.deleteMainProduct.Margin = new System.Windows.Forms.Padding(0);
            this.deleteMainProduct.Name = "deleteMainProduct";
            this.deleteMainProduct.Size = new System.Drawing.Size(46, 30);
            this.deleteMainProduct.TabIndex = 111;
            this.deleteMainProduct.Text = "-";
            this.deleteMainProduct.UseVisualStyleBackColor = false;
            this.deleteMainProduct.Click += new System.EventHandler(this.deleteMainProduct_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(553, 120);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(165, 17);
            this.bunifuCustomLabel9.TabIndex = 112;
            this.bunifuCustomLabel9.Text = "Seçili Ana Ürünü Kaldır : ";
            // 
            // stockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.deleteMainProduct);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.updateImage);
            this.Controls.Add(this.productPhoto);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.materialGrid);
            this.Controls.Add(this.stockSum);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.mainProductDrop);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "stockView";
            this.Size = new System.Drawing.Size(900, 720);
            this.Load += new System.EventHandler(this.stockView_Load);
            this.MouseEnter += new System.EventHandler(this.stockView_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown mainProductDrop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel stockSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Bunifu.Framework.UI.BunifuCustomDataGrid materialGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox productPhoto;
        private System.Windows.Forms.Button updateImage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Button deleteMainProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}
