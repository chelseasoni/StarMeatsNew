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
    public partial class NumOrdersPerMonth : Form
    {
        public NumOrdersPerMonth()
        {   

            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void NumOrdersPerMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'starMeatsDataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.starMeatsDataSet1.Order);
            webBrowser1.Refresh();
            webBrowser1.Navigate("https://app.powerbi.com/view?r=eyJrIjoiODZlZjI1NjYtNzcwOS00MGQyLTk2ZDgtNmY2NjkxZDY2NmRmIiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9");

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            orderTableAdapter.Fill(starMeatsDataSet1.Order);
            crNumOrdersPerMonth1.SetDataSource(starMeatsDataSet1);
        }
    }
}
