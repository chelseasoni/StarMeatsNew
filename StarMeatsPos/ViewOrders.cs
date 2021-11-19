using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace StarMeatsPos
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void buttonViewPreparedOrders_Click(object sender, EventArgs e)
        {


        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.starMeatsDataSet);
            }
            catch {
                MessageBox.Show("Butcher View - Network Related Error.");

            }

        }

        private void ButcherView_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'group3DataSet.DataTable1' table. You can move, or remove it, as needed.

            try
            {
                
                if (Login.isManager == false)
                {
                    dataTable1TableAdapter.NewOrdersEmployee(group3DataSet.DataTable1, Login.empID);
                }
                else
                {
                    this.dataTable1TableAdapter.NewOrdersAll(this.group3DataSet.DataTable1);
                }
            }
            catch
            {
                MessageBox.Show("Butcher View - Display Error");
            }

        }

        private string getProductDescription()
        {
            try
            {
                string line = "Products";
                ProductDetails.Clear();
                foreach (DataRow row in group3DataSet.DataTable2.Rows)
                {
                    line += "\r\n" + (row.ItemArray[2].ToString()) + "(x" + (row.ItemArray[3].ToString()) + ")" + "\r\n";
                }
                return line;
            }
            catch
            {
                MessageBox.Show("Butcher View - Displaying Product Description Error");
                return "";
            }
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable1BindingSource.MoveFirst();
                dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                ProductDetails.Text = getProductDescription();
            }
            catch
            {
                MessageBox.Show("Butcher View - Navigation Error");
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable1BindingSource.MovePrevious();
                dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                ProductDetails.Text = getProductDescription();
            }
            catch
            {
                MessageBox.Show("Butcher View - Navigation Error");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable1BindingSource.MoveNext();
                dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                ProductDetails.Text = getProductDescription();
            }
            catch
            {
                MessageBox.Show("Butcher View - Navigation Error");
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable1BindingSource.MoveLast();
                dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                ProductDetails.Text = getProductDescription();
            }
            catch
            {
                MessageBox.Show("Butcher View - Navigation Error");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.isManager == false)
                {
                    if (textBoxID.Text != "")
                    {
                        dataTable1TableAdapter.SearchEmployee(group3DataSet.DataTable1, Convert.ToInt32(textBoxID.Text), Login.empID);
                        if (order_IdTextBox.Text == "")
                        {
                            MessageBox.Show("No Results found");
                            textBoxID.Clear();
                            dataTable1TableAdapter.Fill(group3DataSet.DataTable1);
                        }
                        else
                        {
                            MessageBox.Show("Search complete.");
                            dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                            textBoxID.Clear();
                            ProductDetails.Text = getProductDescription();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value to begin search");
                        textBoxID.Clear();
                    }
                }
                else if (Login.isManager == true)
                {
                    if (textBoxID.Text != "")
                    {
                        dataTable1TableAdapter.SearchAll(group3DataSet.DataTable1, Convert.ToInt32(textBoxID.Text));
                        if (order_IdTextBox.Text == "")
                        {
                            MessageBox.Show("No Results found");
                            textBoxID.Clear();
                            dataTable1TableAdapter.Fill(group3DataSet.DataTable1);
                        }
                        else
                        {
                            MessageBox.Show("Search complete.");
                            textBoxID.Clear();
                            dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                            ProductDetails.Text = getProductDescription();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value to begin search");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Butcher View - Search Error, Invalid Input, Please Try Again");
                textBoxID.Clear();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.isManager == false)
                {
                    dataTable1TableAdapter.NewOrdersEmployee(group3DataSet.DataTable1, Login.empID);
                }
                else
                {
                    this.dataTable1TableAdapter.NewOrdersAll(this.group3DataSet.DataTable1);
                }
                MessageBox.Show("List of orders has been refreshed.");
            }
            catch
            {
                MessageBox.Show("Butcher View - Display Error");
            }
        }

        private void buttonViewCompletedOrders_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Prepared Order query complete");
        }

        private void buttonViewNewOrders_Click(object sender, EventArgs e)
        {

            MessageBox.Show("New Order Query Complete");
        }

        private void preparedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void preparedCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                orderProductTableAdapter.FillBy(group3DataSet.OrderProduct, Convert.ToInt32(order_IdTextBox1.Text));
            }

            catch
            {
                MessageBox.Show("Butcher View - Display Error");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                orderProductTableAdapter.FillBy(group3DataSet.OrderProduct, Convert.ToInt32(order_IdTextBox1.Text));
            }

            catch
            {
                MessageBox.Show("Butcher View - Display Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.isManager == false)
                {
                    dataTable1TableAdapter.NewOrdersEmployee(group3DataSet.DataTable1, Login.empID);
                    if (order_IdTextBox.Text == "")
                    {
                        MessageBox.Show("No New Orders");
                    }
                    else
                    {
                        MessageBox.Show("New Order Query Complete");
                        ProductDetails.Text = getProductDescription();
                    }
                }
                else if (Login.isManager == true)
                {
                    dataTable1TableAdapter.NewOrdersAll(group3DataSet.DataTable1);
                    if (order_IdTextBox.Text == "")
                    {
                        MessageBox.Show("No New Orders");
                    }
                    else
                    {
                        MessageBox.Show("New Order Query Complete");
                        ProductDetails.Text = getProductDescription();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Butcher View - New Order Display Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.isManager == false)
                {
                    dataTable1TableAdapter.PreparedOrdersEmployee(group3DataSet.DataTable1, Login.empID);
                    if (order_IdTextBox.Text == "")
                    {
                        MessageBox.Show("No Orders Completed yet");
                    }
                    else
                    {
                        MessageBox.Show("Prepared Orders Query Complete");
                        ProductDetails.Text = getProductDescription();
                    }
                }
                else if (Login.isManager == true)
                {
                    dataTable1TableAdapter.PreparedOrdersAll(group3DataSet.DataTable1);
                    if (order_IdTextBox.Text == "")
                    {
                        MessageBox.Show("No Orders Completed yet");
                    }
                    else
                    {
                        MessageBox.Show("Prepared Orders Query Complete");
                        ProductDetails.Text = getProductDescription();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Butcher View - New Order Display Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to confirm that this order is complete?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    orderTableAdapter1.UpdateQuery(false, true, false, Convert.ToInt32(order_IdTextBox1.Text), Convert.ToInt32(order_IdTextBox1.Text));
                    if (Login.isManager == false) {
                        dataTable1TableAdapter.PreparedOrdersEmployee(group3DataSet.DataTable1,Login.empID);
                        ProductDetails.Text = getProductDescription();
                        try
                        {
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress("AsheelDatharam3@gmail.com");
                            msg.To.Add("asheel.dathz@gmail.com");
                            msg.Subject = "Star Meats Order Details";
                            msg.Body = "Hi there! Your Star Meats order is ready for pick up!";
                            

                            SmtpClient smt = new SmtpClient();
                            smt.Host = "smtp.gmail.com";
                            System.Net.NetworkCredential ntwd = new NetworkCredential();
                            ntwd.UserName = "AsheelDatharam3@gmail.com"; //Your Email ID  
                            ntwd.Password = "starmeats22"; // Your Password  
                            smt.UseDefaultCredentials = true;
                            smt.Credentials = ntwd;
                            smt.Port = 587;
                            smt.EnableSsl = true;
                            smt.Send(msg);
                        }
                        catch
                        {
                            MessageBox.Show("Email was not successfully sent!,It seems that our email services are not working at the moment.Please contact us and we will resend your email");
                        }
                    }
                    else {
                        dataTable1TableAdapter.PreparedOrdersAll(group3DataSet.DataTable1);
                        ProductDetails.Text = getProductDescription();
                    }
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }
            }
            catch
            {
                MessageBox.Show("Butcher View - Update Error");

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataTable2TableAdapter.FillBy(group3DataSet.DataTable2, Convert.ToInt32(order_IdTextBox1.Text));
                ProductDetails.Text = getProductDescription();
            }
            catch {
                MessageBox.Show("Butcher View - Network Error");
            }
        }
    }
}
