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
    public partial class Help2 : Form
    {
        public Help2()
        {
            InitializeComponent();
        }

        private void Help2_Load(object sender, EventArgs e)
        {
           /* if (e.Node.Name == "Node0")
            {
                richTextBox2.Text = "Login Help";
            }
            if (e.Node.Name == "Node1")
            {
                richTextBox2.Text = "Processing a sale";
            }
            if (e.Node.Name == "Node2")
            {
                richTextBox2.Text = "Processing an order";
            }
            if (e.Node.Name == "Node3")
            {
                richTextBox2.Text = "Creating an order";
            }
            if (e.Node.Name == "Node4")
            {
                richTextBox2.Text = "Adding a new product";
            }
            if (e.Node.Name == "Node5")
            {
                richTextBox2.Text = "Updating a product";
            }
            if (e.Node.Name == "Node6")
            {
                richTextBox2.Text = "Viewing sales";
            }
            if (e.Node.Name == "Node7")
            {
                richTextBox2.Text = "Viewing orders";
            }
            if (e.Node.Name == "Node8")
            {
                richTextBox2.Text = "Viewing products";
            }
            if (e.Node.Name == "Node9")
            {
                richTextBox2.Text = "Generating a report";
            }*/
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Name == "Node0")
            {
                richTextBox2.Text = "Login Help";
            }
            if (e.Node.Name == "Node1")
            {
                richTextBox2.Text = "Processing a sale";
                richTextBox2.Text = "1. Click on process sale" + Environment.NewLine + "2. Enter in customer ID number.If they are not a registered customer, click cancel." + Environment.NewLine + "3. Enter in ID of product you wish to add to the sale. " + Environment.NewLine + "4. Click “search” " + Environment.NewLine + "5. Enter in the desired quantity " + Environment.NewLine + "6. Click “add product to cart” " + Environment.NewLine + "7. Repeat steps 3 to 5 for each product" + Environment.NewLine + "8. Select the payment type" + Environment.NewLine + "9. Click “Process Sale”" + Environment.NewLine + "  9.1. Click “yes” to confirm sale" + Environment.NewLine + "  9.2. If sale is cash, enter in received amount and dispense displayed change." + Environment.NewLine + "10. Click “generate receipt”";

            }
            if (e.Node.Name == "Node2")
            {
                richTextBox2.Text = "Processing an order";
            }
            if (e.Node.Name == "Node3")
            {
                richTextBox2.Text = "Creating an order";
            }
            if (e.Node.Name == "Node4")
            {
                richTextBox2.Text = "Adding a new product";
            }
            if (e.Node.Name == "Node5")
            {
                richTextBox2.Text = "Updating a product";
                richTextBox2.Text = "1. Navigate to “Products” on the left-hand side panel" + Environment.NewLine + "2. Select “Manage Products” " + Environment.NewLine + "3. Select a product to update by entering the product ID number OR search for the product by typing into box under the “Product Description” label. " + Environment.NewLine + "4. Make changes to the product by changes the details under “Product Details” section " + Environment.NewLine + "  4.1. To abandon updates, click “Reload table” " + Environment.NewLine + "5. Click “Update”";
            }
            if (e.Node.Name == "Node6")
            {
                richTextBox2.Text = "Viewing sales" ;
                richTextBox2.Text = "1. Navigate to “Sales” on the left-hand side panel" + Environment.NewLine+ "2. Select “View Sales” " + Environment.NewLine + "3. All sales will be displayed" + Environment.NewLine + "4. A specific sale can be viewed" + Environment.NewLine + "  4.1 Enter the sale ID the in the provided field on the left-hand side" + Environment.NewLine + "  4.2 Click “Search button”";
            }
            if (e.Node.Name == "Node7")
            {
                richTextBox2.Text = "Viewing orders";
                richTextBox2.Text = "1. Navigate to “Orders” on the left-hand side panel" + Environment.NewLine + "2. Select “View Orders”" + Environment.NewLine + "3. All orders will be displayed" + Environment.NewLine + "4. A specific order can be viewed" + Environment.NewLine +   "  4.1 Enter the order ID the in the provided field on the right-hand side" + Environment.NewLine + "  4.2 Click the “Search button”" + Environment.NewLine + "5. Orders can be filtered to show new orders and completed orders" + Environment.NewLine + "  5.1 To filter by new orders" + Environment.NewLine + "   5.1.1 Click “New Orders” on the left-hand side" + Environment.NewLine + "5.2 To filter by completed orders" + Environment.NewLine + "   5.2.1 Click “Completed Orders” on the left-hand side";
            }
            if (e.Node.Name == "Node8")
            {
                richTextBox2.Text = "Viewing products";
                richTextBox2.Text = "1. Navigate to “Products” on the left-hand side panel" + Environment.NewLine + "2. Select “View Products”" + Environment.NewLine + "3. All products will be displayed" + Environment.NewLine + "4. A specific product can be viewed" + Environment.NewLine + "  4.1 Enter the product ID the in the provided field on the left-hand side" + Environment.NewLine + "  4.2 Click the “Search button”" + Environment.NewLine + "5. Products can be filtered to show only products on promotion" + Environment.NewLine + "  5.1 On the left-hand side panel select “Products on promotion”";
            }
            if (e.Node.Name == "Node9")
            {
                richTextBox2.Text = "Generating a report";
            }
            if (e.Node.Name == "Node10")
            {
                richTextBox2.Text = "Removing a Product from sale";
                richTextBox2.Text = " 1. Click “Remove item from cart” " + Environment.NewLine + " 2. Enter in ID number of product to be removed" + Environment.NewLine + " 3. The quantity of that product present in the cart will be displayed.Enter the quantity you wish to remove ";
            }

        }
    }
}
