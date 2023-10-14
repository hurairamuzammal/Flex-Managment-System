using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPages.Teacher
{
    public partial class teacher2 : Form
    {
        bool sidebarExpand;
        Teacher_AssignGrades assignGrades;
        Teachers_timeTable timeTable;
        Teacher_AssignMarks assignMarks;
        Teacher_MarkAttandance markAttandance;

        public teacher2()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            teacher_login teacher_Login = new teacher_login();
            teacher_Login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //      if sidebar is expand
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    //adjusting size of all buttons
                    Assign_marks.Width = sidebar.Width;
                    time_Table.Width = sidebar.Width;
                    asign_grades.Width = sidebar.Width;
                    Mark_attandance.Width = sidebar.Width;
                    back_button.Width = sidebar.Width;


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
                    Assign_marks.Width = sidebar.Width;
                    time_Table.Width = sidebar.Width;
                    asign_grades.Width = sidebar.Width;
                    Mark_attandance.Width = sidebar.Width;
                    back_button.Width = sidebar.Width;



                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void teacher2_Load(object sender, EventArgs e)
        {

        }

        private void Mark_attandance_Click(object sender, EventArgs e)
        {
            if (markAttandance == null)
            {

                markAttandance = new Teacher_MarkAttandance();
                markAttandance.FormClosed += MarkAttandance_FormClosed;

                markAttandance.MdiParent = this;
                markAttandance.Show();

            }
            else markAttandance.Activate();
        }

        private void MarkAttandance_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void asign_grades_Click(object sender, EventArgs e)
        {
            if (assignGrades == null)
            {

                assignGrades = new Teacher_AssignGrades();
                assignGrades.FormClosed += AssignGrades_FormClosed;
                assignGrades.MdiParent = this;
                assignGrades.Show();


            }
            else assignGrades.Activate();
        }

        private void AssignGrades_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void Assign_marks_Click(object sender, EventArgs e)
        {
            if (assignMarks == null)
            {
                assignMarks = new Teacher_AssignMarks();
                assignMarks.FormClosed += AssignMarks_FormClosed;
                assignMarks.MdiParent = this;
                assignMarks.Show();
            }
            else assignMarks.Activate();
        }

        private void AssignMarks_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void time_Table_Click(object sender, EventArgs e)
        {
            if (timeTable == null)
            {
                timeTable = new Teachers_timeTable();
                timeTable.FormClosed += TimeTable_FormClosed;
                timeTable.MdiParent = this;
                timeTable.Show();

            }
            else timeTable.Activate();
        }

        private void TimeTable_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
