using CrystalDecisions.Shared;
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
    public partial class CourseStudentForm : Form
    {
        CourseStudents courseStudents;
        public CourseStudentForm()
        {
            InitializeComponent();
        }
        private void CourseStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            courseStudents.SetParameterValue(0, comboBox1.Text);
            //courseStudents.SetParameterValue()
            crystalReportViewer1.ReportSource = courseStudents;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            courseStudents = new CourseStudents();
            foreach (ParameterDiscreteValue v in courseStudents.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }
    }
}
