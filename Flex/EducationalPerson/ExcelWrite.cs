using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.IO; // Add the System.IO namespace for file operations
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;



namespace Flex.EducationalPerson
{
    public class TestModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public string id { get; set; }
        public string regisDate { get; set; }
        public string gender { get; set; }
        public string contact { get; set; }
        public string qualification { get; set; }
        public string address { get; set; }
        public string bloodGroup { get; set; }
        public string feeStatus { get; set; }
        public string marks { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public TestModel()
        {
            firstName = "";
            lastName = "";
            department = "";
            id = "";
            regisDate = "";
            gender = "";
            contact = "";
            qualification = "";
            address = "";
            bloodGroup = "";
            feeStatus = "";
            marks = "";
            username = "";
            password = "";
        }
    }

    public class TestModelList
    {
        public List<TestModel> testData { get; set; }
    }

    public class RowData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Id { get; set; }
        public string RegisDate { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string FeeStatus { get; set; }
        public string Marks { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // member method to set RowData attributes with the row data from the excel file
        public void AddCellValue(string cellValue, int cellIndex)
        {
            switch (cellIndex)
            {
                case 1:
                    FirstName = cellValue;
                    break;
                case 2:
                    LastName = cellValue;
                    break;
                case 3:
                    Department = cellValue;
                    break;
                case 4:
                    Id = cellValue;
                    break;
                case 5:
                    RegisDate = cellValue;
                    break;
                case 6:
                    Gender = cellValue;
                    break;
                case 7:
                    Contact = cellValue;
                    break;
                case 8:
                    Qualification = cellValue;
                    break;
                case 9:
                    Address = cellValue;
                    break;
                case 10:
                    BloodGroup = cellValue;
                    break;
                case 11:
                    FeeStatus = cellValue;
                    break;
                case 12:
                    Marks = cellValue;
                    break;
                case 13:
                    Username = cellValue;
                    break;
                case 14:
                    Password = cellValue;
                    break;
                default:
                    break;
            }
        }

    }
    public class TeacherRowData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Id { get; set; }
        public string RegisDate { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // member method to set RowData attributes with the row data from the excel file
        public void AddCellValue(string cellValue, int cellIndex)
        {
            switch (cellIndex)
            {
                case 1:
                    FirstName = cellValue;
                    break;
                case 2:
                    LastName = cellValue;
                    break;
                case 3:
                    Department = cellValue;
                    break;
                case 4:
                    Id = cellValue;
                    break;
                case 5:
                    RegisDate = cellValue;
                    break;
                case 6:
                    Gender = cellValue;
                    break;
                case 7:
                    Contact = cellValue;
                    break;
                case 8:
                    Qualification = cellValue;
                    break;
                case 9:
                    Address = cellValue;
                    break;
                case 10:
                    Username = cellValue;
                    break;
                case 11:
                    Password = cellValue;
                    break;
                default:
                    break;
            }
        }

    }




    public class ExcelWrite
    {
        private string fileName;
        private int rowIndex;

        public ExcelWrite()
        {
            rowIndex = 1;
        }

        public void CreateExcelFile(TestModelList data, string OutPutFileDirectory, string fileName, string sheetName)
        {
            string fileFullname = Path.Combine(OutPutFileDirectory, fileName);
            fileName = fileFullname;

            if (File.Exists(fileFullname))
            {
                using (SpreadsheetDocument package = SpreadsheetDocument.Open(fileFullname, true))
                {
                    // Get the sheet data from the existing file
                    SheetData existingSheetData = GetSheetData(package);

                    // Get the row index of the last row in the existing sheet
                    uint rowIndex = (uint)existingSheetData.Elements<Row>().Count();

                    // Generate sheet data for the new details, starting from the next row
                    SheetData newSheetData = GenerateSheetdataForDetails(data, rowIndex + 1);

                    // Append the new sheet data to the existing sheet data
                    existingSheetData.Append(newSheetData.Elements<Row>().Select(r => r.CloneNode(true)));
                    // Flush the data to disk
                    package.WorkbookPart.WorksheetParts.First().Worksheet.Save();
                    package.Save();

                    // Close the package
                    package.Close();
                }
            }
            else // create a new file
            {
                using (SpreadsheetDocument package = SpreadsheetDocument.Create(fileFullname, SpreadsheetDocumentType.Workbook))
                {
                    CreatePartsForExcel(package, data, sheetName);

                    // Flush the data to disk
                    package.WorkbookPart.WorksheetParts.First().Worksheet.Save();
                    package.Save();

                    // Close the package
                    package.Close();
                }
            }
        }



        // function to create the attendance sheet
        public void CreateAttendanceSheet(string rollNumber, string fileName, string[] subjects)
        {
            // Open the existing workbook
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, true))
            {
                // Add the new worksheet to the workbook
                WorkbookPart workbookPart = document.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Set the name of the new worksheet to the student's roll number
                string sheetName = rollNumber;
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = (uint)(workbookPart.Workbook.Sheets.Count() + 1), Name = sheetName };
                workbookPart.Workbook.Sheets.Append(sheet);

                // Create the header row with the first cell having value "Date" and the others having the values in the subjects array
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                Row headerRow = new Row() { RowIndex = 1 };
                headerRow.Append(CreateCell("Date", 2U, 1, 1));
                for (int i = 0; i < subjects.Length; i++)
                {
                    Console.WriteLine(subjects[i]);
                    headerRow.Append(CreateCell(subjects[i], 2U, i + 2, 1));
                }
                sheetData.Append(headerRow);

                // Save the changes and close the workbook
                workbookPart.Workbook.Save();
                document.Close();
            }
        }

        // function to create the marks sheet

        public void CreateMarksSheet(string rollNumber, string fileName, string[] subjects)
        {
            // Open the existing workbook
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, true))
            {
                // Add the new worksheet to the workbook
                WorkbookPart workbookPart = document.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Set the name of the new worksheet to the student's roll number
                string sheetName = rollNumber + "(Marks)";
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = (uint)(workbookPart.Workbook.Sheets.Count() + 1), Name = sheetName };
                workbookPart.Workbook.Sheets.Append(sheet);

                // Create the header row with the first cell having value "Date" and the others having the values in the subjects array
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                Row headerRow = new Row() { RowIndex = 1 };
                headerRow.Append(CreateCell("Date", 2U, 1, 1));
                for (int i = 0; i < subjects.Length; i++)
                {
                    Console.WriteLine(subjects[i]);
                    headerRow.Append(CreateCell(subjects[i], 2U, i + 2, 1));
                }
                sheetData.Append(headerRow);

                // Save the changes and close the workbook
                workbookPart.Workbook.Save();
                document.Close();
            }
        }


        public string markAttendance(string filePath, string rollNo, DateTime date, string subject, string attendance)
        {
            // Open the Excel file using ClosedXML
            var workbook = new XLWorkbook(filePath);

            // Check if the sheet exists
            if (!workbook.TryGetWorksheet(rollNo, out var sheet))
            {
                return "Sheet not found";
            }

            // Find the index of the column representing the subject
            var subjectColumnIndex = sheet.FirstRow().CellsUsed(c => c.Value.ToString() == subject).First().WorksheetColumn().ColumnNumber();

            // Find the existing row with the specified date, if any
            var existingRow = sheet.RowsUsed(r => r.Cell(1).Value.ToString() == date.ToString("dd-MM-yyyy")).FirstOrDefault();

            if (existingRow != null)
            {
                // Check if the attendance for the subject is already marked
                var existingAttendance = existingRow.Cell(subjectColumnIndex).Value.ToString();
                if (!string.IsNullOrWhiteSpace(existingAttendance))
                {
                    return "marked";
                }

                // Mark the attendance and center-align the value
                var attendanceCell = existingRow.Cell(subjectColumnIndex);
                attendanceCell.Value = attendance;
                attendanceCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }
            {
                // Get the number of cells in the first row
                var cellCount = sheet.FirstRow().CellsUsed().Count();

                // Find the last used row in the sheet
                var lastUsedRow = sheet.LastRowUsed();

                // Insert a new row after the last used row
                var newRow = lastUsedRow.RowBelow();

                // Set the first cell of the new row to the specified date
                newRow.Cell(1).Value = date.ToString("dd-MM-yyyy");

                // Set the attendance value in the subject column of the new row and center-align it
                var attendanceCell = newRow.Cell(subjectColumnIndex);
                attendanceCell.Value = attendance;
                attendanceCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            // Save the changes to the Excel file
            workbook.Save();

            return "Attendance marked";
        }


        public string assignMarks(string filePath, string rollNo, DateTime date, string subject, string marks)
        {
            // Open the Excel file using ClosedXML
            var workbook = new XLWorkbook(filePath);

            // Check if the sheet exists
            if (!workbook.TryGetWorksheet((rollNo + "(Marks)"), out var sheet))
            {
                return "Sheet not found";
            }

            // Find the index of the column representing the subject
            var subjectColumnIndex = sheet.FirstRow().CellsUsed(c => c.Value.ToString() == subject).First().WorksheetColumn().ColumnNumber();

            // Find the existing row with the specified date, if any
            var existingRow = sheet.RowsUsed(r => r.Cell(1).Value.ToString() == date.ToString("dd-mm-yyyy")).FirstOrDefault();

            if (existingRow != null)
            {
                // Check if the attendance for the subject is already marked
                var existingAttendance = existingRow.Cell(subjectColumnIndex).Value.ToString();
                if (!string.IsNullOrWhiteSpace(existingAttendance))
                {
                    return "marked";
                }

                // Mark the attendance and center-align the value
                var attendanceCell = existingRow.Cell(subjectColumnIndex);
                attendanceCell.Value = marks;
                attendanceCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }
            else
            {
                // Get the number of cells in the first row
                var cellCount = sheet.FirstRow().CellsUsed().Count();

                // Find the last used row in the sheet
                var lastUsedRow = sheet.LastRowUsed();

                // Insert a new row after the last used row
                var newRow = lastUsedRow.RowBelow();

                // Set the first cell of the new row to the specified date
                newRow.Cell(1).Value = date.ToString("dd-MM-yyyy");

                // Set the attendance value in the subject column of the new row and center-align it
                var attendanceCell = newRow.Cell(subjectColumnIndex);
                attendanceCell.Value = marks;
                attendanceCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            // Save the changes to the Excel file
            workbook.Save();

            return "Successfully marked";
        }

        public void editInFile(string fileName, string sheetName, string searchValue, string searchValue2, string searchValueKey, string edit)
        {
            // Open the Excel file using ClosedXML
            var workbook = new XLWorkbook(fileName);

            // Find the specified sheet
            var sheet = workbook.Worksheet(sheetName);

            // Find the column index for searchValue
            var columnIndex = sheet.FirstRow().CellsUsed(c => c.Value.ToString() == searchValue).First().WorksheetColumn().ColumnNumber();

            // Find the column index for searchValue2
            var columnIndex2 = sheet.FirstRow().CellsUsed(c => c.Value.ToString() == searchValue2).First().WorksheetColumn().ColumnNumber();

            // Find the row index for searchValueKey in the specific column
            var row = sheet.RowsUsed(r => r.Cell(columnIndex).Value.ToString() == searchValueKey).FirstOrDefault();

            if (row != null)
            {
                // Get the cell in the same row and columnIndex2 and set its value to 'edit'
                row.Cell(columnIndex2).Value = edit;
            }

            // Save the changes to the Excel file
            workbook.Save();
        }

        private SheetData GetSheetData(SpreadsheetDocument document)
        {
            WorksheetPart worksheetPart = document.WorkbookPart.WorksheetParts.First();
            return worksheetPart.Worksheet.GetFirstChild<SheetData>();
        }

        private SheetData CombineSheetData(SheetData existingData, SheetData newData)
        {
            foreach (var childElement in newData.ChildElements)
            {
                var clonedChild = (OpenXmlElement)childElement.CloneNode(true);
                existingData.Append(clonedChild);
            }
            return existingData;
        }

        private void CreatePartsForExcel(SpreadsheetDocument document, TestModelList data, string sheetName)
        {
            SheetData partSheetData = GenerateSheetdataForDetails(data, fileName);

            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPartContent(workbookPart1, sheetName);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
            GenerateWorkbookStylesPartContent(workbookStylesPart1);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPartContent(worksheetPart1, partSheetData);
        }

        private void GenerateWorkbookPartContent(WorkbookPart workbookPart1, string sheetName)
        {
            Workbook workbook1 = new Workbook();
            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet() { Name = sheetName, SheetId = (UInt32Value)1U, Id = "rId1" };
            sheets1.Append(sheet1);
            workbook1.Append(sheets1);
            workbookPart1.Workbook = workbook1;
        }

        private void GenerateWorksheetPartContent(WorksheetPart worksheetPart1, SheetData sheetData1)
        {
            Worksheet worksheet1 = new Worksheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            SheetDimension sheetDimension1 = new SheetDimension() { Reference = "A1" };

            SheetViews sheetViews1 = new SheetViews();

            SheetView sheetView1 = new SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };
            Selection selection1 = new Selection() { ActiveCell = "A1", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "A1" } };

            sheetView1.Append(selection1);

            sheetViews1.Append(sheetView1);
            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

            PageMargins pageMargins1 = new PageMargins() { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(pageMargins1);
            worksheetPart1.Worksheet = worksheet1;
        }


        private void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

            Fonts fonts1 = new Fonts() { Count = (UInt32Value)2U, KnownFonts = true };

            Font font1 = new Font();
            FontSize fontSize1 = new FontSize() { Val = 11D };
            Color color1 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName1 = new FontName() { Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering1 = new FontFamilyNumbering() { Val = 2 };
            FontScheme fontScheme1 = new FontScheme() { Val = FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontFamilyNumbering1);
            font1.Append(fontScheme1);

            Font font2 = new Font();
            Bold bold1 = new Bold();
            FontSize fontSize2 = new FontSize() { Val = 11D };
            Color color2 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName2 = new FontName() { Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering2 = new FontFamilyNumbering() { Val = 2 };
            FontScheme fontScheme2 = new FontScheme() { Val = FontSchemeValues.Minor };

            font2.Append(bold1);
            font2.Append(fontSize2);
            font2.Append(color2);
            font2.Append(fontName2);
            font2.Append(fontFamilyNumbering2);
            font2.Append(fontScheme2);

            fonts1.Append(font1);
            fonts1.Append(font2);

            Fills fills1 = new Fills() { Count = (UInt32Value)2U };

            Fill fill1 = new Fill();
            PatternFill patternFill1 = new PatternFill() { PatternType = PatternValues.None };

            fill1.Append(patternFill1);

            Fill fill2 = new Fill();
            PatternFill patternFill2 = new PatternFill() { PatternType = PatternValues.Gray125 };

            fill2.Append(patternFill2);

            fills1.Append(fill1);
            fills1.Append(fill2);

            Borders borders1 = new Borders() { Count = (UInt32Value)2U };

            Border border1 = new Border();
            LeftBorder leftBorder1 = new LeftBorder();
            RightBorder rightBorder1 = new RightBorder();
            TopBorder topBorder1 = new TopBorder();
            BottomBorder bottomBorder1 = new BottomBorder();
            DiagonalBorder diagonalBorder1 = new DiagonalBorder();

            border1.Append(leftBorder1);
            border1.Append(rightBorder1);
            border1.Append(topBorder1);
            border1.Append(bottomBorder1);
            border1.Append(diagonalBorder1);

            Border border2 = new Border();

            LeftBorder leftBorder2 = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color3 = new Color() { Indexed = (UInt32Value)64U };

            leftBorder2.Append(color3);

            RightBorder rightBorder2 = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color4 = new Color() { Indexed = (UInt32Value)64U };

            rightBorder2.Append(color4);

            TopBorder topBorder2 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color5 = new Color() { Indexed = (UInt32Value)64U };

            topBorder2.Append(color5);

            BottomBorder bottomBorder2 = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color6 = new Color() { Indexed = (UInt32Value)64U };

            bottomBorder2.Append(color6);
            DiagonalBorder diagonalBorder2 = new DiagonalBorder();

            border2.Append(leftBorder2);
            border2.Append(rightBorder2);
            border2.Append(topBorder2);
            border2.Append(bottomBorder2);
            border2.Append(diagonalBorder2);

            borders1.Append(border1);
            borders1.Append(border2);

            CellStyleFormats cellStyleFormats1 = new CellStyleFormats() { Count = (UInt32Value)1U };
            CellFormat cellFormat1 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

            cellStyleFormats1.Append(cellFormat1);

            CellFormats cellFormats1 = new CellFormats() { Count = (UInt32Value)3U };
            CellFormat cellFormat2 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            CellFormat cellFormat3 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyBorder = true };
            CellFormat cellFormat4 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true };

            cellFormats1.Append(cellFormat2);
            cellFormats1.Append(cellFormat3);
            cellFormats1.Append(cellFormat4);

            CellStyles cellStyles1 = new CellStyles() { Count = (UInt32Value)1U };
            CellStyle cellStyle1 = new CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

            cellStyles1.Append(cellStyle1);
            DifferentialFormats differentialFormats1 = new DifferentialFormats() { Count = (UInt32Value)0U };
            TableStyles tableStyles1 = new TableStyles() { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

            StylesheetExtensionList stylesheetExtensionList1 = new StylesheetExtensionList();

            StylesheetExtension stylesheetExtension1 = new StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };

            stylesheetExtension1.Append(slicerStyles1);

            StylesheetExtension stylesheetExtension2 = new StylesheetExtension() { Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" };
            stylesheetExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles() { DefaultTimelineStyle = "TimeSlicerStyleLight1" };

            stylesheetExtension2.Append(timelineStyles1);

            stylesheetExtensionList1.Append(stylesheetExtension1);
            stylesheetExtensionList1.Append(stylesheetExtension2);

            stylesheet1.Append(fonts1);
            stylesheet1.Append(fills1);
            stylesheet1.Append(borders1);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(differentialFormats1);
            stylesheet1.Append(tableStyles1);
            stylesheet1.Append(stylesheetExtensionList1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }

        private SheetData GenerateSheetdataForDetails(TestModelList data, string fileName)
        {
            SheetData sheetData1 = new SheetData();
            if (!File.Exists(fileName)) sheetData1.Append(CreateHeaderRowForExcel(data.testData[0]));
            if (data != null)
                foreach (TestModel testmodel in data.testData)
                {
                    Row partsRows = GenerateRowForChildPartDetail(testmodel);
                    sheetData1.Append(partsRows);
                }
            return sheetData1;
        }
        private SheetData GenerateSheetdataForDetails(TestModelList data, uint startingRowIndex)
        {
            SheetData sheetData = new SheetData();

            // Create the header row if it does not exist
            if (startingRowIndex == 1)
            {
                Row headerRow = CreateHeaderRowForExcel(data.testData[0]);
                sheetData.Append(headerRow);
            }

            // Generate sheet data for the new details, starting from the next row
            uint rowIndex = startingRowIndex;
            foreach (TestModel testmodel in data.testData)
            {
                Row dataRow = GenerateRowForChildPartDetail(testmodel, rowIndex);
                sheetData.Append(dataRow);
                rowIndex++;
            }

            return sheetData;
        }





        private Row CreateHeaderRowForExcel(TestModel data)
        {
            bool isStudent = false;
            Row workRow = new Row();
            workRow.Append(CreateCell("FirstName", 2U, 1, 1));
            workRow.Append(CreateCell("LastName", 2U, 2, 1));
            workRow.Append(CreateCell("Department", 2U, 3, 1));
            workRow.Append(CreateCell("ID", 2U, 4, 1));
            workRow.Append(CreateCell("Registeration Date", 2U, 5, 1));
            workRow.Append(CreateCell("Gender", 2U, 6, 1));
            workRow.Append(CreateCell("Contact", 2U, 7, 1));
            workRow.Append(CreateCell("Qualification", 2U, 8, 1));
            workRow.Append(CreateCell("Address", 2U, 9, 1));

            if (data.bloodGroup != "" && data.feeStatus != "" && data.marks != "")
            {
                isStudent = true;
                workRow.Append(CreateCell("BloodGroup", 2U, 10, 1));
                workRow.Append(CreateCell("FeeStatus", 2U, 11, 1));
                workRow.Append(CreateCell("Marks", 2U, 12, 1));

            }

            workRow.Append(CreateCell("Username", 2U, 13 - (3 * (isStudent ? 0 : 1)), 1));
            workRow.Append(CreateCell("Password", 2U, 14 - (3 * (isStudent ? 0 : 1)), 1));
            // header row done, counting it
            rowIndex++;
            return workRow;
        }


        private Row GenerateRowForChildPartDetail(TestModel testmodel)
        {
            bool isStudent = false;

            Row tRow = new Row() { RowIndex = (uint)rowIndex };

            tRow.Append(CreateCell(testmodel.firstName, 1, rowIndex));
            tRow.Append(CreateCell(testmodel.lastName, 2, rowIndex));
            tRow.Append(CreateCell(testmodel.department, 3, rowIndex));
            tRow.Append(CreateCell(testmodel.id, 4, rowIndex));
            tRow.Append(CreateCell(testmodel.regisDate, 5, rowIndex));
            tRow.Append(CreateCell(testmodel.gender, 6, rowIndex));
            tRow.Append(CreateCell(testmodel.contact, 7, rowIndex));
            tRow.Append(CreateCell(testmodel.qualification, 8, rowIndex));
            tRow.Append(CreateCell(testmodel.address, 9, rowIndex));

            if (testmodel.bloodGroup != "" && testmodel.feeStatus != "" && testmodel.marks != "")
            {
                isStudent = true;
                tRow.Append(CreateCell(testmodel.bloodGroup, 10, rowIndex));
                tRow.Append(CreateCell(testmodel.feeStatus, 11, rowIndex));
                tRow.Append(CreateCell(testmodel.marks, 12, rowIndex));
            }

            tRow.Append(CreateCell(testmodel.username, 1U, 13 - (3 * (isStudent ? 0 : 1)), rowIndex));
            tRow.Append(CreateCell(testmodel.password, 1U, 14 - (3 * (isStudent ? 0 : 1)), rowIndex));


            rowIndex++; // Increment the rowIndex for the next row
            return tRow;
        }

        private Row GenerateRowForChildPartDetail(TestModel testmodel, uint rowIndex)
        {
            bool isStudent = false;
            Row tRow = new Row() { RowIndex = rowIndex };

            tRow.Append(CreateCell(testmodel.firstName, 1, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.lastName, 2, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.department, 3, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.id, 4, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.regisDate, 5, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.gender, 6, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.contact, 7, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.qualification, 8, (int)rowIndex));
            tRow.Append(CreateCell(testmodel.address, 9, (int)rowIndex));

            if (testmodel.bloodGroup != "" && testmodel.feeStatus != "" && testmodel.marks != "")
            {
                isStudent = true;
                tRow.Append(CreateCell(testmodel.bloodGroup, 10, (int)rowIndex));
                tRow.Append(CreateCell(testmodel.feeStatus, 11, (int)rowIndex));
                tRow.Append(CreateCell(testmodel.marks, 12, (int)rowIndex));
            }

            tRow.Append(CreateCell(testmodel.username, 1U, 13 - (3 * (isStudent ? 0 : 1)), (int)rowIndex));
            tRow.Append(CreateCell(testmodel.password, 1U, 14 - (3 * (isStudent ? 0 : 1)), (int)rowIndex));

            return tRow;
        }


        private string CreateCellReference(int columnIndex, int rowIndex)
        {
            string result = string.Empty;
            //First is A
            //After Z, is AA
            //After ZZ, is AAA
            char firstRef = 'A';
            uint firstIndex = (uint)firstRef;
            int mod = 0;

            while (columnIndex > 0)
            {
                mod = (columnIndex - 1) % 26;
                result += (char)(firstIndex + mod);
                columnIndex = (columnIndex - mod) / 26;
            }

            result += rowIndex.ToString();

            return result;
        }


        private Cell CreateCell(string text, uint styleIndex, int columnIndex, int rowIndex)
        {
            Cell cell = new Cell();
            cell.StyleIndex = styleIndex;
            cell.DataType = CellValues.String;
            cell.CellValue = new CellValue(text);
            cell.CellReference = new StringValue(CreateCellReference(columnIndex, rowIndex));
            return cell;
        }

        private Cell CreateCell(string text, int columnIndex, int rowIndex)
        {
            return CreateCell(text, 1U, columnIndex, rowIndex);
        }

        private EnumValue<CellValues> ResolveCellDataTypeOnValue(string text)
        {
            int intVal;
            double doubleVal;
            if (int.TryParse(text, out intVal) || double.TryParse(text, out doubleVal))
            {
                return CellValues.Number;
            }
            else
            {
                return CellValues.String;
            }
        }

        public RowData? SearchExcelFile(string filePath, string sheetName, string searchVal1, string searchVal2)
        {
            RowData rowData = null;

            // also update this to use the dynamic path to the document
            
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(filePath, true))
            {
                WorkbookPart workbookPart = document.WorkbookPart;


                Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().FirstOrDefault(s => s.Name == sheetName);

                // Save the workbook before performing anything 
                // save the sheet

                workbookPart.Workbook.Save();
                document.Save();
                if (sheet != null)
                {

                    Worksheet worksheet = ((WorksheetPart)workbookPart.GetPartById(sheet.Id)).Worksheet;
                    IEnumerable<Row> rows = worksheet.Descendants<Row>();

                    // Find the column index of searchVal1 in the first row
                    Row firstRow = rows.FirstOrDefault();
                    if (firstRow != null)
                    {
                        Console.WriteLine("First row found");
                        int searchVal1ColumnIndex = -1;
                        foreach (Cell cell in firstRow)
                        {
                            if (cell != null)
                            {
                                string cellValue = GetCellValue(cell, workbookPart);
                                if (cellValue.Equals(searchVal1))
                                {
                                    Console.WriteLine($"{cellValue}");

                                    // I think here cell.CellReference is null, hence GetColumnIndex got null
                                    if (cell.CellReference != null)
                                        searchVal1ColumnIndex = GetColumnIndex(cell.CellReference);
                                    else Console.WriteLine("cellreference in first row is null");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cell in the first row is null");
                            }
                        }

                        // If searchVal1 was found, search for searchVal2 in the corresponding column
                        if (searchVal1ColumnIndex != -1)
                        {
                            Console.WriteLine("Search val 1 found");
                            foreach (Row row in rows)
                            {
                                Cell cell = row.Descendants<Cell>().ElementAtOrDefault(searchVal1ColumnIndex);
                                if (cell != null)
                                {
                                    string cellValue = GetCellValue(cell, workbookPart);
                                    if (cellValue.Equals(searchVal2))
                                    {
                                        rowData = new RowData();
                                        int cellIndex = 0;
                                        foreach (Cell dataCell in row)
                                        {
                                            //int cellIndex = GetColumnIndex(dataCell.CellReference);
                                            cellIndex++;
                                            Console.WriteLine(cellIndex);
                                            string dataCellValue = GetCellValue(dataCell, workbookPart);
                                            rowData.AddCellValue(dataCellValue, cellIndex);
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cell is null");
                                }
                            }
                        }
                    }
                }
            }

            return rowData;
        }



        public TeacherRowData? SearchExcelFile(string filePath, string sheetName, string searchVal1, string searchVal2, string person)
        {
            TeacherRowData rowData = null;

            using (SpreadsheetDocument document = SpreadsheetDocument.Open(filePath, true))
            {
                WorkbookPart workbookPart = document.WorkbookPart;


                Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().FirstOrDefault(s => s.Name == sheetName);

                // Save the workbook before performing anything 
                // save the sheet

                workbookPart.Workbook.Save();
                document.Save();
                if (sheet != null)
                {

                    Worksheet worksheet = ((WorksheetPart)workbookPart.GetPartById(sheet.Id)).Worksheet;
                    IEnumerable<Row> rows = worksheet.Descendants<Row>();

                    // Find the column index of searchVal1 in the first row
                    Row firstRow = rows.FirstOrDefault();
                    if (firstRow != null)
                    {
                        Console.WriteLine("First row found");
                        int searchVal1ColumnIndex = -1;
                        foreach (Cell cell in firstRow)
                        {
                            if (cell != null)
                            {
                                string cellValue = GetCellValue(cell, workbookPart);
                                if (cellValue.Equals(searchVal1))
                                {
                                    Console.WriteLine($"{cellValue}");

                                    // I think here cell.CellReference is null, hence GetColumnIndex got null
                                    if (cell.CellReference != null)
                                        searchVal1ColumnIndex = GetColumnIndex(cell.CellReference);
                                    else Console.WriteLine("cellreference in first row is null");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cell in the first row is null");
                            }
                        }

                        // If searchVal1 was found, search for searchVal2 in the corresponding column
                        if (searchVal1ColumnIndex != -1)
                        {
                            Console.WriteLine("Search val 1 found");
                            foreach (Row row in rows)
                            {
                                Cell cell = row.Descendants<Cell>().ElementAtOrDefault(searchVal1ColumnIndex);
                                if (cell != null)
                                {
                                    string cellValue = GetCellValue(cell, workbookPart);
                                    if (cellValue.Equals(searchVal2))
                                    {
                                        rowData = new TeacherRowData();
                                        int cellIndex = 0;
                                        foreach (Cell dataCell in row)
                                        {

                                            cellIndex++;
                                            Console.WriteLine(cellIndex);
                                            string dataCellValue = GetCellValue(dataCell, workbookPart);
                                            rowData.AddCellValue(dataCellValue, cellIndex);
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cell is null");
                                }
                            }
                        }
                    }
                }
            }

            return rowData;
        }




        private static string GetCellValue(Cell cell, WorkbookPart workbookPart)
        {
            string cellValue = string.Empty;
            if (cell != null)
            {
                if (cell.DataType != null && cell.DataType == CellValues.SharedString)
                {
                    SharedStringTable sharedStringTable = workbookPart.SharedStringTablePart.SharedStringTable;
                    int index = int.Parse(cell.InnerText);
                    if (sharedStringTable.ChildElements.Count > index)
                    {
                        cellValue = sharedStringTable.ChildElements[index].InnerText;
                    }
                }
                else
                {
                    cellValue = cell.InnerText;
                }
            }

            return cellValue;
        }

        private static int GetColumnIndex(string cellReference)
        {
            if (string.IsNullOrEmpty(cellReference))
            {
                throw new ArgumentException("Cell reference cannot be null or empty.", nameof(cellReference));
            }
            string columnName = Regex.Replace(cellReference, @"\d", string.Empty);
            int columnIndex = 0;
            int factor = 1;

            for (int i = columnName.Length - 1; i >= 0; i--)
            {
                columnIndex += factor * (columnName[i] - 'A' + 1);
                factor *= 26;
            }

            return columnIndex - 1;
        }




        // Returns the row index of a cell reference
        public static uint GetRowIndex(string cellReference)
        {
            // Create a regular expression to match the row index of the cell reference
            Regex regex = new Regex("[0-9]+");

            // Match the regular expression against the cell reference
            Match match = regex.Match(cellReference);

            // Convert the matched value to a number and return it as the row index
            return uint.Parse(match.Value);
        }




        // Returns the value of a cell
        public static string GetCellValue(Cell cell, SharedStringTablePart sharedStringTablePart)
        {
            // If the cell has a value, get the value from the shared string table or as a plain string
            if (cell.CellValue != null)
            {
                if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    return sharedStringTablePart.SharedStringTable.ElementAt(int.Parse(cell.CellValue.Text)).InnerText;
                }
                else
                {
                    return cell.CellValue.Text;
                }
            }

            // If the cell doesn't have a value, return an empty string
            return "";
        }



    }
}

