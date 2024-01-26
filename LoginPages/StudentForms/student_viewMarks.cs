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

namespace LoginPages.Student
{
    public partial class student_viewMarks : Form
    {
          string rollno;
        public student_viewMarks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void open_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
               DirectoryInfo di = new DirectoryInfo("../../../../");
               string filePath = di.FullName.ToString() + "Flex\\EducationalPerson\\Student\\StudentRecord.xlsx";

               using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(rollno+"(Marks)").RowsUsed();
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
                lblTotal.Text = $"Total records:{dataGridView1.RowCount}";
                Cursor.Current = Cursors.Default;

            }
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSerach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerach.PerformClick();
            }
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
               rollno = textsearch.Text;
        }
    }
}
