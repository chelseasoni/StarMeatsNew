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
    public partial class SalesReporting : Form
    {
        public SalesReporting()
        {
            InitializeComponent();
        }

        private void FromDatedtp_ValueChanged(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            if (FromDatedtp.Value >toDatedtp.Value) { MessageBox.Show("From date need to be less than to Date"); }
            else { 
            rtbDisplay.Text = "Sales report from " + FromDatedtp.Value.ToString() + " to " + toDatedtp.Value.ToString();
            tanumSales1.FillNumberofsales(starMeatsDataSet1.numSales, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal number of Sales: \n" + starMeatsDataSet1.numSales.Rows[0].ItemArray[0].ToString();

            taReportTotalSales1.FillTotalSales(starMeatsDataSet1.ReportTotalSales, FromDatedtp.Value, toDatedtp.Value);
            
            rtbDisplay.Text += "\n\nTotal Sales Amount: \n "  ;
            try
            {
                rtbDisplay.Text += String.Format("{0:C}", Convert.ToDecimal(starMeatsDataSet1.ReportTotalSales.Rows[0].ItemArray[0].ToString()));
            }
            catch(Exception e5) {
                rtbDisplay.Text += "There are no sales between the selected time frame";
            }

            taSalesReport1.FillByMostSold(starMeatsDataSet1.SalesReport, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nMost sold product: \n";
            try
            {
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[1].ToString();
                rtbDisplay.Text += "\n\nNumber of times sold:\n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[2].ToString();
            }
            catch (IndexOutOfRangeException e1)
            {
                rtbDisplay.Text += "There are no sales between the selected time frame";
                Console.WriteLine(e1.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }

            rtbDisplay.Refresh();
            starMeatsDataSet1.Clear();
            taSalesReport1.FillByLeastSold(starMeatsDataSet1.SalesReport, FromDatedtp.Value, toDatedtp.Value);
            try
            {
                rtbDisplay.Text += "\n\nLeast sold product: \n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[1].ToString();
                rtbDisplay.Text += "\n\nNumber of times sold:\n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[2].ToString();
            }
            catch (IndexOutOfRangeException e2)
            {
                rtbDisplay.Text += "There are no sales between the selected time frame";
                Console.WriteLine(e2.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }
            rtbDisplay.Refresh();
            }
        }

        private void toDatedtp_ValueChanged(object sender, EventArgs e)
        {
            rtbDisplay.Clear();

            rtbDisplay.Text = "Sales report from " + FromDatedtp.Value.ToString() + " to " + toDatedtp.Value.ToString();
            tanumSales1.FillNumberofsales(starMeatsDataSet1.numSales, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal number of Sales: \n" + starMeatsDataSet1.numSales.Rows[0].ItemArray[0].ToString();

            taReportTotalSales1.FillTotalSales(starMeatsDataSet1.ReportTotalSales, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nTotal Sales Amount: \n " + "R" + starMeatsDataSet1.ReportTotalSales.Rows[0].ItemArray[0].ToString();


            taSalesReport1.FillByMostSold(starMeatsDataSet1.SalesReport, FromDatedtp.Value, toDatedtp.Value);
            rtbDisplay.Text += "\n\nMost sold product: \n";
            try
            {
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[1].ToString();
                rtbDisplay.Text += "\n\nNumber of times sold:\n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[2].ToString();
            }
            catch (IndexOutOfRangeException e1)
            {
                rtbDisplay.Text += "There are no sales between the selected time frame";
                Console.WriteLine(e1.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }

            rtbDisplay.Refresh();
            starMeatsDataSet1.Clear();
            taSalesReport1.FillByLeastSold(starMeatsDataSet1.SalesReport, FromDatedtp.Value, toDatedtp.Value);
            try
            {
                rtbDisplay.Text += "\n\nLeast sold product: \n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[1].ToString();
                rtbDisplay.Text += "\n\nNumber of times sold:\n";
                rtbDisplay.Text += starMeatsDataSet1.SalesReport.Rows[0].ItemArray[2].ToString();
            }
            catch (IndexOutOfRangeException e2)
            {
                rtbDisplay.Text += "There are no sales between the selected time frame";
                Console.WriteLine(e2.Message);
                //throw new ArgumentOutOfRangeException("index parameter is out of range.", e1);
            }
            rtbDisplay.Refresh();
        }

        private void SalesReporting_Load(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            webBrowser1.Navigate("https://app.powerbi.com/view?r=eyJrIjoiN2FiYWM0MGQtYTRhZS00NGQ4LWE1NzYtMzBkYTRlOWVlMWU4IiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9&pageName=ReportSection");
        }
    }
}
