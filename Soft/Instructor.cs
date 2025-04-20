using Soft.InstructorUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Soft
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
        }
        private void Instructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void takeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_TakeAttendance uc = new UC_TakeAttendance();
            addUserControl(uc);
        }
    }
}
