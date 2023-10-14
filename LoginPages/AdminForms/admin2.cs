using LoginPages.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPages
{
    public partial class admin2 : Form
    {
        admin2_add_student addStudent;
        admin2_edit_Student editStudent;
        admin2_edit_teacher editTeacher;
        admin2_add_teacher addTeacher;
        public admin2_view_student viewStudent;
        public admin2_view_teacher viewteacher;

        bool sidebarExpand;
        public static admin2 instance;
        public admin2()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void admin2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            admin_login admin = new admin_login();
            admin.Show();
            this.Hide();
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
                    edit_Student.Width = sidebar.Width;
                    edit_teacher.Width = sidebar.Width;
                    add_teachers.Width = sidebar.Width;
                    add_student.Width = sidebar.Width;
                    back_button.Width = sidebar.Width;
                    view_student.Width = sidebar.Width;
                    view_teacher.Width = sidebar.Width;
                    menuButton.Width = sidebar.Width;
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
                    edit_Student.Width = sidebar.Width;
                    edit_teacher.Width = sidebar.Width;
                    add_teachers.Width = sidebar.Width;
                    add_student.Width = sidebar.Width;
                    back_button.Width = sidebar.Width;
                    view_student.Width = sidebar.Width;
                    view_teacher.Width = sidebar.Width;
                    menuButton.Width = sidebar.Width;

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void edit_teacher_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void view_Students_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            admin_login form1 = new admin_login();
            form1.Show();
            this.Hide();
        }

        private void addteacher_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            admin_login admin = new admin_login();
            admin.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_student_Click(object sender, EventArgs e)
        {
            if (addStudent == null)
            {
                addStudent = new admin2_add_student();
                addStudent.FormClosed += AddStudent_FormClosed;
                addStudent.Dock = DockStyle.Fill;
                addStudent.MdiParent = this;
                addStudent.Show();

            }
            else addStudent.Activate();
        }

        private void AddStudent_FormClosed(object? sender, FormClosedEventArgs e)
        {
            addStudent = null;
        }

        private void add_teachers_Click(object sender, EventArgs e)
        {
            if (addTeacher == null)
            {
                addTeacher = new admin2_add_teacher();
                addTeacher.FormClosed += AddTeacher_FormClosed;
                addTeacher.MdiParent = this;
                addTeacher.Dock = DockStyle.Fill;
                addTeacher.Show();
            }
            else addTeacher.Activate();
        }

        private void AddTeacher_FormClosed(object? sender, FormClosedEventArgs e)
        {
            addTeacher = null;
        }

        private void edit_Student_Click(object sender, EventArgs e)
        {
            if (editStudent == null)
            {
                editStudent = new admin2_edit_Student();
                editStudent.FormClosed += EditStudent_FormClosed;
                editStudent.MdiParent = this;
                editStudent.Dock = DockStyle.Fill;
                editStudent.Show();
            }
            else editStudent.Activate();
        }

        private void EditStudent_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editStudent = null;
        }

        private void edit_teacher_Click_1(object sender, EventArgs e)
        {
            if (editTeacher == null)
            {
                editTeacher = new admin2_edit_teacher();
                editTeacher.FormClosed += Editteacher_FormClosed;
                editTeacher.MdiParent = this;
                editTeacher.Dock = DockStyle.Fill;
                editTeacher.Show();
            }
            else editTeacher.Activate();
        }

        private void Editteacher_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editTeacher = null;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_teacher_Click(object sender, EventArgs e)
        {
            if (viewteacher == null)
            {
                viewteacher = new admin2_view_teacher();
                viewteacher.FormClosed += Viewteacher_FormClosed;
                viewteacher.MdiParent = this;
                viewteacher.Dock = DockStyle.Fill;
                viewteacher.Show();

            }
            else viewteacher.Activate();
        }

        private void Viewteacher_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewteacher = null;
        }

        private void view_student_Click(object sender, EventArgs e)
        {
            if (viewStudent == null)
            {
                viewStudent = new admin2_view_student();
                viewStudent.FormClosed += ViewStudent_FormClosed;
                viewStudent.MdiParent = this;
                viewStudent.Dock = DockStyle.Fill;
                viewStudent.Show();
            }
            else viewStudent.Activate();
        }

        private void ViewStudent_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewStudent.Activate();
        }
    }
}


