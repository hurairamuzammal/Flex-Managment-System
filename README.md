# Introduction

Flex System Created with C# and Visual Studio Window form is excellent project to practice the concept of Object Oriented Programming. Flex is LMS system used by teachers,students and admin to manage various tasks.
The Project compromises of three main modules where C# programming is in "Flex" Project and graphics are used in project "Login Pages":  
Administrator's Module.  
Teacher's Module.  
Student's Module.  
# Pre Requisites 
The project using C# programming language with CLI/Clang tool. In order to run the project please download Visual Studio 2022   
 Download .NET devoplment pack.  
Download cli clang tools .
# **Instruction to run Project**
To launch the project simply grab a copy of code . Extract the code and follow steps to launch Solution.

1. Download and extract the folder.
2. Go to Flex>login pages.
3. Launch LoginPages.sln. 
# Username and Passwords
admin login:  
   Username: admin  
   Password: admin  
In order to use Teacher and student Module please add student / Teacher using admin Module.
# Administrator Module

I've implemented a "Sign In" feature that prompts users to enter their unique username and password for authentication. For now, I'm using "admin/admin" for testing.

I've added a "Add New Teacher" function that collects details such as T-id, first name, last name, department, username, password, registration date, gender, contact number, qualification, and address. The data is then saved to a file named "Teacher.txt."

Similarly, I've created an "Add New Student" function. This function collects student information, including S-id, first name, last name, department, registration date, gender, contact number, blood group, address, fee status, qualification, and marks. Student data is saved to a file named "Student.txt."

I've implemented the "Edit Student Details" function, allowing administrators to update student information, including first name, last name, fee status, address, and contact number.

For teacher details, the "Edit Teacher Details" function enables administrators to make changes, such as address, contact number, qualification, and salary.

I've added a "View All Students" function, which displays a list of all registered students.

Similarly, there's a "View All Teachers" function that displays a list of all registered teachers.

# Student Module

The "Sign In" feature has been implemented to allow students to authenticate using their unique username and password.

The "View Attendance" function shows students their attendance status, including "P" (present) or "A" (absent), along with the date and day.

I've added the "View Marks" function to display students' marks for all their courses.

The "View Grades" function allows students to check their grades for all courses.

Students can view their registered courses using the "View Registered Courses" function.

I've also implemented a "View Fee Status" function for students to check their fee payment status.

# Teacher Module

The "Sign In" feature has been implemented for teachers, allowing them to authenticate using their unique username and password.

I'm working on the "Teacher Time Table" function, which will display lecture schedules, dates, and timetables.

In progress is the "Mark Attendance" function, where teachers will be able to upload student attendance records.

The "Assign Marks" function is also under development to enable teachers to upload student marks.

Lastly, the "Assign Grades" function is in progress, allowing teachers to upload student grades.

This project involves a comprehensive set of features that I'm implementing step by step. It's important to ensure that each functionality is tested thoroughly before moving on to the next.



## Fix For Issue:   
While downloading a file form internet  Windows might block some of files to prevent attack and you may get such error.
MSB3821: Couldn't process file 'path' due to its being in the Internet or Restricted zone or having the mark of the web on the file.  
To simply fix the issue enter LoginPages folder and search for ".resx" and you may get upto 26 ".resx" files. You need to select unblock in properties of search result to fix the issue.


# Developers

This project is jointly developed by:  
[Huraira Muzammal](https://github.com/hurairamuzammal "profile") and
[Shayan Zawar](https://github.com/SHAYANZAWAR "profile").

Suggestions for improvement is most welcomed. 😊️
