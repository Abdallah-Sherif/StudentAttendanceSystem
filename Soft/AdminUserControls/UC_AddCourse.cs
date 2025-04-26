using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Soft.AdminUserControls
{
    public partial class UC_AddCourse : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection con;
        public UC_AddCourse()
        {
            InitializeComponent();
        }
        private void OpenConnection()
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
        private void CloseConnection()
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "AddCourses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("course_name", textBox2.Text);

            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Course Added Successfully");
            CloseConnection();

            CloseConnection();
        }
    }
}
