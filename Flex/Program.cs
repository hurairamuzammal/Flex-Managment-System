// See https://aka.ms/new-console-template for more information

using Flex.EducationalPerson.student;
using Flex.EducationalPerson.teacher;

namespace noName
{
    public class Test
    {
        public static void Main(string[] args)
        {
           TeacherClass student = new TeacherClass();
            student.addToRecord("Emma", "Wilson", "English", "22f-1254", "06-01-2023", "female", "03225557788", "Bachelor's", "Karachi", "", "", "", "Username@123", "Username@123");
            student.addToRecord("Michael", "Smith", "Chemistry", "22f-4567", "05-25-2023", "male", "03134455667", "Master's", "Islamabad", "", "", "", "Username@1234", "Username@1234");
            student.addToRecord("Sophie", "Chang", "Computer Science", "22f-7890", "05-30-2023", "female", "03334567890", "PhD", "Lahore", "", "", "", "Username@12345", "Username@12345");
            student.addToRecord("David", "Brown", "Mathematics", "22f-3411", "06-05-2023", "male", "03001234567", "Bachelor's", "Rawalpindi", "", "", "", "Username@123456", "Username@123456");
        }
    }
}
