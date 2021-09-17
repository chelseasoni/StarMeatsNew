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
            }
        }
    }
}
