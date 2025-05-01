using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft.AdminUserControls
{
    public partial class AssignStudentToCourse : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection con;
        private void OpenConnection()
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
        private void CloseConnection()
        {
            con.Close();
        }
        public AssignStudentToCourse()
        {
            InitializeComponent();
        }
        private void AssignStudentToCourse_Load(object sender, EventArgs e)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id from students";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id from courses";
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into studentcourses (studentid, courseid) values (:student_id, :course_id)";
            cmd.Parameters.Add("student_id", comboBox1.Text);
            cmd.Parameters.Add("course_id", comboBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Student assigned to course successfully");
            }
            else
            {
                MessageBox.Show("Failed to assign student to course");
            }
            CloseConnection();
        }
    }
}
