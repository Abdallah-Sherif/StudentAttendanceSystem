using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Soft.AdminUserControls
{
    public partial class ClassStudents : UserControl
    {
        CourseStudents cr;
        public ClassStudents()
        {
            InitializeComponent();
        }

        private void ClassStudents_Load(object sender, EventArgs e)
        {
            cr = new CourseStudents();
            foreach( ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1);

            crystalReportViewer1.ReportSource = cr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
