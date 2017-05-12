using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Salary
    {
        public Salary(decimal sal)
        {
            SalarySize = sal;
        }

        private decimal salarySize;
        public decimal SalarySize { get { return salarySize; } set { salarySize = value; } }
    }
}
