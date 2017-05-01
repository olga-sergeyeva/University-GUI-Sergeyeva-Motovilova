using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        public Student(int id_student, string fname, string lname, string faculty, string gpa, decimal ascholarship)
        {
            this.id_student = id_student;
            this.fname = fname;
            this.lname = lname;
            this.faculty = faculty;
            this.gpa = gpa;
            this.ascholarship = ascholarship;
        }

        private int id_student;
        public int IdStudent { get { return id_student; } set { id_student = value; } }

        private string fname;
        public string FirstName { get { return fname; } set { fname = value; } }

        private string lname;
        public string LastName { get { return lname; } set { lname = value; } }

        private string faculty;
        public string Faculty { get { return faculty; } set { faculty = value; } }

        private string gpa;
        public string GPA { get { return gpa; } set { gpa = value; } }

        private decimal ascholarship;
        public decimal AcademicalScholarship{ get { return ascholarship; } set { ascholarship = value; } }


    }
}
