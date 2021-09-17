﻿using System;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.starMeatsDataSet);

        }
        public void hideGroupbox() {
            groupBox1.Hide();
        }
        public void disabletextboxes() {
            textBoxID.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxSurname.ReadOnly = true;
            textBoxContact.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            button1.Visible = false;
            buttonClear.Visible = false;


        }
        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group3DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.group3DataSet.Customer);
            // TODO: This line of code loads data into the 'starMeatsDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.starMeatsDataSet.Customer);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonSearch, "Search for Customer");
            toolTip.SetToolTip(textBoxCustomerName, "Enter Customer name to search");
            toolTip.SetToolTip(textBoxCustomerSurname, "Enter Customer surname to search");
            toolTip.SetToolTip(textBoxCustomerContact, "Enter Customer contact to search");
            toolTip.SetToolTip(buttonFirst, "Takes you to the top for the grid");
            toolTip.SetToolTip(buttonPrevious, "Takes you one up on the grid");
            toolTip.SetToolTip(buttonNext, "Takes you one down on the grid");
            toolTip.SetToolTip(buttonLast, "Takes you to the bottom on the grid");
            toolTip.SetToolTip(textBoxID, "Contains the Customer's ID ");
            toolTip.SetToolTip(textBoxName, "Contains the Customer's Name ");
            toolTip.SetToolTip(textBoxSurname, "Contains the Customer's Surname ");
            toolTip.SetToolTip(textBoxContact, "Contains the Customer's Number ");
            toolTip.SetToolTip(textBox6, "Contains the Customer's E-mail ");
            toolTip.SetToolTip(textBoxPassword ,"Contains the Customer's Password ");
            toolTip.SetToolTip(button1, "Update Customer's details");
            toolTip.SetToolTip(buttonAdd, "Add new Customer's details, Customer Id number will be generated by the system ");
            toolTip.SetToolTip(buttonClear, "Reset Customer's details before editing it");
        }

        private void groupBoxStaffDetails_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.customerBindingSource1.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.customerBindingSource1.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.customerBindingSource1.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.customerBindingSource1.MoveLast();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            customerBindingSource1.MoveFirst();
            Boolean found = false;
            if (String.IsNullOrEmpty(textBoxCustomerContact.Text) && (String.IsNullOrEmpty(textBoxCustomerSurname.Text)))
            {
                foreach (DataRow row in group3DataSet.Customer.Rows)
                {
                    DataRowView current = (DataRowView)this.customerBindingSource1.Current;
                    if (Convert.ToString(current["Cust_Name"]).Equals(textBoxCustomerName.Text))
                    {
                        found = true;
                        MessageBox.Show("Found");
                        break;
                    }
                    else
                    {
                        customerBindingSource1.MoveNext();
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Customer not found");
                }
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxCustomerContact.Text))
                {
                    foreach (DataRow row in group3DataSet.Customer.Rows)
                    {
                        DataRowView current = (DataRowView)this.customerBindingSource1.Current;
                        if (Convert.ToString(current["Cust_Name"]).Equals(textBoxCustomerName.Text) && (Convert.ToString(current["Cust_Surname"]).Equals(textBoxCustomerSurname.Text)))
                        {
                            found = true;
                            MessageBox.Show("Found");
                            break;
                        }
                        else
                        {
                            customerBindingSource1.MoveNext();
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("Customer not found");
                    }
                }
                else
                {
                    foreach (DataRow row in group3DataSet.Customer.Rows)
                    {
                        DataRowView current = (DataRowView)this.customerBindingSource1.Current;
                        if (Convert.ToString(current["Cust_Name"]).Equals(textBoxCustomerName.Text) && (Convert.ToString(current["Cust_Surname"]).Equals(textBoxCustomerSurname.Text) && (Convert.ToString(current["Cust_Contact"]).Equals(textBoxCustomerContact.Text))))
                        {
                            found = true;
                            MessageBox.Show("Found");
                            break;
                        }
                        else
                        {
                            customerBindingSource1.MoveNext();
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("Customer not found");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool allValidateDetails = true;
            String test;
            // test name
            bool validName = true;
            test = textBoxName.Text;
            if (String.IsNullOrEmpty(test))
            {
                validName = false;
                allValidateDetails = false;
            }
            for (int i = 0; i < test.Length; i++)
            {
                if (!char.IsLetter(test[i]))
                {
                    validName = false;
                    allValidateDetails = false;
                }
            }
            if (!validName)
            {
                MessageBox.Show("Invalid Name");
                textBoxName.Clear();
            }
            // test surname
            bool validSurname = true;
            test = textBoxSurname.Text;
            if (String.IsNullOrEmpty(test))
            {
                validSurname = false;
                allValidateDetails = false;
            }
            for (int i = 0; i < test.Length; i++)
            {
                if (!char.IsLetter(test[i]))
                {
                    validSurname = false;
                    allValidateDetails = false;
                }
            }
            if (!validSurname)
            {
                MessageBox.Show("Invalid Surname");
                textBoxSurname.Clear();
            }
            // number
            bool validCNumber = true;
            test = textBoxContact.Text;
            if (String.IsNullOrEmpty(test) || (test.Length != 10) || (test[0] != '0'))
            {
                validCNumber = false;
                allValidateDetails = false;
            }
            for (int i = 0; i < test.Length; i++)
            {
                if (!char.IsDigit(test[i]))
                {
                    validCNumber = false;
                    allValidateDetails = false;
                }
            }
            if (!validCNumber)
            {
                MessageBox.Show("Invalid Number");
                textBoxContact.Clear();
            }
            // email
            bool validEmail = true;
            test = textBox6.Text;
            if (String.IsNullOrEmpty(test) || (test.IndexOf('@') < 0))
            {
                validEmail = false;
                allValidateDetails = false;
            }
            if (!validEmail)
            {
                MessageBox.Show("Invalid E-mail");
                textBox6.Clear();
            }
            // password
            /*bool validPassword = true;
            test = textBoxPassword.Text;
            if (String.IsNullOrEmpty(test))
            {
                validPassword = false;
                allValidateDetails = false;
            }
            if (!validPassword)
            {
                MessageBox.Show("Invalid Password");
                textBoxPassword.Clear();
            }
            */
            if (allValidateDetails) {
                customerTableAdapter1.UpdateQuery(Convert.ToString(textBoxName.Text), Convert.ToString(textBoxSurname.Text),
                    Convert.ToString(textBox6.Text), Convert.ToString(textBoxContact.Text), Convert.ToString(textBoxPassword.Text),
                    Convert.ToInt32(textBoxID.Text));
                MessageBox.Show("Customer details Updated");
                this.customerTableAdapter1.Fill(this.group3DataSet.Customer);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter1.Fill(this.group3DataSet.Customer);
            MessageBox.Show("Customer details have been reloaded");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool allValidateDetails = true;
                String test;
                // test name
                bool validName = true;
                test = textBoxName.Text;
                if (String.IsNullOrEmpty(test))
                {
                    validName = false;
                    allValidateDetails = false;
                }
                for (int i = 0; i < test.Length; i++)
                {
                    if (!char.IsLetter(test[i]))
                    {
                        validName = false;
                        allValidateDetails = false;
                    }
                }
                if (!validName)
                {
                    MessageBox.Show("Invalid Name");
                    textBoxName.Clear();
                }
                // test surname
                bool validSurname = true;
                test = textBoxSurname.Text;
                if (String.IsNullOrEmpty(test))
                {
                    validSurname = false;
                    allValidateDetails = false;
                }
                for (int i = 0; i < test.Length; i++)
                {
                    if (!char.IsLetter(test[i]))
                    {
                        validSurname = false;
                        allValidateDetails = false;
                    }
                }
                if (!validSurname)
                {
                    MessageBox.Show("Invalid Surname");
                    textBoxSurname.Clear();
                }
                // number
                bool validCNumber = true;
                test = textBoxContact.Text;
                if (String.IsNullOrEmpty(test) || (test.Length != 10) || (test[0] != '0'))
                {
                    validCNumber = false;
                    allValidateDetails = false;
                }
                for (int i = 0; i < test.Length; i++)
                {
                    if (!char.IsDigit(test[i]))
                    {
                        validCNumber = false;
                        allValidateDetails = false;
                    }
                }
                if (!validCNumber)
                {
                    MessageBox.Show("Invalid Number");
                    textBoxContact.Clear();
                }
                // email
                bool validEmail = true;
                test = textBox6.Text;
                if (String.IsNullOrEmpty(test) || (test.IndexOf('@') < 0))
                {
                    validEmail = false;
                    allValidateDetails = false;
                }
                if (!validEmail)
                {
                    MessageBox.Show("Invalid E-mail");
                    textBox6.Clear();
                }
                // password
                bool validPassword = true;
                test = textBoxPassword.Text;
                if (String.IsNullOrEmpty(test))
                {
                    validPassword = false;
                    allValidateDetails = false;
                }
                if (!validPassword)
                {
                    MessageBox.Show("Invalid Password");
                    textBoxPassword.Clear();
                }
                if (allValidateDetails)
                {
                    customerTableAdapter1.Insert(Convert.ToString(textBoxName.Text), Convert.ToString(textBoxSurname.Text),
                        Convert.ToString(textBox6.Text), Convert.ToString(textBoxContact.Text), Convert.ToString(textBoxPassword.Text));
                    MessageBox.Show("Customer's details have been added");
                    this.customerTableAdapter1.Fill(this.group3DataSet.Customer);
                    //textBoxName.Clear();
                    label1.Visible = true;
                    //textBoxID.Clear();
                    textBoxID.Visible = true;
                    //textBoxSurname.Clear();
                    //textBox6.Clear();
                    //textBoxContact.Clear();
                    textBoxPassword.Visible = false;
                    //textBoxPassword.Clear();
                    label8.Visible = false;
                    buttonAdd.Enabled = false;
                    button1.Enabled = false;

                }
            }
            catch {
                MessageBox.Show("unable to insert");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            label1.Visible = false;
            textBoxID.Clear();
            textBoxID.Visible = false;
            textBoxSurname.Clear();
            textBox6.Clear();
            textBoxContact.Clear();
            textBoxPassword.Visible = true;
            textBoxPassword.Clear();
            label8.Visible = true;
            buttonAdd.Enabled = true;
            button1.Enabled = false;
            MessageBox.Show("Enter New Customer Details");

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
