using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace StarMeatsPos
{
    public partial class ProcessOrder : Form
    {

        public double amountPaid = 0;
        public double Total = 0;
        public double amountpaid = 0;
        public double change = 0;
        public ProcessOrder()
        {
            InitializeComponent();
            
        }
       

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            double priceperunit = 0;
            int q = 0;
                


            DialogResult dr = MessageBox.Show("Would you like to process this transaction", "Process transaction", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Cash")
                    {

                        amountpaid = Convert.ToDouble(Interaction.InputBox("Amount Due " + String.Format("{0:C}", Total) + " | Enter paid amount:"));
                        if (amountpaid < Total)
                        {
                            MessageBox.Show("Invalid. Please enter amount greater than " + String.Format("{0:C}", Total));
                            return;
                        }
                        change = amountpaid - Total;
                        MessageBox.Show("Change: " + String.Format("{0:C}", change));
                    }

                    //DataGridViewRow k = dataGridView1.CurrentRow;

                    dataGridView2.Show();
                    saleTableAdapter1.Insert(Login.EmployeeID, int.Parse(textBox2.Text), DateAndTime.Now, DateAndTime.Now.TimeOfDay, decimal.Parse(textBox1.Text));
                    saleTableAdapter1.Fill(group3DataSet.Sale);
                    saleBindingSource.DataSource = saleTableAdapter1.GetDataBy3(Convert.ToInt32(group3DataSet.Sale.Rows[group3DataSet.Sale.Rows.Count - 1].ItemArray[0]));
                    dataGridView2.Refresh();
                    paymentTableAdapter.Insert(Convert.ToInt32(group3DataSet.Sale.Rows[group3DataSet.Sale.Rows.Count - 1].ItemArray[0]), "Cash");
                    MessageBox.Show("Sale successful");
                    richTextBox1.AppendText(Environment.NewLine + "--------------------STAR MEATS-----------------------");
                    richTextBox1.AppendText(Environment.NewLine + DateAndTime.Now.ToString());
                    richTextBox1.AppendText(Environment.NewLine + "Cashier: " + Login.EmpName);
                    richTextBox1.AppendText(Environment.NewLine + "------------------------------------------------------------");
                    richTextBox1.AppendText(Environment.NewLine);
                    for (int i = 0; i < group3DataSet.DataTable3.Rows.Count; i++) {
                        priceperunit = Convert.ToDouble(group3DataSet.DataTable3.Rows[i].ItemArray[3]);
                        q = Convert.ToInt16(group3DataSet.DataTable3.Rows[i].ItemArray[2]);
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                        richTextBox1.AppendText(group3DataSet.DataTable3.Rows[i].ItemArray[4]+ " ("+ group3DataSet.DataTable3.Rows[i].ItemArray[2]+"@" +"R:"+ group3DataSet.DataTable3.Rows[i].ItemArray[3]+") R"+( priceperunit*q )+ Environment.NewLine);
                    }
                    if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Cash")
                    {

                        //edit receipt 

                        richTextBox1.AppendText(Environment.NewLine + "----------------------end-of-sale------------------------");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "#Cash#");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "------------------------------------------------------------");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "Total:     R" + textBox1.Text );
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "Cash:      R" + amountPaid.ToString("0.##")); ;
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;


                        richTextBox1.AppendText(Environment.NewLine + "Change:    R" + (amountPaid-double.Parse(textBox1.Text)).ToString());
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;






                    }
                    if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Card")
                    {

                        //edit receipt 

                        richTextBox1.AppendText(Environment.NewLine + "----------------------end-of-sale------------------------");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "#Card#");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "------------------------------------------------------------");
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "Total:     R" + textBox1.Text);
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

                        richTextBox1.AppendText(Environment.NewLine + "Card:      R" + textBox1.Text  ) ;
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;


                        //richTextBox1.AppendText(Environment.NewLine + "Change:    R" + (amountPaid - double.Parse(textBox1.Text)).ToString());
                        //richTextBox1.SelectionAlignment = HorizontalAlignment.Right;




                        orderTableAdapter.UpdateQuery(true,false,false,int.Parse(group3DataSet.OrderProduct.Rows[0].ItemArray[0].ToString()), int.Parse(group3DataSet.OrderProduct.Rows[0].ItemArray[0].ToString()) );

                    }
                    button3.Show();
                    button2.Hide();

                }
                catch (Exception e12)
                {
                    MessageBox.Show("Sale unsuccessful, please re enter details");
                    button3.PerformClick();
                }
            }
            else
            {

                MessageBox.Show("Transaction cancled");
                button3.PerformClick();
            }            
            


        }


        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            dataGridView2.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            // TODO: This line of code loads data into the 'group3DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.group3DataSet.Payment);
            // TODO: This line of code loads data into the 'group3DataSet.OrderProduct' table. You can move, or remove it, as needed.
            //orderProductTableAdapter.Fill(this.group3DataSet.OrderProduct);
            dgvOrder.ForeColor = Color.Black;
            
            // TODO: This line of code loads data into the 'group3DataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.CompletedOrders(this.group3DataSet.Order);

        }

       

        private void gbxOrderDetails_Enter(object sender, EventArgs e)
        {

        }
        private double getTotal()
        {
            double sum = 0;
            foreach (DataRow row in group3DataSet.OrderProduct.Rows)
            {
                sum += Convert.ToDouble(row.ItemArray[2].ToString()) * Convert.ToDouble(row.ItemArray[3].ToString());
            }
            return sum;
        }

        private void dgvOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dgvOrder.CurrentRow.Cells[1].Value.ToString();

            dataGridView1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            comboBox1.Visible = true;

            this.orderProductTableAdapter.FillByorderid(this.group3DataSet.OrderProduct, Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
            dataTable3TableAdapter1.Fillorderproduct(group3DataSet.DataTable3, Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
            orderProductBindingSource.DataSource = orderProductTableAdapter.GetDataBy1(Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
            dataGridView2.Refresh();
            dataGridView1.Refresh();
            textBox1.Text = getTotal().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
           
            try
            {
                int n = int.Parse(textBox2.Text);
                orderTableAdapter.FillBycustomerid(group3DataSet.Order, n);
                label5.Visible = true;
                textBox3.Visible = true;
                button5.Visible = true;
            }
            catch (Exception e14) {
                MessageBox.Show("Invalid customer id");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((comboBox1.GetItemText(comboBox1.SelectedItem) == "Card") || (comboBox1.GetItemText(comboBox1.SelectedItem) == "Cash"))
            {

                button2.Visible = true;
                //button3.Visible = true;
                //button4.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                
            
            
            try
            {
                int n = int.Parse(textBox3.Text);
                orderTableAdapter.FillByORDERID(group3DataSet.Order,n);
            }
            catch (Exception e14)
            {
                MessageBox.Show("Invalid order id");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            textBox2.Clear();
            try
            {
                orderTableAdapter.Fill(group3DataSet.Order);
                orderProductTableAdapter.Fill(group3DataSet.OrderProduct);
            }
            catch (Exception e44) {
                MessageBox.Show("Something unexpected has occured, data cannot be recovered please restart the transaction");
            }
            button2.Show();
            button3.Visible = true;
            //button4.Visible = false;
            comboBox1.SelectedIndex = -1;
            textBox1.Text = " ";

            dataGridView2.Hide();

            dataGridView1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String n = textBox4.Text;
                orderTableAdapter.FillBy(group3DataSet.Order,n);
            }
            catch (Exception e14)
            {
                MessageBox.Show("Invalid Customer Name");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String n = textBox4.Text;
                orderTableAdapter.FillBy(group3DataSet.Order, n);
            }
            catch (Exception e14)
            {
                dgvOrder.Rows.Clear();
            }
        }
    }
}
