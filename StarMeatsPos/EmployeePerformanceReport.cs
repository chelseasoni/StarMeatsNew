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
    public partial class EmployeePerformanceReport : Form
    {
        public EmployeePerformanceReport()
        {
            InitializeComponent();
        }

        private void EmployeePerformanceReport_Load(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            webBrowser1.Navigate("https://app.powerbi.com/view?r=eyJrIjoiYzBkZWQxY2ItOGEzNC00YmJkLTlkYmEtNTkwMjQxZGRjYzIyIiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9&pageName=ReportSection");
        }
    }
}
