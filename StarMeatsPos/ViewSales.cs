using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMeatsPos
{
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
        }

        private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.starMeatsDataSet);

        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            saleDataGridView.ForeColor = Color.Black;
            this.saleTableAdapter.Fill(this.starMeatsDataSet.Sale);
            // TODO: This line of code loads data into the 'group3DataSet.Sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter1.Fill(this.group3DataSet.Sale);
            // TODO: This line of code loads data into the 'starMeatsDataSet.Sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter.Fill(this.starMeatsDataSet.Sale);

        }

        private void textBoxCustomerContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustomerSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            textBoxSaleID.Clear();
            textBoxCustomerID.Clear();
            textBoxEmployeeID.Clear();
            textBoxDate.Clear();
            textTime.Clear();
            textBoxTotal.Clear();
            saleTableAdapter.FillBy(starMeatsDataSet.Sale, Convert.ToInt32(textBoxID.Text));
            DataGridViewRow row = this.saleDataGridView.CurrentRow;
           
            if (saleDataGridView.Rows.Count == 1)
            {
                MessageBox.Show("Sale does not exist for that Sale ID.");
            }

            else
            {
                
                textBoxSaleID.Text = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                textBoxCustomerID.Text = row.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                textBoxEmployeeID.Text = row.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                textBoxDate.Text = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                textTime.Text = row.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                textBoxTotal.Text = "R" + row.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            }
{}
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void saleDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
            DataGridViewRow row2 = this.saleDataGridView.CurrentRow;
         
            textBoxSaleID.Text = row2.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            textBoxCustomerID.Text = row2.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            textBoxEmployeeID.Text = row2.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            textBoxDate.Text = row2.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            textTime.Text = row2.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            textBoxTotal.Text = "R" + row2.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.saleBindingSource2.MoveLast();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.saleBindingSource2.MoveNext();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.saleBindingSource2.MovePrevious();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.saleBindingSource2.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saleTableAdapter.Fill(this.starMeatsDataSet.Sale);
        }
    }
}
