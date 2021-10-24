
namespace StarMeatsPos
{
    partial class NumOrdersPerMonth
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
            this.crNumOrdersPerMonth1 = new StarMeatsPos.CRNumOrdersPerMonth();
            this.starMeatsDataSet1 = new StarMeatsPos.StarMeatsDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new StarMeatsPos.StarMeatsDataSetTableAdapters.OrderTableAdapter();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // starMeatsDataSet1
            // 
            this.starMeatsDataSet1.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.starMeatsDataSet1;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1160, 520);
            this.webBrowser1.TabIndex = 0;
            // 
            // NumOrdersPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1160, 520);
            this.Controls.Add(this.webBrowser1);
            this.Name = "NumOrdersPerMonth";
            this.Text = "NumOrdersPerMonth";
            this.Load += new System.EventHandler(this.NumOrdersPerMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CRNumOrdersPerMonth crNumOrdersPerMonth1;
        private StarMeatsDataSet starMeatsDataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private StarMeatsDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}