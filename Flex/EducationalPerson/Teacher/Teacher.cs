using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flex.EducationalPerson.student;
using Flex.EducationalPerson.DateClass;

namespace Flex.EducationalPerson.teacher
{
    public class TeacherClass : EducationalPerson
    {

        private string filePath;
        private ExcelWrite outs;
        private TestModelList tmList;

        public TeacherClass()
        {
            outs = new ExcelWrite();
            DirectoryInfo di = new DirectoryInfo("../../../../");
            filePath = di.FullName.ToString() + "Flex\\EducationalPerson\\Teacher";


          }
          public override bool addToRecord(string firstName, string lastName, string deptName, string id, string regisDate, string gender, string contactNo,
            string qualification, string address, string bloodGroup, string feeStatus, string marks, string username, string password)
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

            outs.CreateExcelFile(tmList, filePath, "TeacherRecord.xlsx", "TeacherCredentials");

            return true;
        }

       public string? markStudentAttendance(string rollNo, string subject, string attendance)
        {
            StudentClass student = new StudentClass();
            // searching the student with that roll number in the file
            if (student.Search("ID", rollNo) == null)
            {
                return null;
            }

            return student.markStudentAttendance(rollNo, subject, attendance);
        }

        public string? assignStudentMarks(string rollNo, DateTime date, string subject, string marks)
        {
            StudentClass student = new StudentClass();
            // searching the student with that roll number in the file
            if (student.Search("ID", rollNo) == null)
            {
                
                return null;
            }

            return student.assignStudentMarks(rollNo, date, subject, marks);
        }
        public string? assignStudentGrade(string rollNo, DateTime date, string subject, string grade)
        {
            StudentClass student = new StudentClass();
            // searching the student with that roll number in the file
            if (student.Search("ID", rollNo) == null)
            {
                return null;
            }

            return student.assignStudentMarks(rollNo, date, subject, ("Grade: " + grade));

        }

        public TeacherClass? Search(string headerKey, string key)
        {
            TeacherClass teacher = new TeacherClass();
            TeacherRowData? rowData;
            rowData = outs.SearchExcelFile(filePath + "\\TeacherRecord.xlsx", "TeacherCredentials", headerKey, key, "Teacher");
            if (rowData == null)
            {
                Console.WriteLine("No record found");
                return null;
            }
            teacher.m_firstName = rowData.FirstName;
            teacher.m_lastName = rowData.LastName;
            teacher.m_deptName = rowData.Department;
            teacher.m_id = rowData.Id;
            teacher.m_regisDate = rowData.RegisDate;
            teacher.m_gender = rowData.Gender;
            teacher.m_contactNo = rowData.Contact;
            teacher.m_qualification = rowData.Qualification;
            teacher.m_address = rowData.Address;
            teacher.m_userName = rowData.Username;
            teacher.m_password = rowData.Password;
            return teacher;
        }
        public bool editTeacher(string searchVal, string searchVal2, string searchValKey, string edit)
        {
            TeacherClass teacher = new TeacherClass();
            if (searchVal == "ID" && teacher.Search(searchVal, searchValKey) == null)
            {
                return false;
            }
            outs.editInFile(filePath + "TeacherRecord.xlsx", "TeacherCredentials", searchVal, searchVal2, searchValKey, edit);
            return true;
        }

    }
}
