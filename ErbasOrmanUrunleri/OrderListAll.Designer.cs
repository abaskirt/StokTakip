namespace ErbasOrmanUrunleri
{
    partial class OrderListAll
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.allOrderListDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.orderByText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.firstDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.refreshButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.detailButton = new System.Windows.Forms.Button();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delOrder = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.allOrderListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(276, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Son Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(32, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(277, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Sipariş Id";
            // 
            // orderIdText
            // 
            this.orderIdText.BorderColorFocused = System.Drawing.Color.Blue;
            this.orderIdText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderIdText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orderIdText.BorderThickness = 1;
            this.orderIdText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderIdText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderIdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderIdText.isPassword = false;
            this.orderIdText.Location = new System.Drawing.Point(279, 175);
            this.orderIdText.Margin = new System.Windows.Forms.Padding(4);
            this.orderIdText.Name = "orderIdText";
            this.orderIdText.Size = new System.Drawing.Size(171, 31);
            this.orderIdText.TabIndex = 114;
            this.orderIdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderIdText_KeyPress);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.SeaGreen;
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(505, 263);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(93, 31);
            this.filterButton.TabIndex = 111;
            this.filterButton.Text = "Filtrele";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 31);
            this.label1.TabIndex = 110;
            this.label1.Text = "-";
            // 
            // lastDate
            // 
            this.lastDate.BackColor = System.Drawing.Color.SeaGreen;
            this.lastDate.BorderRadius = 0;
            this.lastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastDate.ForeColor = System.Drawing.Color.White;
            this.lastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastDate.FormatCustom = null;
            this.lastDate.Location = new System.Drawing.Point(279, 264);
            this.lastDate.Name = "lastDate";
            this.lastDate.Size = new System.Drawing.Size(213, 30);
            this.lastDate.TabIndex = 109;
            this.lastDate.Value = new System.DateTime(2019, 3, 13, 22, 39, 30, 851);
            // 
            // allOrderListDataGrid
            // 
            this.allOrderListDataGrid.AllowUserToAddRows = false;
            this.allOrderListDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allOrderListDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allOrderListDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.allOrderListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allOrderListDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allOrderListDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allOrderListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allOrderListDataGrid.DoubleBuffered = true;
            this.allOrderListDataGrid.EnableHeadersVisualStyles = false;
            this.allOrderListDataGrid.GridColor = System.Drawing.Color.Black;
            this.allOrderListDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.allOrderListDataGrid.HeaderForeColor = System.Drawing.Color.Yellow;
            this.allOrderListDataGrid.Location = new System.Drawing.Point(32, 317);
            this.allOrderListDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.allOrderListDataGrid.MultiSelect = false;
            this.allOrderListDataGrid.Name = "allOrderListDataGrid";
            this.allOrderListDataGrid.ReadOnly = true;
            this.allOrderListDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.allOrderListDataGrid.RowTemplate.Height = 24;
            this.allOrderListDataGrid.Size = new System.Drawing.Size(836, 314);
            this.allOrderListDataGrid.TabIndex = 107;
            this.allOrderListDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allOrderListDataGrid_RowHeaderMouseDoubleClick);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(30, 105);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(103, 25);
            this.bunifuCustomLabel13.TabIndex = 106;
            this.bunifuCustomLabel13.Text = "Siparişler";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(212, 36);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Sipariş Sayfası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(30, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "Siparişi Veren";
            // 
            // orderByText
            // 
            this.orderByText.BorderColorFocused = System.Drawing.Color.Blue;
            this.orderByText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderByText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orderByText.BorderThickness = 1;
            this.orderByText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderByText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderByText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderByText.isPassword = false;
            this.orderByText.Location = new System.Drawing.Point(32, 175);
            this.orderByText.Margin = new System.Windows.Forms.Padding(4);
            this.orderByText.Name = "orderByText";
            this.orderByText.Size = new System.Drawing.Size(171, 31);
            this.orderByText.TabIndex = 118;
            this.orderByText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderByText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderByText_KeyPress);
            // 
            // firstDate
            // 
            this.firstDate.BackColor = System.Drawing.Color.SeaGreen;
            this.firstDate.BorderRadius = 0;
            this.firstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstDate.ForeColor = System.Drawing.Color.White;
            this.firstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstDate.FormatCustom = null;
            this.firstDate.Location = new System.Drawing.Point(35, 264);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(213, 30);
            this.firstDate.TabIndex = 120;
            this.firstDate.Value = new System.DateTime(2019, 3, 13, 22, 39, 30, 851);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(506, 175);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(93, 31);
            this.refreshButton.TabIndex = 121;
            this.refreshButton.Text = "Yenile";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // statButton
            // 
            this.statButton.BackColor = System.Drawing.Color.SeaGreen;
            this.statButton.FlatAppearance.BorderSize = 0;
            this.statButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statButton.ForeColor = System.Drawing.Color.White;
            this.statButton.Location = new System.Drawing.Point(646, 264);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(93, 31);
            this.statButton.TabIndex = 122;
            this.statButton.Text = "İstatistikler";
            this.statButton.UseVisualStyleBackColor = false;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(32, 210);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(80, 13);
            this.bunifuCustomLabel10.TabIndex = 123;
            this.bunifuCustomLabel10.Text = "*Enter\'a Basınız";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(277, 210);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 13);
            this.bunifuCustomLabel2.TabIndex = 124;
            this.bunifuCustomLabel2.Text = "*Enter\'a Basınız";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(503, 210);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(84, 13);
            this.bunifuCustomLabel3.TabIndex = 125;
            this.bunifuCustomLabel3.Text = "*Tabloyu Yeniler";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 648);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(242, 13);
            this.bunifuCustomLabel4.TabIndex = 126;
            this.bunifuCustomLabel4.Text = "*İstediğiniz Satıra Çift Tıklayarak Rapor Alabilirsiniz";
            // 
            // detailButton
            // 
            this.detailButton.BackColor = System.Drawing.Color.SeaGreen;
            this.detailButton.FlatAppearance.BorderSize = 0;
            this.detailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailButton.ForeColor = System.Drawing.Color.White;
            this.detailButton.Location = new System.Drawing.Point(646, 175);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(93, 31);
            this.detailButton.TabIndex = 127;
            this.detailButton.Text = "Detaylar";
            this.detailButton.UseVisualStyleBackColor = false;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(643, 210);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(160, 13);
            this.bunifuCustomLabel5.TabIndex = 128;
            this.bunifuCustomLabel5.Text = "*Sipariş Detayları ve Ürün Arama";
            // 
            // delOrder
            // 
            this.delOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.delOrder.FlatAppearance.BorderSize = 0;
            this.delOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delOrder.ForeColor = System.Drawing.Color.White;
            this.delOrder.Location = new System.Drawing.Point(646, 634);
            this.delOrder.Name = "delOrder";
            this.delOrder.Size = new System.Drawing.Size(93, 31);
            this.delOrder.TabIndex = 129;
            this.delOrder.Text = "Siparişi Sil";
            this.delOrder.UseVisualStyleBackColor = false;
            this.delOrder.Click += new System.EventHandler(this.delOrder_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(503, 668);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(240, 13);
            this.bunifuCustomLabel6.TabIndex = 130;
            this.bunifuCustomLabel6.Text = "*Silmek İstediğiniz Siparişi Seçip Butona Tıklayınız";
            // 
            // OrderListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.delOrder);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderByText);
            this.Controls.Add(this.allOrderListDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.orderIdText);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.lastDate);
            this.Controls.Add(this.label1);
            this.Name = "OrderListAll";
            this.Size = new System.Drawing.Size(963, 731);
            this.Load += new System.EventHandler(this.OrderListAll_Load);
            this.Enter += new System.EventHandler(this.OrderListAll_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.allOrderListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid allOrderListDataGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderIdText;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker lastDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderByText;
        private Bunifu.Framework.UI.BunifuDatepicker firstDate;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button statButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button detailButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button delOrder;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
    }
}
