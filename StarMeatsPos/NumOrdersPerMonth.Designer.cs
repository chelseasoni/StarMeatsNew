
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new StarMeatsPos.StarMeatsDataSetTableAdapters.OrderTableAdapter();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFulfilledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inprogressDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.preparedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // starMeatsDataSet1
            // 
            this.starMeatsDataSet1.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.isFulfilledDataGridViewCheckBoxColumn,
            this.inprogressDataGridViewCheckBoxColumn,
            this.preparedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(367, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
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
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "Order_Id";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Order_Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End_Date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End_Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // isFulfilledDataGridViewCheckBoxColumn
            // 
            this.isFulfilledDataGridViewCheckBoxColumn.DataPropertyName = "Is_Fulfilled";
            this.isFulfilledDataGridViewCheckBoxColumn.HeaderText = "Is_Fulfilled";
            this.isFulfilledDataGridViewCheckBoxColumn.Name = "isFulfilledDataGridViewCheckBoxColumn";
            // 
            // inprogressDataGridViewCheckBoxColumn
            // 
            this.inprogressDataGridViewCheckBoxColumn.DataPropertyName = "in_progress";
            this.inprogressDataGridViewCheckBoxColumn.HeaderText = "in_progress";
            this.inprogressDataGridViewCheckBoxColumn.Name = "inprogressDataGridViewCheckBoxColumn";
            // 
            // preparedDataGridViewCheckBoxColumn
            // 
            this.preparedDataGridViewCheckBoxColumn.DataPropertyName = "prepared";
            this.preparedDataGridViewCheckBoxColumn.HeaderText = "prepared";
            this.preparedDataGridViewCheckBoxColumn.Name = "preparedDataGridViewCheckBoxColumn";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crNumOrdersPerMonth1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(946, 518);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // NumOrdersPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 520);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NumOrdersPerMonth";
            this.Text = "NumOrdersPerMonth";
            this.Load += new System.EventHandler(this.NumOrdersPerMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CRNumOrdersPerMonth crNumOrdersPerMonth1;
        private StarMeatsDataSet starMeatsDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private StarMeatsDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFulfilledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inprogressDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn preparedDataGridViewCheckBoxColumn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}