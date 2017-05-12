using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        public Student(int id_student, string fname, string lname, string sname, string faculty, string department, string gpa, decimal ascholarship, decimal sscholarship)
        {
            IdStudent = id_student;
            FirstName = fname;
            LastName = lname;
            SecondName = sname;
            Faculty = faculty;
            Department = department;
            GPA = gpa;
            AcademicalScholarship = ascholarship;
            SocialScholarship = sscholarship;
        }

        private int id_student;
        public int IdStudent { get { return id_student; } set { id_student = value; } }

        private string fname;
        public string FirstName { get { return fname; } set { fname = value; } }

        private string lname;
        public string LastName { get { return lname; } set { lname = value; } }

        private string sname;
        public string SecondName { get { return sname; } set { sname = value; } }

        private string faculty;
        public string Faculty { get { return faculty; } set { faculty = value; } }

        private string department;
        public string Department { get { return faculty; } set { faculty = value; } }

        private string gpa;
        public string GPA { get { return gpa; } set { gpa = value; } }

        private decimal ascholarship;
        public decimal AcademicalScholarship{ get { return ascholarship; } set { ascholarship = value; } }

        private decimal sscholarship;
        public decimal SocialScholarship { get { return sscholarship; } set { sscholarship = value; } }

        public void AddStudent(Student student)
        {
            FileReader.Students.Add(student);
            FileReader.AddStudentToDB(student);
        }
    }
}
