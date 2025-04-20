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


namespace Soft.InstructorUserControls
{
    public partial class UC_TakeAttendance : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public UC_TakeAttendance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mark Present Button

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Classes Values(:stdID,:courseID,:classDate,'p')";
            cmd.Parameters.Add("stdID", currStudentID);
            cmd.Parameters.Add("courseID", currCourseID);
            cmd.Parameters.Add("classDate", OracleDbType.Date).Value = dateTimePicker1.Value;
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Attendance Taken!");
            }
        }
        string currCourseID = "0";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID from courses where name =:courseName";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("courseName", comboBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                currCourseID = dr[0].ToString();
            }
            dr.Close();

            comboBox2.Items.Clear();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT username FROM students WHERE ID IN (SELECT STUDENTID FROM StudentCourses WHERE COURSEID = :id)";
            cmd2.Parameters.Add("id", currCourseID);
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0].ToString());
            }
            dr2.Close();
        }

        private void UC_TakeAttendance_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name from courses";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        string currStudentID = "0";
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID from students where username =:stdName";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("stdName", comboBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                currStudentID = dr[0].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "MarkAllAbsent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_course_id", currCourseID);
            cmd.Parameters.Add("p_date", OracleDbType.Date).Value = dateTimePicker1.Value;
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Marked the filthy students absent");
            }
        }
    }
}
