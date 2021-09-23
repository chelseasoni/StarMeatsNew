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
    public partial class ProductReporting : Form
    {
        public ProductReporting()
        {
            InitializeComponent();
        }

        private void ProductReporting_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            productTableAdapter1.Fill(group3DataSet1.Product);
            saleProductTableAdapter1.Fill(group3DataSet1.SaleProduct);
            orderProductTableAdapter1.Fill(group3DataSet1.OrderProduct);
            crystalReport22.SetDataSource(group3DataSet1);
            crystalReport41.SetDataSource(group3DataSet1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Product Sales Report"))
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;

            }
            else {
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = true;
            }
        }

        private void crystalReport21_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReport41_InitReport(object sender, EventArgs e)
        {

        }
    }
}
