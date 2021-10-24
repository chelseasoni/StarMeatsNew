
namespace StarMeatsPos
{
    partial class ProductReporting
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
            this.crystalReport41 = new StarMeatsPos.CrystalReport4();
            this.group3DataSet1 = new StarMeatsPos.group3DataSet();
            this.productTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.ProductTableAdapter();
            this.saleProductTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.SaleProductTableAdapter();
            this.orderProductTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.OrderProductTableAdapter();
            this.crystalReport22 = new StarMeatsPos.CrystalReport2();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReport41
            // 
            //this.crystalReport41.InitReport += new System.EventHandler(this.crystalReport41_InitReport);
            // 
            // group3DataSet1
            // 
            this.group3DataSet1.DataSetName = "group3DataSet";
            this.group3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // saleProductTableAdapter1
            // 
            this.saleProductTableAdapter1.ClearBeforeFill = true;
            // 
            // orderProductTableAdapter1
            // 
            this.orderProductTableAdapter1.ClearBeforeFill = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1104, 682);
            this.webBrowser1.TabIndex = 0;
            // 
            // ProductReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ProductReporting";
            this.Text = "ProductReporting";
            this.Load += new System.EventHandler(this.ProductReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private group3DataSet group3DataSet1;
        private group3DataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private group3DataSetTableAdapters.SaleProductTableAdapter saleProductTableAdapter1;
        private CrystalReport2 crystalReport22;
        private CrystalReport4 crystalReport41;
        private group3DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}