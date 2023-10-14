using DocumentFormat.OpenXml.Bibliography;
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

namespace LoginPages.Admin
{
    public partial class admin2_add_teacher : Form
    {
        string username, password, f_name, l_name, dept, id, contact, qualification, address, regisDate, gender;
        public admin2_add_teacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void marks_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void fee_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void blood_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            TeacherClass teacher = new TeacherClass();
            teacher.addToRecord(f_name, l_name, dept, id, regisDate, gender, contact, qualification, address, "", "", "", username, password);
            MessageBox.Show("Teacher registered successfully...");
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void un_box_TextChanged(object sender, EventArgs e)
        {
            username = un_box.Text;
        }

        private void ps_box_TextChanged(object sender, EventArgs e)
        {
            password = ps_box.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            address = address_box.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void contact_box_TextChanged(object sender, EventArgs e)
        {
            contact = contact_box.Text;
        }

        private void qual_box_TextChanged(object sender, EventArgs e)
        {
            qualification = qual_box.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void gen_box_TextChanged(object sender, EventArgs e)
        {
            gender = gen_box.Text;
        }

        private void reg_box_TextChanged(object sender, EventArgs e)
        {
            regisDate = reg_box.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void rn_box_TextChanged(object sender, EventArgs e)
        {
            id = rn_box.Text;
        }

        private void dp_box_TextChanged(object sender, EventArgs e)
        {
            dept = dp_box.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void ln_box_TextChanged(object sender, EventArgs e)
        {
            l_name = ln_box.Text;
        }

        private void fn_Box_TextChanged(object sender, EventArgs e)
        {
            f_name = fn_Box.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }
    }
}
