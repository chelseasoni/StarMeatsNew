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
    public partial class OrdersReporting : Form
    {
        public OrdersReporting()
        {
            InitializeComponent();
        }

        private void FromDatedtp_ValueChanged(object sender, EventArgs e)
        {
            rtbDisplay.Clear();

            rtbDisplay.Text = "Orders report from " + FromDatedtp.Value.ToString() + " to " + toDatedtp.Value.ToString();
            taNumOrders1.FillNumberOrders(starMeatsDataSet1.numOrders, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal number of Orders: \n" + starMeatsDataSet1.numOrders.Rows[0].ItemArray[0].ToString();

            taOrdersReporting1.FillByOrdersTotal(starMeatsDataSet1.OrdersReporting, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal Orders Amount: \n ";
            try
            {
                rtbDisplay.Text += String.Format("{0:C}", Convert.ToDecimal(starMeatsDataSet1.OrdersReporting.Rows[0].ItemArray[0].ToString()));
            }
            catch (Exception e5)
            {
                rtbDisplay.Text += "There are no sales between the selected time frame";
            }
            taOrdersReporting21.FillByMostOrdered(starMeatsDataSet1.OrdersReporting2, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nMost ordered product: \n";
            try
            {
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[2].ToString();
                rtbDisplay.Text += "\n\nNumber of times ordered:\n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[1].ToString();
            }
            catch (IndexOutOfRangeException e1)
            {
                rtbDisplay.Text += "There are no orders between the selected time frame";
                Console.WriteLine(e1.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }

            rtbDisplay.Refresh();
            starMeatsDataSet1.Clear();
            taOrdersReporting21.FillByLeastOrdered(starMeatsDataSet1.OrdersReporting2, FromDatedtp.Value, toDatedtp.Value);

            try
            {
                rtbDisplay.Text += "\n\nLeast ordered product: \n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[2].ToString();
                rtbDisplay.Text += "\n\nNumber of times ordered:\n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[1].ToString();
            }
            catch (IndexOutOfRangeException e2)
            {
                rtbDisplay.Text += "There are no orders between the selected time frame";
                Console.WriteLine(e2.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }
            rtbDisplay.Refresh();
        }

        private void toDatedtp_ValueChanged(object sender, EventArgs e)
        {
            rtbDisplay.Clear();

            rtbDisplay.Text = "Orders report from " + FromDatedtp.Value.ToString() + " to " + toDatedtp.Value.ToString();
            taNumOrders1.FillNumberOrders(starMeatsDataSet1.numOrders, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal number of Orders: \n" + starMeatsDataSet1.numOrders.Rows[0].ItemArray[0].ToString();

            taOrdersReporting1.FillByOrdersTotal(starMeatsDataSet1.OrdersReporting, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal Orders Amount: \n " + "R" + starMeatsDataSet1.OrdersReporting.Rows[0].ItemArray[0].ToString();

            taOrdersReporting21.FillByMostOrdered(starMeatsDataSet1.OrdersReporting2, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nMost ordered product: \n";
            try
            {
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[2].ToString();
                rtbDisplay.Text += "\n\nNumber of times ordered:\n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[1].ToString();
            }
            catch (IndexOutOfRangeException e1)
            {
                rtbDisplay.Text += "There are no orders between the selected time frame";
                Console.WriteLine(e1.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }

            rtbDisplay.Refresh();
            starMeatsDataSet1.Clear();
            taOrdersReporting21.FillByLeastOrdered(starMeatsDataSet1.OrdersReporting2, FromDatedtp.Value, toDatedtp.Value);

            try
            {
                rtbDisplay.Text += "\n\nLeast ordered product: \n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[2].ToString();
                rtbDisplay.Text += "\n\nNumber of times ordered:\n";
                rtbDisplay.Text += starMeatsDataSet1.OrdersReporting2.Rows[0].ItemArray[1].ToString();
            }
            catch (IndexOutOfRangeException e2)
            {
                rtbDisplay.Text += "There are no orders between the selected time frame";
                Console.WriteLine(e2.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }
            rtbDisplay.Refresh();
        }

        private void OrdersReporting_Load(object sender, EventArgs e)
        {

        }
    }
}
