using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Soft
{
    public partial class GeneralReportForm : Form
    {
        GeneralReport report;
        public GeneralReportForm()
        {
            InitializeComponent();
        }
        private void GeneralReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void OnOpen(object sender, EventArgs e)
        {
            report = new GeneralReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = report;
        }
    }
}
