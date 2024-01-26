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

namespace LoginPages.Admin
{
    public partial class admin2_view_teacher : Form
    {
        public admin2_view_teacher()
        {
            InitializeComponent();
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

        private void open_button_Click(object sender, EventArgs e)
        {
               DataTable dt = new DataTable();
               DirectoryInfo di = new DirectoryInfo("../../../../");
               string filePath = di.FullName.ToString() + "Flex\\EducationalPerson\\Teacher\\TeacherRecord.xlsx";
               int idInd = 0;
               string key = textsearch.Text;
               bool found = false;
               if (key == "")
               {
                    MessageBox.Show("Please enter the id of the Teacher you want to view");
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
               private void textsearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            { btnSearch.PerformClick(); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
