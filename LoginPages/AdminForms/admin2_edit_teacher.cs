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
               DirectoryInfo di = new DirectoryInfo("../../../../");
               string filePath = di.FullName.ToString() + "Flex\\EducationalPerson\\Teacher\\TeacherRecord.xlsx";
               int idInd = 0;
               string key = textBox1.Text;
               bool found = false;
               if (key == "")
               {
                    MessageBox.Show("Please enter the id of the Teacher you want to edit");
               }

               using (XLWorkbook workbook = new XLWorkbook(filePath))
               {
                    bool isFirstRow = true;
                    var rows = workbook.Worksheet(1).RowsUsed();
                    foreach (var row in rows)
                    {
                         if (isFirstRow)
                         {
                              foreach (IXLCell cell in row.Cells())
                              {
                                   dt.Columns.Add(cell.Value.ToString());
                                   if (cell.Value.ToString() == "ID") { idInd = cell.Address.ColumnNumber; }
                              }
                              isFirstRow = false;

                         }
                         else
                         {
                              if (row.Cell(idInd).Value.ToString() == key)
                              {
                                   found = true;
                                   dt.Rows.Add();
                                   int i = 0;
                                   foreach (IXLCell cell in row.Cells())
                                        dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                              }
                              break;
                         }
                    }

                    if (found == false)
                    {
                         dt.Clear();
                         MessageBox.Show("No Teacher with this id exists");
                    }

                    dataGridView1.DataSource = dt.DefaultView;

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
