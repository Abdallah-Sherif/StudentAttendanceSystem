using Soft.AdminUserControls;
using Soft.InstructorUserControls;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_AddInstructor uc = new UC_AddInstructor();
            addUserControl(uc);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_AddStudent uc = new UC_AddStudent();
            addUserControl(uc);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_AddCourse uc = new UC_AddCourse();
            addUserControl(uc);
        }

        private void assignInstructorToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_AssignInstructorToCourse uc = new UC_AssignInstructorToCourse();
            addUserControl(uc);
        }
        private void assignStudentToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignStudentToCourse uc = new AssignStudentToCourse();
            addUserControl(uc);
        }

    }
}
