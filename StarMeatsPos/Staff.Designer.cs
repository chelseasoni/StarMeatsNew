
namespace StarMeatsPos
{
    partial class Staff
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new StarMeatsPos.StarMeatsDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new StarMeatsPos.StarMeatsDataSetTableAdapters.TableAdapterManager();
            this.groupBoxStaffDetails = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.group3DataSet = new StarMeatsPos.group3DataSet();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStaffSurname = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager1 = new StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atWorkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new StarMeatsPos.DataSet1();
            this.employeeTableAdapter2 = new StarMeatsPos.DataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBoxStaffDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // starMeatsDataSet
            // 
            this.starMeatsDataSet.DataSetName = "StarMeatsDataSet";
            this.starMeatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.starMeatsDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SaleProductTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StarMeatsPos.StarMeatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBoxStaffDetails
            // 
            this.groupBoxStaffDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxStaffDetails.Controls.Add(this.textBox8);
            this.groupBoxStaffDetails.Controls.Add(this.checkBox1);
            this.groupBoxStaffDetails.Controls.Add(this.button3);
            this.groupBoxStaffDetails.Controls.Add(this.button2);
            this.groupBoxStaffDetails.Controls.Add(this.textBox6);
            this.groupBoxStaffDetails.Controls.Add(this.textBox5);
            this.groupBoxStaffDetails.Controls.Add(this.textBox4);
            this.groupBoxStaffDetails.Controls.Add(this.textBox3);
            this.groupBoxStaffDetails.Controls.Add(this.textBox2);
            this.groupBoxStaffDetails.Controls.Add(this.label8);
            this.groupBoxStaffDetails.Controls.Add(this.textBox1);
            this.groupBoxStaffDetails.Controls.Add(this.label7);
            this.groupBoxStaffDetails.Controls.Add(this.label1);
            this.groupBoxStaffDetails.Controls.Add(this.label2);
            this.groupBoxStaffDetails.Controls.Add(this.label5);
            this.groupBoxStaffDetails.Controls.Add(this.label3);
            this.groupBoxStaffDetails.Controls.Add(this.label4);
            this.groupBoxStaffDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxStaffDetails.Location = new System.Drawing.Point(253, 330);
            this.groupBoxStaffDetails.Name = "groupBoxStaffDetails";
            this.groupBoxStaffDetails.Size = new System.Drawing.Size(553, 312);
            this.groupBoxStaffDetails.TabIndex = 2;
            this.groupBoxStaffDetails.TabStop = false;
            this.groupBoxStaffDetails.Text = "Staff Details";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(385, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Reload Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(385, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Password", true));
            this.textBox7.Location = new System.Drawing.Point(860, 211);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 23);
            this.textBox7.TabIndex = 9;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.group3DataSet;
            // 
            // group3DataSet
            // 
            this.group3DataSet.DataSetName = "group3DataSet";
            this.group3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Email", true));
            this.textBox6.Location = new System.Drawing.Point(376, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 23);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Contact", true));
            this.textBox5.Location = new System.Drawing.Point(91, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 23);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Role", true));
            this.textBox4.Location = new System.Drawing.Point(376, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 23);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Name", true));
            this.textBox3.Location = new System.Drawing.Point(91, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Surname", true));
            this.textBox2.Location = new System.Drawing.Point(90, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(277, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Employee_Id", true));
            this.textBox1.Location = new System.Drawing.Point(91, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(304, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(304, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(19, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(19, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(19, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFirst.Location = new System.Drawing.Point(210, 275);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(118, 38);
            this.buttonFirst.TabIndex = 5;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPrevious.Location = new System.Drawing.Point(380, 275);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(117, 38);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.Location = new System.Drawing.Point(548, 275);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(118, 38);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLast.Location = new System.Drawing.Point(712, 275);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(118, 38);
            this.buttonLast.TabIndex = 8;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch.Location = new System.Drawing.Point(102, 426);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 33);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStaffName.Location = new System.Drawing.Point(102, 344);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(126, 23);
            this.textBoxStaffName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(21, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(21, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Surname";
            // 
            // textBoxStaffSurname
            // 
            this.textBoxStaffSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStaffSurname.Location = new System.Drawing.Point(102, 386);
            this.textBoxStaffSurname.Name = "textBoxStaffSurname";
            this.textBoxStaffSurname.Size = new System.Drawing.Size(126, 23);
            this.textBoxStaffSurname.TabIndex = 16;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter1;
            this.tableAdapterManager1.OrderProductTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PaymentTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.SaleProductTableAdapter = null;
            this.tableAdapterManager1.SaleTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = StarMeatsPos.group3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeeDataGridView.DataSource = this.employeeBindingSource1;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(1104, 220);
            this.employeeDataGridView.TabIndex = 16;
            this.employeeDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Employee_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee_Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee_Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Employee_Contact";
            this.dataGridViewTextBoxColumn4.HeaderText = "Employee_Contact";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Employee_Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employee_Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Employee_Role";
            this.dataGridViewTextBoxColumn6.HeaderText = "Employee_Role";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(55, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Clear Search Fields";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(824, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 312);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Staff";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(5, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 36);
            this.button5.TabIndex = 18;
            this.button5.Text = "Enter New Employee Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeeContactDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeeRoleDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.atWorkDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1104, 234);
            this.dataGridView1.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource2, "AtWork", true));
            this.checkBox1.Location = new System.Drawing.Point(22, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "At Work";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(376, 159);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 23);
            this.textBox8.TabIndex = 21;
            this.textBox8.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            // 
            // employeeContactDataGridViewTextBoxColumn
            // 
            this.employeeContactDataGridViewTextBoxColumn.DataPropertyName = "Employee_Contact";
            this.employeeContactDataGridViewTextBoxColumn.HeaderText = "Employee_Contact";
            this.employeeContactDataGridViewTextBoxColumn.Name = "employeeContactDataGridViewTextBoxColumn";
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "Employee_Email";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "Employee_Email";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            // 
            // employeeRoleDataGridViewTextBoxColumn
            // 
            this.employeeRoleDataGridViewTextBoxColumn.DataPropertyName = "Employee_Role";
            this.employeeRoleDataGridViewTextBoxColumn.HeaderText = "Employee_Role";
            this.employeeRoleDataGridViewTextBoxColumn.Name = "employeeRoleDataGridViewTextBoxColumn";
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "Employee_Password";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "Employee_Password";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            // 
            // atWorkDataGridViewCheckBoxColumn
            // 
            this.atWorkDataGridViewCheckBoxColumn.DataPropertyName = "AtWork";
            this.atWorkDataGridViewCheckBoxColumn.HeaderText = "AtWork";
            this.atWorkDataGridViewCheckBoxColumn.Name = "atWorkDataGridViewCheckBoxColumn";
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.textBoxStaffSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxStaffName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.groupBoxStaffDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starMeatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBoxStaffDetails.ResumeLayout(false);
            this.groupBoxStaffDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StarMeatsDataSet starMeatsDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private StarMeatsDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private StarMeatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxStaffDetails;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStaffSurname;
        private group3DataSet group3DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private group3DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private group3DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atWorkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox8;
    }
}