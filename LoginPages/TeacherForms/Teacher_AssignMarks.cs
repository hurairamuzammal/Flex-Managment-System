using ClosedXML.Excel;
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
    public partial class Teacher_AssignMarks : Form
    {
        string rollno, marks, subject;
        public Teacher_AssignMarks()
        {
            InitializeComponent();
        }

        private void Teacher_AssignMarks_Load(object sender, EventArgs e)
        {
            marks = marks_box.Text;
        }

        private void RollNo_box_TextChanged(object sender, EventArgs e)
        {
            marks = RollNo_box.Text;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();

            //using (XLWorkbook workbook = new XLWorkbook("C:/Users/Huraira/source/repos/Flex/EducationalPerson/Student/StudentRecord.xlsx"))
            //{
            //    IXLWorksheet worksheet;
            //    if (workbook.TryGetWorksheet((rollno + "(Marks)"), out worksheet))
            //    {
            //        MessageBox.Show("File is opened");
            //        bool isFirstRow = true;
            //        var rows = worksheet.RowsUsed();

            //        foreach (var row in rows)
            //        {
            //            if (isFirstRow)
            //            {
            //                foreach (IXLCell cell in row.Cells())
            //                    dt.Columns.Add(cell.Value.ToString());
            //                isFirstRow = false;
            //            }
            //            else
            //            {
            //                dt.Rows.Add();
            //                int i = 0;
            //                foreach (IXLCell cell in row.Cells())
            //                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
            //            }
            //        }

            //        // Perform actions on the DataTable
            //        // Example: Print the data in the DataTable
            //        foreach (DataRow dataRow in dt.Rows)
            //        {
            //            foreach (var item in dataRow.ItemArray)
            //                Console.Write(item.ToString() + "\t");
            //            Console.WriteLine();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sheet not found!");
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
            rollno = RollNo_box.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rollno = RollNo_box.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerach.PerformClick();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
