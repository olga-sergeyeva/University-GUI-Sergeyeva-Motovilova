using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Employee
    {
        public Employee(int id_employee, string fname, string lname, string sname, decimal salary)
        {
            IdEmployee = id_employee;
            FirstName = fname;
            LastName = lname;
            SecondName = sname;
            Salary = salary;
        }

        private int id_employee;
        public int IdEmployee { get { return id_employee; } set { id_employee = value; } }

        private string lname;
        public string LastName { get { return lname; } set { lname = value; } }

        private string fname;
        public string FirstName { get { return fname; } set { fname = value; } }

        private string sname;
        public string SecondName { get { return sname; } set { sname = value; } }

        private decimal salary;
        public decimal Salary { get { return salary; } set { salary = value; } }
    }
}
