namespace Soft
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignStudentToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignInstructorToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstructorToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.addCourseToolStripMenuItem,
            this.assignStudentToCourseToolStripMenuItem,
            this.assignInstructorToCourseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addInstructorToolStripMenuItem
            // 
            this.addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            this.addInstructorToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.addInstructorToolStripMenuItem.Text = "Add Instructor";
            this.addInstructorToolStripMenuItem.Click += new System.EventHandler(this.addInstructorToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // assignStudentToCourseToolStripMenuItem
            // 
            this.assignStudentToCourseToolStripMenuItem.Name = "assignStudentToCourseToolStripMenuItem";
            this.assignStudentToCourseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.assignStudentToCourseToolStripMenuItem.Text = "Assign Student To Course";
            this.assignStudentToCourseToolStripMenuItem.Click += new System.EventHandler(this.assignStudentToCourseToolStripMenuItem_Click);
            // 
            // assignInstructorToCourseToolStripMenuItem
            // 
            this.assignInstructorToCourseToolStripMenuItem.Name = "assignInstructorToCourseToolStripMenuItem";
            this.assignInstructorToCourseToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.assignInstructorToCourseToolStripMenuItem.Text = "Assign Instructor To Course";
            this.assignInstructorToCourseToolStripMenuItem.Click += new System.EventHandler(this.assignInstructorToCourseToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 422);
            this.pnlMain.TabIndex = 1;
            //this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignStudentToCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignInstructorToCourseToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}