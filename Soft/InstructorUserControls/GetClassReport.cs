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
    public partial class GetClassReport : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public GetClassReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT s.username, c.status " +
                              "FROM students s " +
                              "INNER JOIN classes c ON s.ID = c.STUDENTID " +
                              "WHERE c.COURSEID =:course_id " +
                              "AND TRUNC(c.CLASSDATE) =TRUNC(:dateTime)";
            cmd.Parameters.Add("course_id", currCourseID);
            cmd.Parameters.Add("dateTime", OracleDbType.Date).Value = dateTimePicker1.Value;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                checkedListBox1.Items.Add(dr[0].ToString());
                string status = dr[1].ToString();
                if(status == "p")
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, true);
                else
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, false);

            }
            dr.Close();
        }

        private void GetClassReport_Load(object sender, EventArgs e)
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
        }
    }
}
