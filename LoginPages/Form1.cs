using LoginPages.Student;
using LoginPages.Teacher;
using System.ComponentModel;

namespace LoginPages
{

    public partial class Form1 : Form
    {

        public static Form1 instance;

        public Form1()
        {


            InitializeComponent();
            instance = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            admin_login adminForm = new admin_login();
            adminForm.Show();
            this.Hide();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_login student_Login = new student_login();
            student_Login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacher_login newform = new teacher_login();
            newform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}