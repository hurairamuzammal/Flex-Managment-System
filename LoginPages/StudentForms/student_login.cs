using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flex.EducationalPerson.student;
namespace LoginPages.Student
{

    public partial class student_login : Form
    {
        string username, password;
        public student_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass student = new StudentClass();

            student = student.Login(username, password);
            if (student == null)
            {
                MessageBox.Show("Enter valid username and password");
                return;
            }
            else
            if (student.getPassword() == password)
            {
                student2 student2 = new student2();
                student2.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
