
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.group3DataSet1 = new StarMeatsPos.group3DataSet();
            this.productTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.ProductTableAdapter();
            this.saleProductTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.SaleProductTableAdapter();
            this.orderProductTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.OrderProductTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReport22 = new StarMeatsPos.CrystalReport2();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReport41 = new StarMeatsPos.CrystalReport4();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer2);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 633);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Product Sales Report",
            "Product Order Report"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Product Reports";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crystalReport22;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1101, 633);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.crystalReport41;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1101, 633);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // crystalReport41
            // 
            this.crystalReport41.InitReport += new System.EventHandler(this.crystalReport41_InitReport);
            // 
            // ProductReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductReporting";
            this.Text = "ProductReporting";
            this.Load += new System.EventHandler(this.ProductReporting_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private group3DataSet group3DataSet1;
        private group3DataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private group3DataSetTableAdapters.SaleProductTableAdapter saleProductTableAdapter1;
        private CrystalReport2 crystalReport22;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReport4 crystalReport41;
        private group3DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter1;
    }
}