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
        public UC_AssignInstructorToCourse()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
