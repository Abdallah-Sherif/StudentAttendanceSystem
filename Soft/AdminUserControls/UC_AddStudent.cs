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
    public partial class UC_AddStudent : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection con;
        public UC_AddStudent()
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
            cmd.CommandText = "AddStudents";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", textBox2.Text);
            cmd.Parameters.Add("pass", textBox3.Text);
            //cmd.CommandType = CommandType.Text;

            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Student Added Successfully");
            CloseConnection();
        }
    }
}
