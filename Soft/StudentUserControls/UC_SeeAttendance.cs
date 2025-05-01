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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Soft.StudentUserControls
{
    public partial class UC_SeeAttendance : UserControl
    {
        public UC_SeeAttendance()
        {
            InitializeComponent();
        }
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
        private void SeeAttendanceLoad(object sender, EventArgs e)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetAllStudents";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("students", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataAdapter adapter;
            DataSet ds;

            string cmdstr = "SELECT * FROM classes, students WHERE students.id = classes.studentid AND students.username = :userr";
            OpenConnection();
            adapter = new OracleDataAdapter(cmdstr,ordb);
            adapter.SelectCommand.Parameters.Add("userr", comboBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            CloseConnection();
        }
    }
}
