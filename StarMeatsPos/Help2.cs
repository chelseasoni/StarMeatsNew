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
                richTextBox2.Text = "\n\n 1.  Click on the text box next to the Username label to type in your username.\n\n 2.Click on the text box next to the Password label to type in your username. \n\n 3.Click Login to continue to the program functions. \n\n 4.Click Exit to close the program.";
            }
            if (e.Node.Name == "Node1")
            {
                richTextBox2.Text = "Processing a sale";
                richTextBox2.Text = "\n\n 1. Click on process sale" + Environment.NewLine + "\n 2. Enter in customer ID number.If they are not a registered customer, click cancel." + Environment.NewLine + "\n 3. Enter in ID of product you wish to add to the sale. " + Environment.NewLine + "\n 4. Click “search” " + Environment.NewLine + "\n 5. Enter in the desired quantity " + Environment.NewLine + "\n 6. Click “add product to cart” " + Environment.NewLine + "\n 7. Repeat steps 3 to 5 for each product" + Environment.NewLine + "\n 8. Select the payment type" + Environment.NewLine + "\n 9. Click “Process Sale”" + Environment.NewLine + "  9.1. Click “yes” to confirm sale" + Environment.NewLine + "  9.2. If sale is cash, enter in received amount and dispense displayed change." + Environment.NewLine + "\n 10. Click “generate receipt”";

            }
            if (e.Node.Name == "Node2")
            {
                richTextBox2.Text = "Processing an order";
                richTextBox2.Text = "\n\n 1. Navigate to Sale, then select process order. \n\n 2. Double click the desired order. The products associated with the selected order will be listed on the table in the middle of the screen.\n\n 3. The total due will be displayed in the bottom left corner of the screen \n 3.1 select the preferred method of payment using the drop down arrow located under the total due textbox. \n\n 4. Click “confirm order” to finish off the order. The receipt will be displayed on the right side of the screen.";
            }
            if (e.Node.Name == "Node3")
            {
                richTextBox2.Text = "Creating an order";
                richTextBox2.Text = "\n\n 1. Navigate to orders, then select create order.\n\n 2.Here you can either look through the table located at the top of the screen for products and click on their IDs or you can type in the product you’re looking for using the search bar located on the left side of the screen.\n\n 3.Once you have chosen a product, specify the quantity using the “Product Quantity” textbox. \n 3.1 if the product is a meat item, you can specify the quantity as a decimal number using the “xx.xx” format. \n 3.2 If the product is off the shelf, ONLY use whole numbers. \n\n 4.Click on the “add product” button to add the product to the order or the “remove button” to remove the product from the order. \n\n 5.Repeat the process until you have all the products desired in the order. \n\n 6.You must then specify the customer ID, Employee ID as well as the end date for the order on the right side of the screen. \n\n 7.Once you are done, click on “Create Order” to finalise the order and successfully post it to the order’s table.";
            }
            if (e.Node.Name == "Node4")
            {
                richTextBox2.Text = "Adding a new product";
            }
            if (e.Node.Name == "Node5")
            {
                richTextBox2.Text = "Updating a product";
                richTextBox2.Text = "\n\n 1. Navigate to “Products” on the left-hand side panel" + Environment.NewLine + "\n 2. Select “Manage Products” " + Environment.NewLine + "\n 3. Select a product to update by entering the product ID number OR search for the product by typing into box under the “Product Description” label. " + Environment.NewLine + "\n 4. Make changes to the product by changes the details under “Product Details” section " + Environment.NewLine + "  4.1. To abandon updates, click “Reload table” " + Environment.NewLine + "\n 5. Click “Update”";
            }
            if (e.Node.Name == "Node6")
            {
                richTextBox2.Text = "Viewing sales" ;
                richTextBox2.Text = "\n\n 1. Navigate to “Sales” on the left-hand side panel" + Environment.NewLine+ "\n 2. Select “View Sales” " + Environment.NewLine + "\n 3. All sales will be displayed" + Environment.NewLine + "\n 4. A specific sale can be viewed" + Environment.NewLine + "  4.1 Enter the sale ID the in the provided field on the left-hand side" + Environment.NewLine + "  4.2 Click “Search button”";
            }
            if (e.Node.Name == "Node7")
            {
                richTextBox2.Text = "Viewing orders";
                richTextBox2.Text = "\n\n 1. Navigate to “Orders” on the left-hand side panel" + Environment.NewLine + "\n 2. Select “View Orders”" + Environment.NewLine + "\n 3. All orders will be displayed" + Environment.NewLine + "\n 4. A specific order can be viewed" + Environment.NewLine +   "  4.1 Enter the order ID the in the provided field on the right-hand side" + Environment.NewLine + "  4.2 Click the “Search button”" + Environment.NewLine + "\n 5. Orders can be filtered to show new orders and completed orders" + Environment.NewLine + "  5.1 To filter by new orders" + Environment.NewLine + "   5.1.1 Click “New Orders” on the left-hand side" + Environment.NewLine + "5.2 To filter by completed orders" + Environment.NewLine + "   5.2.1 Click “Completed Orders” on the left-hand side";
            }
            if (e.Node.Name == "Node8")
            {
                richTextBox2.Text = "Viewing products";
                richTextBox2.Text = "\n\n 1. Navigate to “Products” on the left-hand side panel" + Environment.NewLine + "\n 2. Select “View Products”" + Environment.NewLine + "\n 3. All products will be displayed" + Environment.NewLine + "\n 4. A specific product can be viewed" + Environment.NewLine + "  4.1 Enter the product ID the in the provided field on the left-hand side" + Environment.NewLine + "  4.2 Click the “Search button”" + Environment.NewLine + "\n 5. Products can be filtered to show only products on promotion" + Environment.NewLine + "  5.1 On the left-hand side panel select “Products on promotion”";
            }
            if (e.Node.Name == "Node9")
            {
                richTextBox2.Text = "Generating a report";
                richTextBox2.Text = "\n\n 1. Navigate to orders, then select view orders. \n\n 2. Double click the desired order from the table at the top of the screen. The products associated with the selected order will be listed on the table in the middle of the screen. \n\n 3. Once the order has been completed, click on the “order prepared” to classify the order as “prepared” instead of “in process”.";
            }
            if (e.Node.Name == "Node10")
            {
                richTextBox2.Text = "Removing a Product from sale";
                richTextBox2.Text = " \n\n 1. Click “Remove item from cart” " + Environment.NewLine + "\n 2. Enter in ID number of product to be removed" + Environment.NewLine + "\n 3. The quantity of that product present in the cart will be displayed.Enter the quantity you wish to remove ";
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
