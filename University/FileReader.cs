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
        static public List<Student> Students = new List<Student>();
        static public List<Employee> Employees = new List<Employee>();
        static private string spath = "C:\\Users\\user\\documents\\visual studio 2015\\Projects\\University\\University\\Students.txt";

        static public List<string> ReadStudents()
        {
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(spath);
            for (int i = 0; i < lines.Length; i++)
                List.Add(lines[i]);

            return List;
        }

        static public void RewriteStudents(string sline, string newInfo)
        {
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(spath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != sline)
                    List.Add(lines[i]);
                else
                {
                    lines[i] = newInfo;
                    List.Add(lines[i]);
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = string.Empty;
                File.WriteAllText(spath, lines[i]);
            }

            foreach (string l in List)
                File.AppendAllText(spath, l + "\r\n");
        }

        //static public List<Employee> ReadEmployees()
        //{

        //}

        static public void AddStudentToDB(Student student)
        {
            string info = student.IdStudent.ToString() + '\t' + student.LastName + '\t' + student.FirstName + '\t' + student.SecondName + '\t' + student.Faculty + '\t' + student.Department + '\t' + student.GPA + '\t' + student.Privilege;
            File.AppendAllText(spath, info + "\r\n");
        }
    }
}
