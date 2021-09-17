
namespace StarMeatsPos
{
    partial class SalesReporting
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatedtp = new System.Windows.Forms.DateTimePicker();
            this.FromDatedtp = new System.Windows.Forms.DateTimePicker();
            this.starMeatsDataSet1 = new StarMeatsPos.StarMeatsDataSet();
            this.taReportTotalSales1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.taReportTotalSales();
            this.tanumSales1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.tanumSales();
            this.taSalesReport1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.taSalesReport();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbDisplay.Location = new System.Drawing.Point(753, 0);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(351, 682);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "Sales Report:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(417, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(141, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "From Date";
            // 
            // toDatedtp
            // 
            this.toDatedtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDatedtp.Location = new System.Drawing.Point(420, 257);
            this.toDatedtp.Name = "toDatedtp";
            this.toDatedtp.Size = new System.Drawing.Size(200, 22);
            this.toDatedtp.TabIndex = 6;
            this.toDatedtp.ValueChanged += new System.EventHandler(this.toDatedtp_ValueChanged);
            // 
            // FromDatedtp
            // 
            this.FromDatedtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromDatedtp.Location = new System.Drawing.Point(144, 257);
            this.FromDatedtp.Name = "FromDatedtp";
            this.FromDatedtp.Size = new System.Drawing.Size(200, 22);
            this.FromDatedtp.TabIndex = 5;
            this.FromDatedtp.ValueChanged += new System.EventHandler(this.FromDatedtp_ValueChanged);
            // 
            // starMeatsDataSet1
            // 
            this.starMeatsDataSet1.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taReportTotalSales1
            // 
            this.taReportTotalSales1.ClearBeforeFill = true;
            // 
            // tanumSales1
            // 
            this.tanumSales1.ClearBeforeFill = true;
            // 
            // taSalesReport1
            // 
            this.taSalesReport1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(138, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select a time frame";
            // 
            // SalesReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDatedtp);
            this.Controls.Add(this.FromDatedtp);
            this.Controls.Add(this.rtbDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesReporting";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatedtp;
        private System.Windows.Forms.DateTimePicker FromDatedtp;
        private StarMeatsDataSet starMeatsDataSet1;
        private StarMeatsDataSetTableAdapters.taReportTotalSales taReportTotalSales1;
        private StarMeatsDataSetTableAdapters.tanumSales tanumSales1;
        private StarMeatsDataSetTableAdapters.taSalesReport taSalesReport1;
        private System.Windows.Forms.Label label3;
    }
}