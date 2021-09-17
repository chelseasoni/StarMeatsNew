
namespace StarMeatsPos
{
    partial class ViewSales
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
            this.starMeatsDataSet = new StarMeatsPos.StarMeatsDataSet();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new StarMeatsPos.StarMeatsDataSetTableAdapters.SaleTableAdapter();
            this.tableAdapterManager = new StarMeatsPos.StarMeatsDataSetTableAdapters.TableAdapterManager();
            this.groupBoxSaleDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.saleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textTime = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSaleID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.group3DataSet = new StarMeatsPos.group3DataSet();
            this.saleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.SaleTableAdapter();
            this.tableAdapterManager1 = new StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager();
            this.saleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.groupBoxSaleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // starMeatsDataSet
            // 
            this.starMeatsDataSet.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.starMeatsDataSet;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SaleProductTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = this.saleTableAdapter;
            this.tableAdapterManager.UpdateOrder = StarMeatsPos.StarMeatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBoxSaleDetails
            // 
            this.groupBoxSaleDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxSaleDetails.Controls.Add(this.label1);
            this.groupBoxSaleDetails.Controls.Add(this.textBoxTotal);
            this.groupBoxSaleDetails.Controls.Add(this.textTime);
            this.groupBoxSaleDetails.Controls.Add(this.textBoxDate);
            this.groupBoxSaleDetails.Controls.Add(this.textBoxEmployeeID);
            this.groupBoxSaleDetails.Controls.Add(this.textBoxCustomerID);
            this.groupBoxSaleDetails.Controls.Add(this.label8);
            this.groupBoxSaleDetails.Controls.Add(this.textBoxSaleID);
            this.groupBoxSaleDetails.Controls.Add(this.label2);
            this.groupBoxSaleDetails.Controls.Add(this.label5);
            this.groupBoxSaleDetails.Controls.Add(this.label3);
            this.groupBoxSaleDetails.Controls.Add(this.label4);
            this.groupBoxSaleDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxSaleDetails.Location = new System.Drawing.Point(214, 342);
            this.groupBoxSaleDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSaleDetails.Name = "groupBoxSaleDetails";
            this.groupBoxSaleDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSaleDetails.Size = new System.Drawing.Size(680, 303);
            this.groupBoxSaleDetails.TabIndex = 2;
            this.groupBoxSaleDetails.TabStop = false;
            this.groupBoxSaleDetails.Text = "Sale Details";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sale ID";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Sale_Total", true));
            this.textBoxTotal.Location = new System.Drawing.Point(459, 100);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(204, 23);
            this.textBoxTotal.TabIndex = 20;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // saleBindingSource2
            // 
            this.saleBindingSource2.DataMember = "Sale";
            this.saleBindingSource2.DataSource = this.starMeatsDataSet;
            // 
            // textTime
            // 
            this.textTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Sale_Time", true));
            this.textTime.Location = new System.Drawing.Point(459, 33);
            this.textTime.Margin = new System.Windows.Forms.Padding(5);
            this.textTime.Name = "textTime";
            this.textTime.ReadOnly = true;
            this.textTime.Size = new System.Drawing.Size(204, 23);
            this.textTime.TabIndex = 24;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Sale_Date", true));
            this.textBoxDate.Location = new System.Drawing.Point(104, 230);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(204, 23);
            this.textBoxDate.TabIndex = 23;
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Employee_Id", true));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(104, 172);
            this.textBoxEmployeeID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.ReadOnly = true;
            this.textBoxEmployeeID.Size = new System.Drawing.Size(204, 23);
            this.textBoxEmployeeID.TabIndex = 22;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Customer_Id", true));
            this.textBoxCustomerID.Location = new System.Drawing.Point(104, 106);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(204, 23);
            this.textBoxCustomerID.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(386, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total";
            // 
            // textBoxSaleID
            // 
            this.textBoxSaleID.AllowDrop = true;
            this.textBoxSaleID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSaleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource2, "Sale_Id", true));
            this.textBoxSaleID.Location = new System.Drawing.Point(104, 33);
            this.textBoxSaleID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSaleID.Name = "textBoxSaleID";
            this.textBoxSaleID.ReadOnly = true;
            this.textBoxSaleID.Size = new System.Drawing.Size(204, 23);
            this.textBoxSaleID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(387, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(7, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(9, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customer ID";
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLast.Location = new System.Drawing.Point(761, 281);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(133, 34);
            this.buttonLast.TabIndex = 25;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.Location = new System.Drawing.Point(591, 281);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(133, 34);
            this.buttonNext.TabIndex = 24;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPrevious.Location = new System.Drawing.Point(375, 281);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(133, 34);
            this.buttonPrevious.TabIndex = 23;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFirst.Location = new System.Drawing.Point(214, 281);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(133, 34);
            this.buttonFirst.TabIndex = 22;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(12, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Sale ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch.Location = new System.Drawing.Point(69, 402);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 41);
            this.buttonSearch.TabIndex = 30;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(69, 351);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(124, 23);
            this.textBoxID.TabIndex = 29;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxCustomerName_TextChanged);
            // 
            // group3DataSet
            // 
            this.group3DataSet.DataSetName = "group3DataSet";
            this.group3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleBindingSource1
            // 
            this.saleBindingSource1.DataMember = "Sale";
            this.saleBindingSource1.DataSource = this.group3DataSet;
            // 
            // saleTableAdapter1
            // 
            this.saleTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.OrderProductTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PaymentTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.SaleProductTableAdapter = null;
            this.tableAdapterManager1.SaleTableAdapter = this.saleTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saleDataGridView
            // 
            this.saleDataGridView.AutoGenerateColumns = false;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.saleDataGridView.DataSource = this.saleBindingSource2;
            this.saleDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.saleDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.RowHeadersWidth = 51;
            this.saleDataGridView.Size = new System.Drawing.Size(1104, 220);
            this.saleDataGridView.TabIndex = 33;
            this.saleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDataGridView_CellContentClick);
            this.saleDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.saleDataGridView_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sale_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sale_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer_Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sale_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sale_Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sale_Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sale_Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sale_Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sale_Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(69, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "Re-load Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.groupBoxSaleDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.groupBoxSaleDetails.ResumeLayout(false);
            this.groupBoxSaleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StarMeatsDataSet starMeatsDataSet;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private StarMeatsDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private StarMeatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxSaleDetails;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSaleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private group3DataSet group3DataSet;
        private System.Windows.Forms.BindingSource saleBindingSource1;
        private group3DataSetTableAdapters.SaleTableAdapter saleTableAdapter1;
        private group3DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView saleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource saleBindingSource2;
        private System.Windows.Forms.Button button1;
    }
}