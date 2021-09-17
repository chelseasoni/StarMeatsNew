
using System.Windows.Forms;

namespace StarMeatsPos
{
    partial class ProcessSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonProcessSale = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group3DataSet = new StarMeatsPos.group3DataSet();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.SaleProductGridView = new System.Windows.Forms.DataGridView();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantitySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodSoldPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxsubtotal = new System.Windows.Forms.TextBox();
            this.saleGridView = new System.Windows.Forms.DataGridView();
            this.saleIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.starMeatsDataSet = new StarMeatsPos.StarMeatsDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.PaymentComboBox = new System.Windows.Forms.ComboBox();
            this.receiptrichTextBox = new System.Windows.Forms.RichTextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new StarMeatsPos.group3DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager();
            this.saleProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleProductTableAdapter = new StarMeatsPos.group3DataSetTableAdapters.SaleProductTableAdapter();
            this.orderProductTableAdapter = new StarMeatsPos.group3DataSetTableAdapters.OrderProductTableAdapter();
            this.orderTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.OrderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saleTableAdapter = new StarMeatsPos.StarMeatsDataSetTableAdapters.SaleTableAdapter();
            this.customerTableAdapter1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.CustomerTableAdapter();
            this.paymentTableAdapter1 = new StarMeatsPos.StarMeatsDataSetTableAdapters.PaymentTableAdapter();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(453, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(453, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Quantity";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(171, 117);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(164, 26);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQuantity.Location = new System.Drawing.Point(171, 170);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(164, 26);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.Location = new System.Drawing.Point(602, 170);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(164, 26);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(602, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 26);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonProcessSale
            // 
            this.buttonProcessSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcessSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProcessSale.Location = new System.Drawing.Point(336, 22);
            this.buttonProcessSale.Name = "buttonProcessSale";
            this.buttonProcessSale.Size = new System.Drawing.Size(130, 45);
            this.buttonProcessSale.TabIndex = 10;
            this.buttonProcessSale.Text = "Process Sale";
            this.buttonProcessSale.UseVisualStyleBackColor = true;
            this.buttonProcessSale.Visible = false;
            this.buttonProcessSale.Click += new System.EventHandler(this.buttonProcessSale_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(358, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.ColumnHeadersVisible = false;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(0, 35);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.Size = new System.Drawing.Size(1104, 46);
            this.productDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prod_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prod_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prod_Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prod_Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prod_Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prod_Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Prod_on_Promotion";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Prod_on_Promotion";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prod_Price_per_kg";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prod_Price_per_kg";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prod_Price_per_unit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prod_Price_per_unit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prod_Quantity_Available_kg";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prod_Quantity_Available_kg";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Prod_Quantity_Available_unit";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prod_Quantity_Available_unit";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Prod_sell_by";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prod_sell_by";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Reorder_level";
            this.dataGridViewTextBoxColumn9.HeaderText = "Reorder_level";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.group3DataSet;
            // 
            // group3DataSet
            // 
            this.group3DataSet.DataSetName = "group3DataSet";
            this.group3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddToOrderButton.Location = new System.Drawing.Point(36, 224);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(130, 63);
            this.AddToOrderButton.TabIndex = 14;
            this.AddToOrderButton.Text = "Add product to cart";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // SaleProductGridView
            // 
            this.SaleProductGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaleProductGridView.AutoGenerateColumns = false;
            this.SaleProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.prodIdDataGridViewTextBoxColumn,
            this.prodQuantitySoldDataGridViewTextBoxColumn,
            this.prodSoldPriceDataGridViewTextBoxColumn});
            this.SaleProductGridView.DataSource = this.saleProductBindingSource1;
            this.SaleProductGridView.Location = new System.Drawing.Point(0, 436);
            this.SaleProductGridView.Name = "SaleProductGridView";
            this.SaleProductGridView.RowHeadersWidth = 51;
            this.SaleProductGridView.RowTemplate.Height = 24;
            this.SaleProductGridView.Size = new System.Drawing.Size(797, 150);
            this.SaleProductGridView.TabIndex = 15;
            this.SaleProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleProductGridView_CellContentClick);
            this.SaleProductGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SaleProductGridView_RowHeaderMouseDoubleClick);
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "Sale_Id";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "Sale_Id";
            this.saleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodQuantitySoldDataGridViewTextBoxColumn
            // 
            this.prodQuantitySoldDataGridViewTextBoxColumn.DataPropertyName = "Prod_QuantitySold";
            this.prodQuantitySoldDataGridViewTextBoxColumn.HeaderText = "Prod_QuantitySold";
            this.prodQuantitySoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuantitySoldDataGridViewTextBoxColumn.Name = "prodQuantitySoldDataGridViewTextBoxColumn";
            this.prodQuantitySoldDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodSoldPriceDataGridViewTextBoxColumn
            // 
            this.prodSoldPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_SoldPrice";
            this.prodSoldPriceDataGridViewTextBoxColumn.HeaderText = "Prod_SoldPrice";
            this.prodSoldPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodSoldPriceDataGridViewTextBoxColumn.Name = "prodSoldPriceDataGridViewTextBoxColumn";
            this.prodSoldPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleProductBindingSource1
            // 
            this.saleProductBindingSource1.DataMember = "SaleProduct";
            this.saleProductBindingSource1.DataSource = this.group3DataSet;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(453, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total:";
            // 
            // textboxTotal
            // 
            this.textboxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxTotal.Location = new System.Drawing.Point(602, 264);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(164, 26);
            this.textboxTotal.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(453, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subtotal";
            // 
            // textboxsubtotal
            // 
            this.textboxsubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxsubtotal.Location = new System.Drawing.Point(602, 216);
            this.textboxsubtotal.Name = "textboxsubtotal";
            this.textboxsubtotal.Size = new System.Drawing.Size(164, 26);
            this.textboxsubtotal.TabIndex = 19;
            // 
            // saleGridView
            // 
            this.saleGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saleGridView.AutoGenerateColumns = false;
            this.saleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleGridView.ColumnHeadersVisible = false;
            this.saleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn1,
            this.employeeIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.saleTimeDataGridViewTextBoxColumn,
            this.saleTotalDataGridViewTextBoxColumn});
            this.saleGridView.DataSource = this.saleBindingSource;
            this.saleGridView.Location = new System.Drawing.Point(-8, 333);
            this.saleGridView.Name = "saleGridView";
            this.saleGridView.RowHeadersWidth = 51;
            this.saleGridView.RowTemplate.Height = 24;
            this.saleGridView.Size = new System.Drawing.Size(805, 71);
            this.saleGridView.TabIndex = 20;
            // 
            // saleIdDataGridViewTextBoxColumn1
            // 
            this.saleIdDataGridViewTextBoxColumn1.DataPropertyName = "Sale_Id";
            this.saleIdDataGridViewTextBoxColumn1.HeaderText = "Sale_Id";
            this.saleIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.saleIdDataGridViewTextBoxColumn1.Name = "saleIdDataGridViewTextBoxColumn1";
            this.saleIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.saleIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "Sale_Date";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Sale_Date";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleTimeDataGridViewTextBoxColumn
            // 
            this.saleTimeDataGridViewTextBoxColumn.DataPropertyName = "Sale_Time";
            this.saleTimeDataGridViewTextBoxColumn.HeaderText = "Sale_Time";
            this.saleTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleTimeDataGridViewTextBoxColumn.Name = "saleTimeDataGridViewTextBoxColumn";
            this.saleTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleTotalDataGridViewTextBoxColumn
            // 
            this.saleTotalDataGridViewTextBoxColumn.DataPropertyName = "Sale_Total";
            this.saleTotalDataGridViewTextBoxColumn.HeaderText = "Sale_Total";
            this.saleTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleTotalDataGridViewTextBoxColumn.Name = "saleTotalDataGridViewTextBoxColumn";
            this.saleTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.starMeatsDataSet;
            // 
            // starMeatsDataSet
            // 
            this.starMeatsDataSet.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(41, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Payment Type: ";
            // 
            // PaymentComboBox
            // 
            this.PaymentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentComboBox.FormattingEnabled = true;
            this.PaymentComboBox.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.PaymentComboBox.Location = new System.Drawing.Point(172, 35);
            this.PaymentComboBox.Name = "PaymentComboBox";
            this.PaymentComboBox.Size = new System.Drawing.Size(121, 28);
            this.PaymentComboBox.TabIndex = 23;
            this.PaymentComboBox.SelectedIndexChanged += new System.EventHandler(this.PaymentComboBox_SelectedIndexChanged);
            // 
            // receiptrichTextBox
            // 
            this.receiptrichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receiptrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptrichTextBox.Location = new System.Drawing.Point(795, 79);
            this.receiptrichTextBox.Name = "receiptrichTextBox";
            this.receiptrichTextBox.Size = new System.Drawing.Size(309, 603);
            this.receiptrichTextBox.TabIndex = 24;
            this.receiptrichTextBox.Text = "";
            this.receiptrichTextBox.TextChanged += new System.EventHandler(this.receiptrichTextBox_TextChanged);
            // 
            // receiptButton
            // 
            this.receiptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptButton.Location = new System.Drawing.Point(481, 23);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(130, 45);
            this.receiptButton.TabIndex = 25;
            this.receiptButton.Text = "Generate Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Products:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(9, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sale: ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(9, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sale Products:";
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataMember = "OrderProduct";
            this.orderProductBindingSource.DataSource = this.group3DataSet;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.group3DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SaleProductTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saleProductBindingSource
            // 
            this.saleProductBindingSource.DataMember = "SaleProduct";
            this.saleProductBindingSource.DataSource = this.group3DataSet;
            // 
            // saleProductTableAdapter
            // 
            this.saleProductTableAdapter.ClearBeforeFill = true;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(194, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remove item from cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(8, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 214);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ITEMS TO CART: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.CancelButton);
            this.groupBox2.Controls.Add(this.receiptButton);
            this.groupBox2.Controls.Add(this.buttonProcessSale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PaymentComboBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 590);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 80);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMPLETE SALE TRANSACTION: ";
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // CancelButton
            // 
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(628, 22);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 45);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProcessSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.receiptrichTextBox);
            this.Controls.Add(this.textboxsubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaleProductGridView);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.saleGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessSale";
            this.Text = "ManageSales";
            this.Load += new System.EventHandler(this.ProcessSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonProcessSale;
        private System.Windows.Forms.Button btnSearch;
        private group3DataSet group3DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private group3DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private group3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.DataGridView SaleProductGridView;
        private System.Windows.Forms.BindingSource saleProductBindingSource;
        private group3DataSetTableAdapters.SaleProductTableAdapter saleProductTableAdapter;
        private System.Windows.Forms.BindingSource saleProductBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxsubtotal;
        private DataGridView saleGridView;
        private StarMeatsDataSet starMeatsDataSet;
        private BindingSource saleBindingSource;
        private StarMeatsDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleTotalDataGridViewTextBoxColumn;
        private StarMeatsDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private StarMeatsDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private Label label7;
        private ComboBox PaymentComboBox;
        private RichTextBox receiptrichTextBox;
        private Button receiptButton;
        private Label label8;
        private Label label9;
        private Label label10;
        private BindingSource orderProductBindingSource;
        private group3DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private group3DataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodQuantitySoldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodSoldPriceDataGridViewTextBoxColumn;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button CancelButton;
        //  private DataGridViewCellEventHandler SaleProductGridView_CellContentClick;
    }
}