using ClosedXML.Excel;
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
    public partial class Teacher_AssignGrades : Form
    {
        string rollNo, grade, subject;
        public Teacher_AssignGrades()
        {
            InitializeComponent();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            rollNo = RollNo_box.Text;
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
            using (XLWorkbook workbook = new XLWorkbook("C:/Users/Huraira/source/repos/Flex/EducationalPerson/Student/StudentRecord.xlsx"))
            {
                IXLWorksheet worksheet = workbook.Worksheet((rollNo + "(Marks)"));

                if (worksheet != null)
                {
                    MessageBox.Show("Hello");
                    bool isFirstRow = true;
                    var rows = worksheet.RowsUsed();

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

                    // Perform actions on the DataTable
                    // Example: Print the data in the DataTable
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        foreach (var item in dataRow.ItemArray)
                            Console.Write(item.ToString() + "\t");
                        Console.WriteLine();
                    }
                }
                else
                {
                    MessageBox.Show("Sheet not found!");
                }
            }
        }

        private void RollNo_box_TextChanged(object sender, EventArgs e)
        {
            subject = RollNo_box.Text;


        }

        private void marks_box_TextChanged(object sender, EventArgs e)
        {
            grade = marks_box.Text;
        }

        private void assign_button_Click(object sender, EventArgs e)
        {
            TeacherClass teacher = new TeacherClass();
            if (teacher.assignStudentGrade(rollNo, DateTime.Now, subject, grade) == "marked")
            {
                MessageBox.Show("Grades already marked ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rollNo = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rollNo = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void open_button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerach.PerformClick();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(rollNo + " " + subject + " " + grade);
       
            TeacherClass teacher = new TeacherClass();
            string? status = teacher.assignStudentGrade(rollNo, new DateTime(2023, 6, 25), subject, grade);
            if (status == "marked")
            {
                MessageBox.Show("Grades already marked ");
            }
        }

        private void RollNo_box_TextChanged_1(object sender, EventArgs e)
        {
            subject = RollNo_box.Text;
        }

        private void marks_box_TextChanged_1(object sender, EventArgs e)
        {
            grade = marks_box.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            rollNo = textBox1.Text;
        }
    }
}
