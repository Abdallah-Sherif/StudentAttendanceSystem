using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GeneralReportForm generalReportForm = new GeneralReportForm();
            generalReportForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseStudentForm courseReportForm = new CourseStudentForm();
            courseReportForm.Show();
            this.Visible = false;
        }
    }
}
