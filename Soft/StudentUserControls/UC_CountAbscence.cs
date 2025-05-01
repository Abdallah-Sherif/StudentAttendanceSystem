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
using Oracle.DataAccess.Types;

namespace Soft.StudentUserControls
{
    public partial class UC_CountAbscence : UserControl
    {
        public UC_CountAbscence()
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
        private void CountAbscneceLoad(object sender, EventArgs e)
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
            OracleDataAdapter adapter;
            DataSet ds;
            string cmdstr;
            cmdstr = @"select name from courses";
            adapter = new OracleDataAdapter(cmdstr, con);
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
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "CountAbscence";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("studentName", OracleDbType.Varchar2).Value = comboBox1.Text;
            cmd.Parameters.Add("courseName", OracleDbType.Varchar2).Value = comboBox2.Text;
            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            try
            {
                OracleDecimal val = (OracleDecimal)cmd.Parameters["count"].Value;
                int cnt = val.ToInt32();
                MessageBox.Show("The number of absences is: " + cnt.ToString());
            }
            catch
            {
                MessageBox.Show("Error: The student is not registered in this course.");
            }
            CloseConnection();
        }
    }
}
