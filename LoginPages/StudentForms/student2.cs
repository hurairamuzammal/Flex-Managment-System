using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPages.Student
{
    public partial class student2 : Form
    {
        bool sidebarExpand = true;
        student_viewAttandance viewAttandance;
        student_viewFee viewFee;
        student_viewGrades viewGrades;
        student_viewMarks viewMarks;
        public student2()
        {
            InitializeComponent();
        }

        private void add_student_Click(object sender, EventArgs e)
        {

        }

        private void student2_Load(object sender, EventArgs e)
        {

        }

        private void edit_teacher_Click(object sender, EventArgs e)
        {
            if (viewFee == null)
            {
                viewFee = new student_viewFee();
                viewFee.FormClosed += ViewFee_FormClosed;
                viewFee.MdiParent = this;
                viewFee.Show();
            }
        }

        private void ViewFee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewFee = null;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            student_login student_loginform = new student_login();
            student_loginform.Show();
            this.Hide();
        }

        private void view_marks_Click(object sender, EventArgs e)
        {
            if (viewMarks == null)
            {
                viewMarks = new student_viewMarks();
                viewMarks.FormClosed += ViewMarks_FormClosed;
                viewMarks.MdiParent = this;
                viewMarks.Show();
            }
        }

        private void ViewMarks_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewMarks = null;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    //adjusting size of all buttons



                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    //adjusting size of all buttons



                }
            }


        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void view_grades_Click(object sender, EventArgs e)
        {

            if (viewGrades == null)
            {
                viewGrades = new student_viewGrades();
                viewGrades.FormClosed += ViewGrades_FormClosed;
                viewGrades.MdiParent = this;
                viewGrades.Show();

            }
            else { viewGrades.Activate(); }
        }

        private void ViewGrades_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewGrades = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view_attandance_Click(object sender, EventArgs e)
        {
            if (viewAttandance == null)
            {
                viewAttandance = new student_viewAttandance();
                viewAttandance.FormClosed += ViewAttandance_FormClosed;
                viewAttandance.MdiParent = this;
                viewAttandance.Show();
            }
            else { viewAttandance.Activate(); }
        }

        private void ViewAttandance_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewAttandance = null;
        }
    }
}
