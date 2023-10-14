using Flex.EducationalPerson.teacher;
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
    public partial class Teacher_MarkAttandance : Form
    {
        string rollnumber, subject, attandance;
        public Teacher_MarkAttandance()
        {
            InitializeComponent();
        }

        private void Teacher_MarkAttandance_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rollnumber = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            subject = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            attandance = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherClass teacher = new TeacherClass();  
            teacher.markStudentAttendance(rollnumber, subject, attandance);
           
        }
    }
}
