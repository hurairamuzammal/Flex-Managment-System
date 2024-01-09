using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flex.EducationalPerson.teacher;
namespace LoginPages.Teacher
{
    public partial class teacher_login : Form
    {
        string username, password;
        public teacher_login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherClass teacher = new TeacherClass();
            
            teacher = teacher.Search(username, password);
            if(teacher==null) { MessageBox.Show("Wrong Username or Password!");return; }
            if (teacher.getPassword() == password)
            {
                teacher2 teacher2 = new teacher2();
                teacher2.Show();
                this.Hide();
            } 
        }
    }
}
