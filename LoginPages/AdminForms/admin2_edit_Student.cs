using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class admin2_edit_Student : Form
    {
        string f_name, l_name, address, feestatus, contact, rollNo;
        public admin2_edit_Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin2_edit_Student_Load(object sender, EventArgs e)
        {

        }

        private void open_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook("C:/Users/Huraira/source/repos/Flex/EducationalPerson/Student/StudentRecord.xlsx"))
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
            //    }
            //}
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

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rollNo = textBox1.Text;
        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {
            f_name = first_name.Text;
        }

        private void fn_name_TextChanged(object sender, EventArgs e)
        {
            l_name = fn_name.Text;
        }

        private void fee_status_TextChanged(object sender, EventArgs e)
        {
            feestatus = fee_status.Text;
        }

        private void contact_box_TextChanged(object sender, EventArgs e)
        {
            contact = contact_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            address = address_box.Text;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            StudentClass student = new StudentClass();
            student = student.Search("ID", rollNo);
            if (student.editStudent("ID", "FirstName", rollNo, f_name) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            if (student.editStudent("ID", "LastName", rollNo, l_name) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            if (student.editStudent("ID", "FeeStatus", rollNo, feestatus) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            if (student.editStudent("ID", "Contact", rollNo, contact) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }
            if (student.editStudent("ID", "Address", rollNo, address) != true)
            {
                MessageBox.Show("It could not be edited due to some reasons");
            }


        }
    }
}
