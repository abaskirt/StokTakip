namespace ErbasOrmanUrunleri
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistic));
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.printProduct = new System.Windows.Forms.Button();
            this.printSite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSite)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProduct
            // 
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 80;
            chartArea1.Area3DStyle.PointGapDepth = 50;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(15, 128);
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Ürünler";
            series1.Name = "Product";
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(542, 471);
            this.chartProduct.TabIndex = 0;
            this.chartProduct.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "Title1";
            title1.Text = "EN ÇOK SİPARİŞ VERİLEN ÜRÜNLER";
            this.chartProduct.Titles.Add(title1);
            // 
            // chartSite
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSite.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSite.Legends.Add(legend2);
            this.chartSite.Location = new System.Drawing.Point(572, 128);
            this.chartSite.Name = "chartSite";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Site";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValuesPerPoint = 6;
            this.chartSite.Series.Add(series2);
            this.chartSite.Size = new System.Drawing.Size(542, 471);
            this.chartSite.TabIndex = 1;
            this.chartSite.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.Name = "Title1";
            title2.Text = "SİPARİŞ VERİLEN SİTELER";
            this.chartSite.Titles.Add(title2);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(453, 38);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(262, 36);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Sipariş İstatistikleri";
            // 
            // printProduct
            // 
            this.printProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.printProduct.FlatAppearance.BorderSize = 0;
            this.printProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printProduct.ForeColor = System.Drawing.Color.White;
            this.printProduct.Location = new System.Drawing.Point(15, 605);
            this.printProduct.Name = "printProduct";
            this.printProduct.Size = new System.Drawing.Size(93, 31);
            this.printProduct.TabIndex = 123;
            this.printProduct.Text = "Yazdır";
            this.printProduct.UseVisualStyleBackColor = false;
            this.printProduct.Click += new System.EventHandler(this.printProduct_Click);
            // 
            // printSite
            // 
            this.printSite.BackColor = System.Drawing.Color.SteelBlue;
            this.printSite.FlatAppearance.BorderSize = 0;
            this.printSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printSite.ForeColor = System.Drawing.Color.White;
            this.printSite.Location = new System.Drawing.Point(572, 605);
            this.printSite.Name = "printSite";
            this.printSite.Size = new System.Drawing.Size(93, 31);
            this.printSite.TabIndex = 124;
            this.printSite.Text = "Yazdır";
            this.printSite.UseVisualStyleBackColor = false;
            this.printSite.Click += new System.EventHandler(this.printSite_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1139, 703);
            this.Controls.Add(this.printSite);
            this.Controls.Add(this.printProduct);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.chartSite);
            this.Controls.Add(this.chartProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missia İstatistik";
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSite;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button printProduct;
        private System.Windows.Forms.Button printSite;
    }
}