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

               DataTable dt = new DataTable();
               DirectoryInfo di = new DirectoryInfo("../../../../");
               string filePath = di.FullName.ToString() + "Flex\\EducationalPerson\\Student\\StudentRecord.xlsx";
               int idInd = 0;
               string key = textsearch.Text;
               bool found = false;
               if (key == "")
               {
                    MessageBox.Show("Please enter the roll number of the student you want to view");
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
                         MessageBox.Show("No student with this roll number exists");
                    }

                    dataGridView1.DataSource = dt.DefaultView;

                    Cursor.Current = Cursors.Default;

               }

           }
               private void button1_Click(object sender, EventArgs e)
          {
               //try
               //{
               //    DataView dv = dataGridView1.DataSource as DataView;
               //    if (dv != null)
               //    { dv.RowFilter = textsearch.Text; }
               //}
               //catch (Exception ex)
               //{ MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
          }

          private void label1_Click_1(object sender, EventArgs e)
          {

          }

          private void textsearch_KeyPress(object sender, KeyPressEventArgs e)
          {
          
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void textsearch_TextChanged(object sender, EventArgs e)
          {
          }

          private void admin2_view_student_Load(object sender, EventArgs e)
          {

          }
     }
}

