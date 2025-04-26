using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Soft.AdminUserControls
{
    public partial class UC_AddInstructor : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection con;
        public UC_AddInstructor()
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
            cmd.CommandText = "insert into instructors(username, userpassword) Values(:us, :pas)";
            cmd.Parameters.Add("us", textBox2.Text);
            cmd.Parameters.Add("pas", textBox3.Text);
            //cmd.CommandType = CommandType.Text;

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Instructor Added Successfully");
            }
            else
            {
                MessageBox.Show("Error Adding Instructor");
            }
            CloseConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
