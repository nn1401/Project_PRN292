
namespace Project_PRN {
    partial class Admin_HomeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelBill = new System.Windows.Forms.Panel();
            this.labelBillUnconfirm = new System.Windows.Forms.Label();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.labelBillConfirm = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.labelTotalProduct = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.labelAccountUser = new System.Windows.Forms.Label();
            this.labelAccountAdmin = new System.Windows.Forms.Label();
            this.labelTotalAccount = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAccount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBill = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBill.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.Color.Transparent;
            this.panelBill.BackgroundImage = global::Project_PRN.Properties.Resources.BillHome;
            this.panelBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBill.Controls.Add(this.labelBillUnconfirm);
            this.panelBill.Controls.Add(this.labelTotalBill);
            this.panelBill.Controls.Add(this.labelBillConfirm);
            this.panelBill.Controls.Add(this.labelOrder);
            this.panelBill.Location = new System.Drawing.Point(902, 35);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(317, 261);
            this.panelBill.TabIndex = 1;
            this.panelBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // labelBillUnconfirm
            // 
            this.labelBillUnconfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillUnconfirm.ForeColor = System.Drawing.Color.White;
            this.labelBillUnconfirm.Location = new System.Drawing.Point(123, 169);
            this.labelBillUnconfirm.Name = "labelBillUnconfirm";
            this.labelBillUnconfirm.Size = new System.Drawing.Size(161, 41);
            this.labelBillUnconfirm.TabIndex = 5;
            this.labelBillUnconfirm.Text = "15 Unconfirm";
            this.labelBillUnconfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBillUnconfirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBill.ForeColor = System.Drawing.Color.White;
            this.labelTotalBill.Location = new System.Drawing.Point(25, 122);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(92, 88);
            this.labelTotalBill.TabIndex = 4;
            this.labelTotalBill.Text = "30";
            this.labelTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // labelBillConfirm
            // 
            this.labelBillConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillConfirm.ForeColor = System.Drawing.Color.White;
            this.labelBillConfirm.Location = new System.Drawing.Point(123, 122);
            this.labelBillConfirm.Name = "labelBillConfirm";
            this.labelBillConfirm.Size = new System.Drawing.Size(161, 41);
            this.labelBillConfirm.TabIndex = 4;
            this.labelBillConfirm.Text = "15 Confirm";
            this.labelBillConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBillConfirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // labelOrder
            // 
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.ForeColor = System.Drawing.Color.White;
            this.labelOrder.Location = new System.Drawing.Point(23, 21);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(255, 101);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            this.labelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelProduct.BackgroundImage = global::Project_PRN.Properties.Resources.ProductHome;
            this.panelProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProduct.Controls.Add(this.labelTotalProduct);
            this.panelProduct.Controls.Add(this.labelProduct);
            this.panelProduct.Location = new System.Drawing.Point(477, 35);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(317, 261);
            this.panelProduct.TabIndex = 1;
            this.panelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProduct_Paint);
            this.panelProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelProduct_MouseClick);
            // 
            // labelTotalProduct
            // 
            this.labelTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProduct.ForeColor = System.Drawing.Color.White;
            this.labelTotalProduct.Location = new System.Drawing.Point(25, 122);
            this.labelTotalProduct.Name = "labelTotalProduct";
            this.labelTotalProduct.Size = new System.Drawing.Size(92, 88);
            this.labelTotalProduct.TabIndex = 3;
            this.labelTotalProduct.Text = "30";
            this.labelTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelProduct_MouseClick);
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(23, 21);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(255, 101);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Product";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelProduct_MouseClick);
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Transparent;
            this.panelAccount.BackgroundImage = global::Project_PRN.Properties.Resources.AccountHome;
            this.panelAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAccount.Controls.Add(this.labelAccountUser);
            this.panelAccount.Controls.Add(this.labelAccountAdmin);
            this.panelAccount.Controls.Add(this.labelTotalAccount);
            this.panelAccount.Controls.Add(this.labelAccount);
            this.panelAccount.Location = new System.Drawing.Point(44, 35);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(317, 261);
            this.panelAccount.TabIndex = 0;
            this.panelAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAccount_MouseClick);
            // 
            // labelAccountUser
            // 
            this.labelAccountUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountUser.ForeColor = System.Drawing.Color.White;
            this.labelAccountUser.Location = new System.Drawing.Point(119, 169);
            this.labelAccountUser.Name = "labelAccountUser";
            this.labelAccountUser.Size = new System.Drawing.Size(161, 41);
            this.labelAccountUser.TabIndex = 3;
            this.labelAccountUser.Text = "15 User";
            this.labelAccountUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAccountUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAccount_MouseClick);
            // 
            // labelAccountAdmin
            // 
            this.labelAccountAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAccountAdmin.Location = new System.Drawing.Point(119, 122);
            this.labelAccountAdmin.Name = "labelAccountAdmin";
            this.labelAccountAdmin.Size = new System.Drawing.Size(161, 41);
            this.labelAccountAdmin.TabIndex = 2;
            this.labelAccountAdmin.Text = "15 Admin";
            this.labelAccountAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAccountAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAccount_MouseClick);
            // 
            // labelTotalAccount
            // 
            this.labelTotalAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAccount.ForeColor = System.Drawing.Color.White;
            this.labelTotalAccount.Location = new System.Drawing.Point(21, 122);
            this.labelTotalAccount.Name = "labelTotalAccount";
            this.labelTotalAccount.Size = new System.Drawing.Size(92, 88);
            this.labelTotalAccount.TabIndex = 2;
            this.labelTotalAccount.Text = "30";
            this.labelTotalAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAccount_MouseClick);
            // 
            // labelAccount
            // 
            this.labelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.ForeColor = System.Drawing.Color.White;
            this.labelAccount.Location = new System.Drawing.Point(18, 21);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(255, 101);
            this.labelAccount.TabIndex = 2;
            this.labelAccount.Text = "Account";
            this.labelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAccount_MouseClick);
            // 
            // chartProduct
            // 
            this.chartProduct.BackColor = System.Drawing.Color.Transparent;
            this.chartProduct.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartProduct.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartProduct.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartProduct.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(221, 353);
            this.chartProduct.Name = "chartProduct";
            this.chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "ProductbyCategory";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(820, 412);
            this.chartProduct.TabIndex = 2;
            this.chartProduct.Text = "chart1";
            this.chartProduct.Click += new System.EventHandler(this.chartProduct_Click);
            // 
            // chartAccount
            // 
            this.chartAccount.BackColor = System.Drawing.Color.Transparent;
            this.chartAccount.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartAccount.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartAccount.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartAccount.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartAccount.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAccount.Legends.Add(legend2);
            this.chartAccount.Location = new System.Drawing.Point(221, 353);
            this.chartAccount.Name = "chartAccount";
            this.chartAccount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Account";
            this.chartAccount.Series.Add(series2);
            this.chartAccount.Size = new System.Drawing.Size(820, 412);
            this.chartAccount.TabIndex = 3;
            this.chartAccount.Text = "chart1";
            // 
            // chartBill
            // 
            this.chartBill.BackColor = System.Drawing.Color.Transparent;
            this.chartBill.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartBill.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartBill.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartBill.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartBill.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBill.Legends.Add(legend3);
            this.chartBill.Location = new System.Drawing.Point(221, 353);
            this.chartBill.Name = "chartBill";
            this.chartBill.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackSecondaryColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.Transparent;
            series3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "CategoryName";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.chartBill.Series.Add(series3);
            this.chartBill.Size = new System.Drawing.Size(820, 412);
            this.chartBill.TabIndex = 4;
            this.chartBill.Text = "chart1";
            this.chartBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBill_MouseClick);
            // 
            // Admin_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1273, 795);
            this.Controls.Add(this.chartBill);
            this.Controls.Add(this.chartAccount);
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelAccount);
            this.Name = "Admin_HomeForm";
            this.Text = "Admin_HomeForm";
            this.Load += new System.EventHandler(this.Admin_HomeForm_Load);
            this.panelBill.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelBillUnconfirm;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.Label labelBillConfirm;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelTotalProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelAccountUser;
        private System.Windows.Forms.Label labelAccountAdmin;
        private System.Windows.Forms.Label labelTotalAccount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBill;
    }
}