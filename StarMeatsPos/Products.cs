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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        public void hidecomponents() {
            button1.Visible = false;
            groupBox1.Visible = false;
        }
        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group3DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.group3DataSet.Product);
            // TODO: This line of code loads data into the 'starMeatsDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.starMeatsDataSet.Product);
            //
            if (Login.isManager == false)
            {
                groupBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                textBoxID.ReadOnly = true;
                textBoxDescription.ReadOnly = true;
                textBoxCategory.ReadOnly = true;
                textBoxPrice.ReadOnly = true;
                textBoxQuantity.ReadOnly = true;
                textBoxOnPromotion.ReadOnly = true;
                textBoxSellBy.ReadOnly = true;
                textBoxReorder.ReadOnly = true;
            }
            else
            {
                textBoxID.ReadOnly = true;
                textBoxDescription.ReadOnly = false;
                textBoxCategory.ReadOnly = false;
                textBoxPrice.ReadOnly = false;
                textBoxQuantity.ReadOnly = false;
                textBoxOnPromotion.ReadOnly = false;
                textBoxSellBy.ReadOnly = false;
                textBoxReorder.ReadOnly = false;
               
                button2.Visible = true;
                button3.Visible = true;
            }
            //
            this.productBindingSource2.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource2.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_kg"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_unit"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.starMeatsDataSet);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxProductDetails_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //clear textboxes
            textBoxID.Clear();
            textBoxCategory.Clear();
            textBoxDescription.Clear();
            textBoxOnPromotion.Clear();
            textBoxPrice.Clear();
            // textBoxProductID.Clear();
            textBoxQuantity.Clear();
            textBoxReorder.Clear();
            textBoxSellBy.Clear();

            //show available products on table
            productTableAdapter.FillBy(starMeatsDataSet.Product, Convert.ToInt32(textBoxProductID.Text));
            DataGridViewRow r3 = this.productDataGridView.CurrentRow;

            //if no such product exists

            if (productDataGridView.Rows.Count == 1)
            {
                MessageBox.Show("No such product exists.");
            }


            //if a prodict does exist
            else
            {

                textBoxID.Text = textBoxProductID.Text;
                textBoxDescription.Text = r3.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                textBoxCategory.Text = r3.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                textBoxOnPromotion.Text =r3.Cells["dataGridViewCheckBoxColumn1"].Value.ToString();


                textBoxSellBy.Text = r3.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                textBoxReorder.Text = r3.Cells["dataGridViewTextBoxColumn9"].Value.ToString();

                //special coding for quantity            
                if (r3.Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "")
                {
                    textBoxQuantity.Text = r3.Cells["dataGridViewTextBoxColumn7"].Value.ToString();


                }
                else
                {
                    textBoxQuantity.Text = r3.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                }


                //special coding for price
                //if per kg is blank
                if (r3.Cells["dataGridViewTextBoxColumn5"].Value.ToString() == "")
                {
                    textBoxPrice.Text = r3.Cells["dataGridViewTextBoxColumn4"].Value.ToString();


                }
                else
                {
                    textBoxPrice.Text = r3.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                }


            }



        }

        private void buttonViewAllProducts_Click(object sender, EventArgs e)
        {
            productTableAdapter.Fill(starMeatsDataSet.Product);

        }

        private void buttonViewProductsOnPromotion_Click(object sender, EventArgs e)
        {
            productTableAdapter.FillByPromotion(starMeatsDataSet.Product);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //show available products on table
            productTableAdapter.FillByProdSearch(starMeatsDataSet.Product, textboxproddescrip.Text.ToString());
            DataGridViewRow r3 = this.productDataGridView.CurrentRow;
            if (productDataGridView.Rows.Count == 1)
            {
                // productDataGridView.DataSource = null;
                // productDataGridView.Rows.Clear();
                MessageBox.Show("No such item exists");
                textboxproddescrip.Clear();
                textboxproddescrip.Focus();

            }
            else
            {
                //clear textboxes
                textBoxID.Clear();
                textBoxCategory.Clear();
                textBoxDescription.Clear();
                textBoxOnPromotion.Clear();
                textBoxPrice.Clear();
                // textBoxProductID.Clear();
                textBoxQuantity.Clear();
                textBoxReorder.Clear();
                textBoxSellBy.Clear();



                textBoxID.Text = r3.Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                textBoxDescription.Text = r3.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                textBoxCategory.Text = r3.Cells["dataGridViewTextBoxColumn3"].Value.ToString();




                textBoxSellBy.Text = r3.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                textBoxReorder.Text = r3.Cells["dataGridViewTextBoxColumn9"].Value.ToString();

                //special coding for quantity            
                if (r3.Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "")
                {
                    textBoxQuantity.Text = r3.Cells["dataGridViewTextBoxColumn7"].Value.ToString();


                }
                else
                {
                    textBoxQuantity.Text = r3.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                }


                //special coding for price
                //if per kg is blank
                if (r3.Cells["dataGridViewTextBoxColumn5"].Value.ToString() == "")
                {
                    textBoxPrice.Text = r3.Cells["dataGridViewTextBoxColumn4"].Value.ToString();


                }
                else
                {
                    textBoxPrice.Text = r3.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                }


                //special coding for on promotion
                textBoxOnPromotion.Text = r3.Cells["dataGridViewCheckBoxColumn1"].Value.ToString();



            }

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.productBindingSource2.MoveFirst();
            //this.productBindingSource1.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource2.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_kg"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_unit"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.productBindingSource2.MovePrevious();
            //this.productBindingSource1.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource2.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_kg"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_unit"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.productBindingSource2.MoveNext();
            //this.productBindingSource1.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource2.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_kg"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_unit"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.productBindingSource2.MoveLast();
            //this.productBindingSource1.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource2.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_kg"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                    textBoxQuantity.Text = Convert.ToString(current["Prod_Quantity_Available_unit"]);
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String underStockLevel = "Product under restock level :\r\n";
            this.productBindingSource.MoveFirst();
            //
            foreach (DataRow row in group3DataSet.Product.Rows)
            {
                DataRowView current = (DataRowView)this.productBindingSource.Current;
                if (current["Prod_Category"].Equals("Butchery Meat") && (Convert.ToInt32(current["Prod_Id"]) != 31) || (Convert.ToInt32(current["Prod_Id"]) == 50))
                {
                    if (Convert.ToDouble(current["Prod_Quantity_Available_kg"]) <= Convert.ToInt32(current["Reorder_level"]))
                    {
                        underStockLevel += current["Prod_Description"] + "\r\n";
                    }
                }
                else
                {
                    if (Convert.ToDouble(current["Prod_Quantity_Available_unit"]) <= Convert.ToInt32(current["Reorder_level"]))
                    {
                        underStockLevel += current["Prod_Description"] + "\r\n";
                    }
                }
                productBindingSource.MoveNext();
            }
            MessageBox.Show(underStockLevel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productTableAdapter.Fill(starMeatsDataSet.Product);
            MessageBox.Show("Table has been reloaded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            try
            {
                if (textBoxCategory.Text.Equals("Butchery Meat"))
                {
                    productTableAdapter.UpdateQueryProdWithKgs(Convert.ToString(textBoxDescription.Text), Convert.ToString(textBoxCategory.Text), Convert.ToBoolean(textBoxOnPromotion.Text),
                        Convert.ToDecimal(textBoxPrice.Text), Convert.ToDecimal(textBoxQuantity.Text), Convert.ToDateTime(textBoxSellBy.Text), Convert.ToDecimal(textBoxReorder.Text),
                        Convert.ToInt32(textBoxID.Text));
                }
                else
                {
                    productTableAdapter.UpdateQuery(Convert.ToString(textBoxDescription.Text), Convert.ToString(textBoxCategory.Text), Convert.ToBoolean(textBoxOnPromotion.Text),
                        Convert.ToDecimal(textBoxPrice.Text), Convert.ToDecimal(textBoxQuantity.Text), Convert.ToDateTime(textBoxSellBy.Text), Convert.ToDecimal(textBoxReorder.Text),
                        Convert.ToInt32(textBoxID.Text));
                }
                this.productTableAdapter1.Fill(this.group3DataSet.Product);
                productTableAdapter.Fill(starMeatsDataSet.Product);
                MessageBox.Show("Update Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Update Failed");
            }
        
       }
    }
}
