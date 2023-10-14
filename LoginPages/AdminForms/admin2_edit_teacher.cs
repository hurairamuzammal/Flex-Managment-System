using ClosedXML.Excel;
using Flex.EducationalPerson.student;
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

namespace LoginPages
{
    public partial class admin2_edit_teacher : Form
    {
        string Qualification, salary, address, contactnumber, tId;
        public admin2_edit_teacher()
        {
            InitializeComponent();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                { dv.RowFilter = textsearch.Text; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook("C:/Users/Huraira/source/repos/Flex/EducationalPerson/Teacher/TeacherRecord.xlsx"))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(1).RowsUsed();
                foreach (var row in rows)
                {
                    if (isFirstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                            dt.Columns.Add(cell.Value.ToString());
                        isFirstRow = false;

                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                            dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                    }
                }
                dataGridView1.DataSource = dt.DefaultView;
                // lblTotal.Text = $"Total records:{dataGridView1.RowCount}";
                Cursor.Current = Cursors.Default;

            }
        }

        private void qualification_box_TextChanged(object sender, EventArgs e)
        {
            Qualification = qualification_box.Text;
        }

        private void salary_box_TextChanged(object sender, EventArgs e)
        {
            salary = salary_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            address = address_box.Text;
        }

        private void contact_box_TextChanged(object sender, EventArgs e)
        {
            contactnumber = contact_box.Text;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            TeacherClass teacher = new TeacherClass();
            teacher = teacher.Search("ID", tId);
            if (teacher.editTeacher("ID", "Qualification", tId, Qualification) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            if (teacher.editTeacher("ID", "Address", tId, address) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            //if (teacher.editTeacher("ID", "Salary", tId, salary) != true)
            //{
            //    MessageBox.Show("It could not be edited due to some reasons");
            //}
            if (teacher.editTeacher("ID", "Contact", tId, contactnumber) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tId = textBox1.Text;
        }
    }
}
