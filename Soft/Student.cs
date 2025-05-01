using Soft.InstructorUserControls;
using Soft.StudentUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        private void Student_FormClosing(object sender, FormClosingEventArgs e)
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
        private void seeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_SeeAttendance uc = new UC_SeeAttendance();
            addUserControl(uc);
        }
        private void countAbscenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_CountAbscence uc = new UC_CountAbscence();
            addUserControl(uc);
        }
    }
}
