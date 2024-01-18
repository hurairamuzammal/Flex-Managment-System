using DocumentFormat.OpenXml.Bibliography;
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
namespace LoginPages
{
    public partial class admin2_add_student : Form
    {
        string username, password, f_name, l_name, dept, id, contact, qualification, address, marks, regisDate, bloodgroup, feeStatus, gender;
        public admin2_add_student()
        {
            InitializeComponent();
        }

        private void admin2_add_student_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            feeStatus = fee_box.Text;
        }

        private void fn_Box_TextChanged(object sender, EventArgs e)
        {
            f_name = fn_Box.Text;
        }

        private void ln_box_TextChanged(object sender, EventArgs e)
        {
            l_name = ln_box.Text;
        }

        private void dp_box_TextChanged(object sender, EventArgs e)
        {
            dept = dp_box.Text;
        }

        private void contact_box_TextChanged(object sender, EventArgs e)
        {
            contact = contact_box.Text;
        }

        private void rn_box_TextChanged(object sender, EventArgs e)
        {
            id = rn_box.Text;
        }

        private void reg_box_TextChanged(object sender, EventArgs e)
        {
            regisDate = reg_box.Text;
        }

        private void gen_box_TextChanged(object sender, EventArgs e)
        {
            gender = gen_box.Text;
        }

        private void qual_box_TextChanged(object sender, EventArgs e)
        {
            qualification = qual_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            address = address_box.Text;
        }

        private void blood_box_TextChanged(object sender, EventArgs e)
        {
            bloodgroup = blood_box.Text;
        }

        private void marks_box_TextChanged(object sender, EventArgs e)
        {
            marks = marks_box.Text;
        }

        private void un_box_TextChanged(object sender, EventArgs e)
        {
            username = un_box.Text;
        }

        private void ps_box_TextChanged(object sender, EventArgs e)
        {
            password = ps_box.Text;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            StudentClass student = new StudentClass();
            bool res = student.addToRecord(f_name, l_name, dept, id, regisDate, gender, contact, qualification, address, bloodgroup, feeStatus, marks, username, password);

               if (res) MessageBox.Show("Student Registered Successfully");
               else MessageBox.Show("Unknown Error, Student not registered");
        }
    }
}
