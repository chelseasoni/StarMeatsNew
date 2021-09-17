
namespace StarMeatsPos
{
    partial class OrdersReporting
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatedtp = new System.Windows.Forms.DateTimePicker();
            this.FromDatedtp = new System.Windows.Forms.DateTimePicker();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.starMeatsDataSet1 = new StarMeatsPos.StarMeatsDataSet();
            this.taOrdersReporting1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.taOrdersReporting();
            this.taOrdersReporting21 = new StarMeatsPos.StarMeatsDataSetTableAdapters.taOrdersReporting2();
            this.taNumOrders1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.taNumOrders();
            this.tanumSales1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.tanumSales();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(410, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(134, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "From Date";
            // 
            // toDatedtp
            // 
            this.toDatedtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDatedtp.Location = new System.Drawing.Point(413, 239);
            this.toDatedtp.Name = "toDatedtp";
            this.toDatedtp.Size = new System.Drawing.Size(200, 22);
            this.toDatedtp.TabIndex = 10;
            this.toDatedtp.ValueChanged += new System.EventHandler(this.toDatedtp_ValueChanged);
            // 
            // FromDatedtp
            // 
            this.FromDatedtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromDatedtp.Location = new System.Drawing.Point(137, 239);
            this.FromDatedtp.Name = "FromDatedtp";
            this.FromDatedtp.Size = new System.Drawing.Size(200, 22);
            this.FromDatedtp.TabIndex = 9;
            this.FromDatedtp.ValueChanged += new System.EventHandler(this.FromDatedtp_ValueChanged);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbDisplay.Location = new System.Drawing.Point(753, 0);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(351, 682);
            this.rtbDisplay.TabIndex = 13;
            this.rtbDisplay.Text = "Orders Report:";
            // 
            // starMeatsDataSet1
            // 
            this.starMeatsDataSet1.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taOrdersReporting1
            // 
            this.taOrdersReporting1.ClearBeforeFill = true;
            // 
            // taOrdersReporting21
            // 
            this.taOrdersReporting21.ClearBeforeFill = true;
            // 
            // taNumOrders1
            // 
            this.taNumOrders1.ClearBeforeFill = true;
            // 
            // tanumSales1
            // 
            this.tanumSales1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(131, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select a time frame";
            // 
            // OrdersReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDatedtp);
            this.Controls.Add(this.FromDatedtp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersReporting";
            this.Text = "OrdersReporting";
            this.Load += new System.EventHandler(this.OrdersReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatedtp;
        private System.Windows.Forms.DateTimePicker FromDatedtp;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private StarMeatsDataSet starMeatsDataSet1;
        private StarMeatsDataSetTableAdapters.taOrdersReporting taOrdersReporting1;
        private StarMeatsDataSetTableAdapters.taOrdersReporting2 taOrdersReporting21;
        private StarMeatsDataSetTableAdapters.taNumOrders taNumOrders1;
        private StarMeatsDataSetTableAdapters.tanumSales tanumSales1;
        private System.Windows.Forms.Label label3;
    }
}