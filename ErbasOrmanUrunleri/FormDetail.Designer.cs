namespace ErbasOrmanUrunleri
{
    partial class FormDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetail));
            this.allOrderListDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.orderByProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderProductId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.printButton = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allOrderListDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.allOrderListDataGrid.Location = new System.Drawing.Point(20, 161);
            this.allOrderListDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.allOrderListDataGrid.MultiSelect = false;
            this.allOrderListDataGrid.Name = "allOrderListDataGrid";
            this.allOrderListDataGrid.ReadOnly = true;
            this.allOrderListDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.allOrderListDataGrid.RowTemplate.Height = 24;
            this.allOrderListDataGrid.Size = new System.Drawing.Size(1065, 399);
            this.allOrderListDataGrid.TabIndex = 108;
            // 
            // orderByProduct
            // 
            this.orderByProduct.BorderColorFocused = System.Drawing.Color.Blue;
            this.orderByProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderByProduct.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orderByProduct.BorderThickness = 1;
            this.orderByProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderByProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderByProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderByProduct.isPassword = false;
            this.orderByProduct.Location = new System.Drawing.Point(131, 105);
            this.orderByProduct.Margin = new System.Windows.Forms.Padding(4);
            this.orderByProduct.Name = "orderByProduct";
            this.orderByProduct.Size = new System.Drawing.Size(171, 31);
            this.orderByProduct.TabIndex = 119;
            this.orderByProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderByProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderByProduct_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(410, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(231, 36);
            this.bunifuCustomLabel1.TabIndex = 120;
            this.bunifuCustomLabel1.Text = "Sipariş Detayları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(40, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 121;
            this.label5.Text = "Ürün Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(479, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ürün No : ";
            // 
            // orderProductId
            // 
            this.orderProductId.BorderColorFocused = System.Drawing.Color.Blue;
            this.orderProductId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderProductId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orderProductId.BorderThickness = 1;
            this.orderProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderProductId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderProductId.isPassword = false;
            this.orderProductId.Location = new System.Drawing.Point(579, 105);
            this.orderProductId.Margin = new System.Windows.Forms.Padding(4);
            this.orderProductId.Name = "orderProductId";
            this.orderProductId.Size = new System.Drawing.Size(171, 31);
            this.orderProductId.TabIndex = 123;
            this.orderProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderProductId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderProductId_KeyPress);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.SeaGreen;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(914, 583);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(93, 31);
            this.printButton.TabIndex = 124;
            this.printButton.Text = "Yazdır";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteOrder.FlatAppearance.BorderSize = 0;
            this.deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrder.ForeColor = System.Drawing.Color.White;
            this.deleteOrder.Location = new System.Drawing.Point(43, 583);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(93, 31);
            this.deleteOrder.TabIndex = 125;
            this.deleteOrder.Text = "Siparişi Sil";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1139, 703);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.orderProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.orderByProduct);
            this.Controls.Add(this.allOrderListDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missia Detay";
            ((System.ComponentModel.ISupportInitialize)(this.allOrderListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid allOrderListDataGrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderByProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox orderProductId;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button deleteOrder;
    }
}