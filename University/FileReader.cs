using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class FileReader
    {
        static public List<Student> Students;
        static public List<Employee> employees;
        static private string path = "C:\\Users\\user\\documents\\visual studio 2015\\Projects\\University\\University\\Students.txt";

        static public List<Student> ReadStudents()
        {

        }

        static public List<Employee> ReadEmployees()
        {

        }

        static public void AddStudentToDB(Student student)
        {
            string info = student.IdStudent.ToString() + ' ' + student.FirstName + ' ' + student.LastName + ' ' + student.SecondName + ' ' + student.Faculty + ' ' + student.Department + ' ' + student.GPA + ' ' + student.AcademicalScholarship.ToString() + ' ' + student.SocialScholarship.ToString();
            File.AppendAllText(path, info + "\r\n");
        }
    }
}
