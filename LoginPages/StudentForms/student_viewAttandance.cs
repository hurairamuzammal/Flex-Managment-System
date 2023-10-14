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
    public partial class student_viewAttandance : Form
    {
        string rollNo;
        public student_viewAttandance()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void open_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook("C:/Users/Huraira/source/repos/Flex/EducationalPerson/Student/StudentRecord.xlsx"))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(rollNo).RowsUsed();
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
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                { dv.RowFilter = textsearch.Text; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerach.PerformClick();
            }
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            rollNo = textsearch.Text;   
        }
    }
}
