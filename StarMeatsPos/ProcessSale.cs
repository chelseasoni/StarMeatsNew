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
    public partial class ProcessSale : Form


    {
        DateTime dt = DateTime.Now;
        decimal decimalprice;
        int saleid;
        int removeitemscount = 0;
        TimeSpan dt2 = DateTime.Now.TimeOfDay;  //EDIT
        decimal Total = 0, amountpaid, change;
        string[] recieptarray = new string[100]; //EDIT
        int counter = 0;
        string custid = "";
        int o_ID = 0;

        string empname; //EDIT

        public ProcessSale()

        {
            InitializeComponent();

            //        try
            //      {
            //        this.saleTableAdapter.DeleteEmptySales();
            //  }
            //catch
            //  {
            //    MessageBox.Show("A previous sale may not have been entered in correctly. Please contact IT technican");
            //}
            int employeeID = Login.EmployeeID;
            int empid = employeeID;




            //is there a customer number for this sale

            custid = (Interaction.InputBox("Enter Customer ID: "));

            empname = Login.EmpName;

            //create new order


            if (custid.ToUpper() == "NEW")
            {
                Form redirect = new Customers();
                redirect.Show();


            }


            //if there is a customer associated 
            try
            {
                int custid1 = Convert.ToInt32(custid);
                saleTableAdapter.Insert(empid, custid1, dt, dt2, 0);

            }
            catch
            {
                //if no customer id was entered
                if (custid == "")
                {
                    saleTableAdapter.Insert(empid, null, dt, dt2, 0); ;

                }

                else
                {
                    MessageBox.Show("Customer does not exist. Try again");

                }
            }

            //show new sale
            this.saleTableAdapter.FillBy4(this.starMeatsDataSet.Sale, dt);

            //this.saleTableAdapter.FillBy2(this.starMeatsDataSet.Sale, dt, dt2.ToString());

            //       DataGridViewRow r2 = this.saleGridView.CurrentRow;
            //     string saleID = (r2.Cells["saleIdDataGridViewTextBoxColumn1"].Value.ToString());

            //   receiptrichTextBox.AppendText(Environment.NewLine + "--------------------STAR MEATS-----------------------");
            // receiptrichTextBox.AppendText(Environment.NewLine + dt.ToString());
            //   receiptrichTextBox.AppendText(Environment.NewLine + "Sale ID: " + saleID.ToString());
            //  receiptrichTextBox.AppendText(Environment.NewLine + "Cashier: " + empname);
            // receiptrichTextBox.AppendText(Environment.NewLine + "------------------------------------------------------------");






        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group3DataSet.OrderProduct' table. You can move, or remove it, as needed.
            ///this.orderProductTableAdapter.Fill(this.group3DataSet.OrderProduct);
            this.orderTableAdapter1.Fill(this.group3DataSet.Order);
            // TODO: This line of code loads data into the 'starMeatsDataSet.Sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter.Fill(this.starMeatsDataSet.Sale);
            // TODO: This line of code loads data into the 'group3DataSet.SaleProduct' table. You can move, or remove it, as needed.
            //this.saleProductTableAdapter.Fill(this.group3DataSet.SaleProduct);
            // TODO: This line of code loads data into the 'group3DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.group3DataSet.Product);
            textBoxID.Focus();







            void productBindingNavigatorSaveItem_Click(object ender, EventArgs ee)
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.group3DataSet);

            }



            void AddToOrderButton_Click(object ssender, EventArgs ee)
            {

            }



            void SaleProductGridView_CellContentClick(object ssender, DataGridViewCellEventArgs ee)
            {

            }

            void label5_Click(object ssender, EventArgs ee)
            {

            }

            void label5_Click_1(object ssender, EventArgs ee)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            {
                decimalprice = 0;
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
                productTableAdapter.FillBy(group3DataSet.Product, Convert.ToInt32(textBoxID.Text));
                DataGridViewRow r = this.productDataGridView.CurrentRow;

                textBoxID.Clear();
                if (productDataGridView.Rows.Count == 1)
                {
                    MessageBox.Show("No such product exists.");
                    textBoxID.Focus();
                }




                else
                {
                    textBoxID.Text = r.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                    textBoxName.Text = r.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                    //price depending on type


                    string s = r.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    string s2 = r.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    //EDIT3
                    string stringprice = "";




                    if (s2 == "")
                    {

                        decimalprice = Convert.ToDecimal(r.Cells["dataGridViewTextBoxColumn4"].Value);
                        stringprice = String.Format("{0:C}", decimalprice);

                    }
                    if (s == "")
                    {


                        decimalprice = Convert.ToDecimal(r.Cells["dataGridViewTextBoxColumn5"].Value);
                        stringprice = String.Format("{0:C}", decimalprice);
                    }

                    textBoxPrice.Text = stringprice;

                    textBoxQuantity.Focus();







                }




            }


        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            {
                if (textBoxID.Text == "")
                {
                    MessageBox.Show("Select product to add to sale.");
                    textBoxQuantity.Text = "";
                    return;
                }

                string t = "";
                DataGridViewRow r2 = this.saleGridView.CurrentRow;
                saleid = Convert.ToInt32(r2.Cells["saleIdDataGridViewTextBoxColumn1"].Value);



                //different processing depending on whether it's butchery meat or not
                DataGridViewRow r = this.productDataGridView.CurrentRow;
                String descrip = r.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                string category = r.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                decimal d_quantity;
                int i_quantity = 0;
                decimal subtotal = 0;

                //if it is butchery meat, we work with decimals
                String s = "";
                try
                {
                    s = textBoxQuantity.Text;
                    d_quantity = Convert.ToDecimal(s);
                    i_quantity = Convert.ToInt32(d_quantity);
                }
                catch
                {
                    MessageBox.Show("Please enter valid quantity");
                    textBoxQuantity.Clear();
                    textBoxQuantity.Focus();
                    return;
                }

                //if it is a meat item
                if (category == "Butchery Meat")
                {


                    subtotal = (d_quantity * (decimalprice));
                    textboxsubtotal.Text = String.Format("{0:C}", subtotal);
                    Total += subtotal;
                    textboxTotal.Text = String.Format("{0:C}", Total);
                    //update quantity
                    this.productTableAdapter.UpdateQuantity((decimal)r.Cells["dataGridViewTextBoxColumn6"].Value - d_quantity, null, Convert.ToInt32(textBoxID.Text), Convert.ToInt32(textBoxID.Text));
                    productTableAdapter.FillBy(group3DataSet.Product, Convert.ToInt32(textBoxID.Text));


                }

                //if its not butchery meat
                else


                {
                    //error handling, value must be an int
                    if (d_quantity != i_quantity)
                    {

                        MessageBox.Show("Please enter valid quantity. Whole numbers only.");
                        textBoxQuantity.Clear();
                        textBoxQuantity.Focus();

                    }
                    //if the value is an int

                    else
                    {
                        subtotal = (i_quantity * ((decimalprice)));
                        //MessageBox.Show(subtotal.ToString());
                        textboxsubtotal.Text = String.Format("{0:C}", subtotal);
                        Total = Total + subtotal;
                        textboxTotal.Text = String.Format("{0:C}", Total);
                        //updatequantity
                        this.productTableAdapter.UpdateQuantity(null, (decimal)r.Cells["dataGridViewTextBoxColumn7"].Value - i_quantity, Convert.ToInt32(textBoxID.Text), Convert.ToInt32(textBoxID.Text));
                        productTableAdapter.FillBy(group3DataSet.Product, Convert.ToInt32(textBoxID.Text));


                    }




                }



                //add product to saleproduct table
                saleProductTableAdapter.Insert(saleid, Convert.ToInt32(textBoxID.Text), d_quantity, subtotal);
                // this.saleProductTableAdapter.Insert(saleid, Convert.ToInt32(r.Cells["dataGridViewTextBoxColumn1"].Value), d_quantity, subtotal);
                this.saleProductTableAdapter.FillBy(this.group3DataSet.SaleProduct, saleid);



                //update reciept 
                //   receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;
                // receiptrichTextBox.AppendText(descrip.Substring(0, 15) + " (" + d_quantity.ToString("####.##") + " @ R" + textBoxPrice.Text.ToString().Substring(0, 6) + ")");

                // receiptrichTextBox.AppendText(" R" + subtotal.ToString("####.##") + Environment.NewLine);

                //update array with products
                //EDIT3
                try
                {
                    t = descrip.Substring(0, 8) + " " + " (" + d_quantity.ToString("####.##") + " @ " + String.Format("{0:C}", Convert.ToDecimal(textBoxPrice.Text)) + ")" + String.Format("{0:C}", subtotal);
                    recieptarray[counter] = t;
                    counter = counter + 1;
                }
                catch
                {
                    t = descrip.Substring(0, 8) + " (" + d_quantity.ToString() + "@" + textBoxPrice.Text.ToString() + ")  " + String.Format("{0:C}", subtotal);
                    recieptarray[counter] = t;
                    counter = counter + 1;
                }

                //reset 
                textBoxID.Clear();
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
                textBoxID.Focus();

            }



        }
        private void buttonProcessSale_Click(object sender, EventArgs e)
        {


            //confirmation
            DialogResult result1 = MessageBox.Show("Do you want to confirm?", "Confirm", MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                //payment type


                if (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Cash")
                {
                    {

                        try
                        {
                            //calculate and display change
                            amountpaid = Convert.ToDecimal(Interaction.InputBox("Amount Due " + String.Format("{0:C}", Total) + " | Enter paid amount:"));
                            if (amountpaid < Total)
                            {
                                MessageBox.Show("Invalid. Please enter amount greater than " + String.Format("{0:C}", Total));
                                return;
                            }
                            change = amountpaid - Total;
                            MessageBox.Show("Change: " + String.Format("{0:C}", change));

                            //post to payment
                            paymentTableAdapter1.Insert(saleid, "Cash");

                            //confirmation message
                            MessageBox.Show("Payment Sucessful");



                            //update sale total on sale table
                            this.saleTableAdapter.UpdateTotal(Total, saleid, saleid);
                            this.saleTableAdapter.FillBy1(this.starMeatsDataSet.Sale, dt);


                            //EDIT3
                            receiptButton.Visible = true;
                            AddToOrderButton.Visible = false;
                            button1.Visible = false;
                            /* if (poGridView.Visible)
                             {
                                 // this.orderTableAdapter1.UpdateQuery(true, false, o_ID, o_ID);

                             }*/



                        }

                        catch
                        {
                            DataGridViewRow r7 = this.saleGridView.CurrentRow;
                            saleProductTableAdapter.DeleteQuery((int)r7.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
                            saleTableAdapter.DeleteQuery((int)r7.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
                            MessageBox.Show("Sale successfully cancelled.");
                            this.saleTableAdapter.FillBy(this.starMeatsDataSet.Sale, 0);
                            this.saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, 0);
                            MessageBox.Show("Sale cancelled.");
                        }
                    }



                }

                if (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Card")
                //if card 
                {
                    //post to payment
                    MessageBox.Show("Amount Due: " + String.Format("{0:C}", Total));
                    paymentTableAdapter1.Insert(saleid, "Card");

                    //confirmation message
                    MessageBox.Show("Payment Sucessful");

                    //update sale total on sale table
                    this.saleTableAdapter.UpdateTotal(Total, saleid, saleid);
                    this.saleTableAdapter.FillBy1(this.starMeatsDataSet.Sale, dt);


                    //EDIT3
                    receiptButton.Visible = true;
                    AddToOrderButton.Visible = false;
                    button1.Visible = false;


                    /*if (poGridView.Visible)
                    {
                        // this.orderTableAdapter1.UpdateQuery(true, false, o_ID, o_ID);
                    }*/
                }

                if (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "")
                {
                    MessageBox.Show("Select Payment Option");
                    PaymentComboBox.Focus();
                }
            }

            if (result1 == DialogResult.Cancel)
            {
                DataGridViewRow r5 = this.saleGridView.CurrentRow;
                saleProductTableAdapter.DeleteQuery((int)r5.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
                saleTableAdapter.DeleteQuery((int)r5.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
                MessageBox.Show("Sale successfully cancelled.");
                this.saleTableAdapter.FillBy(this.starMeatsDataSet.Sale, 0);
                this.saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, 0);
                MessageBox.Show("Sale cancelled.");
            }

        }

        /* private void btnPOrd_Click(object sender, EventArgs e)
         {
             string ordid = (Interaction.InputBox("Enter Order ID: "));
             int o_ID = Convert.ToInt32(ordid); ;
             int ProdID = 0;
             double Prod_Quant;
             double pSoldPrice;
             double PricePerU;
             string PName = "";
             decimal Tprice = 0;

             string sc = "Data Source=146.230.177.46\\ist3;Initial Catalog=group3;User ID=group3;Password=r732k";
             SqlConnection sqlconnect = new SqlConnection(sc);
             string FindOrd = "select * from [Order] Where Order_Id ='" + o_ID + "' and prepared= '" + true + "'";
             SqlDataAdapter sda2 = new SqlDataAdapter(FindOrd, sqlconnect);
             DataTable dtb2 = new DataTable();
             sda2.Fill(dtb2);

             if (dtb2.Rows.Count == 1)
             {
                 //find the order id in ordprod

                 string FindOrders = "select * from OrderProduct Where Order_Id ='" + o_ID + "'";
                 SqlDataAdapter sda3 = new SqlDataAdapter(FindOrders, sqlconnect);
                 DataTable dtb3 = new DataTable();
                 sda3.Fill(dtb3);
                 if (dtb3.Rows.Count >= 1)
                 {
                     string ExtractOrderDetails = "select * from OrderProduct Where Order_Id ='" + o_ID + "'";
                     SqlCommand cmd3 = new SqlCommand(ExtractOrderDetails, sqlconnect);

                     SqlDataReader pID = null;
                     sqlconnect.Open();
                     pID = cmd3.ExecuteReader();

                     while (pID.Read())
                     {
                         ProdID = Convert.ToInt32(pID["Prod_Id"]);
                         Prod_Quant = Convert.ToDouble(pID["OProd_Quantity"]);
                         pSoldPrice = Convert.ToDouble(pID["OProd_SoldPrice"]);
                         Tprice = Tprice + Convert.ToDecimal(pSoldPrice);

                         PricePerU = pSoldPrice / Prod_Quant;

                         SqlConnection sqlconnect2 = new SqlConnection(sc);
                         string ExtractPName = "select * from Product Where Prod_Id ='" + ProdID + "'";
                         SqlCommand cmd4 = new SqlCommand(ExtractPName, sqlconnect2);

                         SqlDataReader prodID = null;
                         sqlconnect2.Open();
                         prodID = cmd4.ExecuteReader();

                         while (prodID.Read())
                         {
                             PName = prodID["Prod_Description"].ToString();

                         }
                         sqlconnect2.Close();



                         this.orderProductTableAdapter.FillBy(this.group3DataSet.OrderProduct, o_ID);

                         poGridView.Visible = true;


                         DataGridViewRow extractsaleid = this.saleGridView.CurrentRow;
                         saleid = Convert.ToInt32(extractsaleid.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
                         saleProductTableAdapter.Insert(saleid, ProdID, Convert.ToDecimal(Prod_Quant), Convert.ToDecimal(pSoldPrice));

                         receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;
                         receiptrichTextBox.AppendText(PName.Substring(0, 15) + " (" + Prod_Quant.ToString("####.##") + " @ R" + PricePerU.ToString() + ")");
                         receiptrichTextBox.AppendText(" R" + pSoldPrice.ToString("####.##") + Environment.NewLine);

                     }

                     sqlconnect.Close();
                 }

                 Total = Tprice;
                 textboxTotal.Text = Total.ToString();
                 poGridView.Visible = true;
                 saleGridView.Visible = false;
             }
             else
                 MessageBox.Show("there is no order prepared for this customer.");
         }*/

        private void buttonRemoveFromSale_Click(object sender, EventArgs e)

        {


        }

        private void SaleProductGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }

        private void SaleProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textboxsubtotal.Text = "";
            decimal quanity = 0;
            int prodtoremove = 0;
            string prodname = "";
            string price = "";
            int amounttoremove = 0;
            DataGridViewRow r4;
            DataGridViewRow productrow = null;
            int stop = 0;
            decimal itemprice = 0;
            string s_quantity = "";
            decimal d_price = 0;
            try
            {
                prodtoremove = Int32.Parse((Interaction.InputBox("Product ID to be removed: ")));

            }
            catch
            {
                MessageBox.Show("Please enter in valid number.");


                return;

            }

            /// try
            //{

            this.saleProductTableAdapter.FillByRemove(this.group3DataSet.SaleProduct, saleid, prodtoremove);
            r4 = this.SaleProductGridView.CurrentRow;//EDIT5

            if (SaleProductGridView.Rows.Count == 1)
            {
                //EDIT3
                MessageBox.Show("No such product exists in sale.");
                saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);


                return;
            }

            else //if the product does exist in the sale
            {
                //EDIT3
                try
                {
                    this.productTableAdapter.FillBy(this.group3DataSet.Product, prodtoremove);
                    productrow = productDataGridView.CurrentRow;
                }
                catch
                {
                    MessageBox.Show("An error has occured.");
                    saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
                    this.productTableAdapter.Fill(this.group3DataSet.Product);

                    return;
                }

                try
                {
                    quanity = Convert.ToDecimal(r4.Cells["prodQuantitySoldDataGridViewTextBoxColumn"].Value);//EDIT5
                }
                catch
                {
                    MessageBox.Show("Product does not exist in sale.");
                    saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
                    this.productTableAdapter.Fill(this.group3DataSet.Product);

                    return;
                    //return;
                }
                try
                {
                    itemprice = Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn5"].Value);
                }
                catch
                {
                    MessageBox.Show("Cannot remove butchery items from sale. Please contact manager");
                    saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
                    this.productTableAdapter.Fill(this.group3DataSet.Product);

                    return;
                }


                if (quanity >= 2)//if there are more than 2 items in the sale
                {
                    try
                    {
                        amounttoremove = Int32.Parse((Interaction.InputBox(quanity.ToString() + " items in sale. How many to remove? ")));
                    }
                    catch //if they enter a decimal and are trying to remove a meat item
                    {
                        MessageBox.Show("An error has occured.");
                        saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
                        this.productTableAdapter.Fill(this.group3DataSet.Product);

                        return;

                    }
                    if (amounttoremove == 0)
                    {
                        MessageBox.Show("Please enter in a valid number.");

                    }
                    if (amounttoremove < quanity)
                    {



                        //saleProductTableAdapter.UpdateQuantity(amounttoremove, saleid, prodtoremove, prodtoremove, saleid);
                        saleProductTableAdapter.UpdateQuery2(quanity - amounttoremove, Convert.ToDecimal(itemprice * (quanity - amounttoremove)), saleid, prodtoremove, prodtoremove, saleid);


                        //EDIT3
                        Total = Total - (itemprice * (Convert.ToDecimal(amounttoremove)));
                        textboxTotal.Text = String.Format("{0:C}", Total);
                        recieptarray[counter] = "REMOVED " + "(" + productrow.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Substring(0, 8) + " x " + amounttoremove.ToString() + ")";
                        counter++;

                        saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);

                        //update product quantity
                        decimal newprodquantity = (Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn7"].Value) + Convert.ToDecimal(amounttoremove));
                        //  productTableAdapter.DecreaseQuantity(newprodquantity, prodtoremove, prodtoremove);
                        this.productTableAdapter.UpdateQuantity(null, newprodquantity, prodtoremove, prodtoremove);
                    }
                    if (amounttoremove == quanity)
                    {
                        d_price = Convert.ToDecimal(r4.Cells["prodSoldPriceDataGridViewTextBoxColumn"].Value);
                        saleProductTableAdapter.DeleteEntireItem(saleid, prodtoremove);
                        Total = Total - (itemprice * (Convert.ToDecimal(amounttoremove)));
                        textboxTotal.Text = String.Format("{0:C}", Total);
                        recieptarray[counter] = "REMOVED " + "(" + productrow.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Substring(0, 8) + " x " + amounttoremove.ToString() + ")";
                        counter++;
                        removeitemscount++;
                        //update product quantity
                        decimal j = Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn7"].Value) + (decimal)amounttoremove;
                        this.productTableAdapter.UpdateQuantity(null, j, prodtoremove, prodtoremove);
                        //  productTableAdapter.DecreaseQuantity(Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn5"].Value) + Convert.ToDecimal(amounttoremove), prodtoremove, prodtoremove);
                    }
                    if (amounttoremove > quanity)
                    {
                        MessageBox.Show("Invalid quantity. Enter amount less than " + quanity.ToString());
                        saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
                        this.productTableAdapter.Fill(this.group3DataSet.Product);

                    }
                }
                else//if there's only one item in the sale
                {

                    // productTableAdapter.DecreaseQuantity(Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn5"].Value) + 1, prodtoremove, prodtoremove);

                    this.saleProductTableAdapter.DeleteEntireItem(saleid, prodtoremove);
                    Total -= itemprice;
                    textboxTotal.Text = String.Format("{0:C}", Total);
                    recieptarray[counter] = "REMOVED " + "(" + productrow.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Substring(0, 8) + " x 1)";
                    counter++;

                    //update quantity available
                    decimal k = Convert.ToDecimal(productrow.Cells["dataGridViewTextBoxColumn7"].Value) + 1;
                    this.productTableAdapter.UpdateQuantity(null, k, prodtoremove, prodtoremove);
                }
            }





            //  }
            //    catch
            //      {
            //            MessageBox.Show("Remove successful.");
            //          }
            //update product quantity
            saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, saleid);
            this.productTableAdapter.Fill(this.group3DataSet.Product);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Card") || (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Cash"))
            {

                buttonProcessSale.Visible = true;
                CancelButton.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow r5 = this.saleGridView.CurrentRow;
            saleProductTableAdapter.DeleteQuery((int)r5.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
            saleTableAdapter.DeleteQuery((int)r5.Cells["saleIdDataGridViewTextBoxColumn1"].Value);
            MessageBox.Show("Sale successfully cancelled.");
            this.saleTableAdapter.FillBy(this.starMeatsDataSet.Sale, 0);
            this.saleProductTableAdapter.FillBy(group3DataSet.SaleProduct, 0);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void receiptrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiptrichTextBox.Visible = true;
            //headers
            receiptrichTextBox.AppendText(Environment.NewLine + "--------------------STAR MEATS-----------------------");
            receiptrichTextBox.AppendText(Environment.NewLine + dt.ToString());
            //   receiptrichTextBox.AppendText(Environment.NewLine + "Sale ID: " + saleID.ToString());
            receiptrichTextBox.AppendText(Environment.NewLine + "Cashier: " + empname);
            receiptrichTextBox.AppendText(Environment.NewLine + "------------------------------------------------------------");
            //print items
            for (int l = 0; l < counter; l++)
            {
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;
                receiptrichTextBox.AppendText(recieptarray[l] + Environment.NewLine);
            }


            //removed items


            if (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Cash")
            {

                //edit receipt 

                receiptrichTextBox.AppendText(Environment.NewLine + "----------------------end-of-sale------------------------");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;

                receiptrichTextBox.AppendText(Environment.NewLine + "#Cash#");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;

                receiptrichTextBox.AppendText(Environment.NewLine + "------------------------------------------------------------");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;

                receiptrichTextBox.AppendText(Environment.NewLine + "Total:     R" + Total.ToString("0.##")); ;
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;

                receiptrichTextBox.AppendText(Environment.NewLine + "Cash:      R" + amountpaid.ToString("0.##")); ;
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;


                receiptrichTextBox.AppendText(Environment.NewLine + "Change:    R" + change.ToString("0.##")); ;
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;






            }



            if (PaymentComboBox.GetItemText(PaymentComboBox.SelectedItem) == "Card")
            //if card 
            {
                //edit receipt 

                receiptrichTextBox.AppendText(Environment.NewLine + "----------------------end-of-sale------------------------");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;
                receiptrichTextBox.AppendText(Environment.NewLine + "#Card#");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;

                receiptrichTextBox.AppendText(Environment.NewLine + "------------------------------------------------------------");
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;


                receiptrichTextBox.AppendText(Environment.NewLine + "Total:     R" + Total.ToString("0.##")); ;
                receiptrichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }

        }
    }


}
