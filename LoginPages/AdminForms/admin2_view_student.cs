using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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

    public partial class admin2_view_student : Form
    {

        public admin2_view_student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //open button
        {
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        Cursor.Current = Cursors.WaitCursor;
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
                lblTotal.Text = $"Total records:{dataGridView1.RowCount}";
                Cursor.Current = Cursors.Default;

            }
            //    }
            //}
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            { btnSerach.PerformClick(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

