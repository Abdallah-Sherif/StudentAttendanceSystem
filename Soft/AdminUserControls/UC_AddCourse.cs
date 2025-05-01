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
            string cmd = @"Select * from courses";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd, ordb);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "courses");
            DataRow newRow = ds.Tables[0].NewRow();
            newRow["name"] = textBox2.Text.ToString();

            ds.Tables[0].Rows.Add(newRow);

            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds, "courses");
            MessageBox.Show("Course Added Successfully");
            CloseConnection();
        }
    }
}
