using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flex.EducationalPerson;
using Flex.EducationalPerson.DateClass;
namespace Flex.EducationalPerson.student
{
    public class StudentClass : EducationalPerson
    {
        private string m_bloodGroup, m_feeStatus;
        private int m_marks;
        private ExcelWrite outs;
        private TestModelList tmList;
        // The name of the file that contains the data
        private string filePath;
        // constructor
        public StudentClass() : base()
        {
            m_bloodGroup = "";
            m_feeStatus = "";
            m_marks = 0;
            outs = new ExcelWrite();
            filePath = "C:/Users/Huraira/source/repos/Flex/EducationalPerson/Student/";
        }

        ~StudentClass()
        {
            Console.WriteLine("Destructor called");
            // Closing the output file
        }

        public string getFeeStatus()
        {
            return m_feeStatus;
        }
        public override bool addToRecord(string firstName, string lastName, string deptName, string id, string regisDate,
            string gender, string contactNo, string qualification, string address, string bloodGroup, string feeStatus, string marks,
            string username, string password
            )
        {

            tmList = new TestModelList();

            tmList.testData = new List<TestModel>();
            TestModel tm = new TestModel();
            tm.firstName = firstName;
            tm.lastName = lastName;
            tm.department = deptName;
            tm.id = id;
            tm.regisDate = regisDate;
            tm.gender = gender;
            tm.contact = contactNo;
            tm.qualification = qualification;
            tm.address = address;
            tm.bloodGroup = bloodGroup;
            tm.feeStatus = feeStatus;
            tm.marks = marks;
            tm.username = username;
            tm.password = password;
            tmList.testData.Add(tm);

            outs.CreateExcelFile(tmList, filePath, "StudentRecord.xlsx", "StudentCredentials");

            string[] subjects = { "Math", "English", "Urdu", "Physics", "Chemistry", "Computer" };
            outs.CreateAttendanceSheet(id, (filePath + "/StudentRecord.xlsx"), subjects);
            outs.CreateMarksSheet(id, (filePath + "/StudentRecord.xlsx"), subjects);

            return true;

        }
        internal string markStudentAttendance(string rollNo, string subject, string attendance)
        {
            // returning the status messages from the markAttendance function
            return (outs.markAttendance((filePath + "StudentRecord.xlsx"), rollNo, DateTime.Now, subject, attendance));
        }
        public string assignStudentMarks(string rollNo, DateTime date, string subject, string marks)
        {

            return outs.assignMarks((filePath + "StudentRecord.xlsx"), rollNo, date, subject, marks);
        }
        public StudentClass? Search(string headerKey, string key)
        {
            StudentClass s = new StudentClass();
            RowData rowData;
            rowData = outs.SearchExcelFile(filePath + "/StudentRecord.xlsx", "StudentCredentials", headerKey, key);
            if (rowData == null)
            {
                Console.WriteLine("No record found");
                return null;
            }
            s.m_firstName = rowData.FirstName;
            s.m_lastName = rowData.LastName;
            s.m_deptName = rowData.Department;
            s.m_id = rowData.Id;
            s.m_regisDate = rowData.RegisDate;
            s.m_gender = rowData.Gender;
            s.m_contactNo = rowData.Contact;
            s.m_qualification = rowData.Qualification;
            s.m_address = rowData.Address;
            s.m_bloodGroup = rowData.BloodGroup;
            s.m_feeStatus = rowData.FeeStatus;
            s.m_marks = Int32.Parse(rowData.Marks);
            s.m_userName = rowData.Username;
            s.m_password = rowData.Password;
            return s;
        }

        public bool editStudent(string searchVal, string searchVal2, string searchValKey, string edit)
        {
            StudentClass student = new StudentClass();
            if (searchVal == "ID" && student.Search(searchVal, searchValKey) == null)
            {
                return false;
            }
            outs.editInFile(filePath + "StudentRecord.xlsx", "StudentCredentials", searchVal, searchVal2, searchValKey, edit);
            return true;
        }
        // returns null if the record is not found, otherwise returns the record
        public StudentClass? Login(string username, string password)
        {
            return Search("Username", username);
        }
    }
}
