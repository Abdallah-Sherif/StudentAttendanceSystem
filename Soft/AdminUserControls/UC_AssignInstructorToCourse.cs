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

namespace Soft.AdminUserControls
{
    public partial class UC_AssignInstructorToCourse : UserControl
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
        public UC_AssignInstructorToCourse()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnOpen(object sender, EventArgs e)
        {
            OpenConnection();
            OracleDataAdapter adapter;
            DataSet ds;
            string cmdstr = @"select id from instructors";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(row[0].ToString());
            }
            cmdstr = @"select name from courses";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBox2.Items.Add(row[0].ToString());
            }
            CloseConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            OracleDataAdapter adapter;
            DataSet ds;
            string cmdstr = @"select * from courses";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds, "courses");

            int instructorid = Convert.ToInt32(comboBox1.SelectedItem);
            string course = comboBox2.Text;

            DataTable courseTable = ds.Tables["Courses"];
            DataRow targetRow = courseTable.AsEnumerable()
                .FirstOrDefault(row => row["Name"].ToString().Equals(course, StringComparison.OrdinalIgnoreCase));

            if (targetRow != null)
            {
                targetRow["InstructorId"] = instructorid;
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(adapter);
                adapter.Update(ds, "Courses");
                MessageBox.Show("Instructor assigned to course successfully.");
            }
            else
            {
                MessageBox.Show("Course not found.");
            }
            CloseConnection();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
