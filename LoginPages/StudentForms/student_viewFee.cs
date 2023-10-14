using Flex.EducationalPerson.student;
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
    public partial class student_viewFee : Form
    {
        string rollnumber;
        public student_viewFee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rollnumber = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass studentClass = new StudentClass();
            studentClass = studentClass.Search("ID",rollnumber);
            MessageBox.Show(studentClass.getFeeStatus());
        }
    }
}
