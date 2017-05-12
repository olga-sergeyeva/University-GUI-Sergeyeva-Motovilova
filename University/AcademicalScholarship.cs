using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class AcademicalScholarship
    {
        private decimal ascholarshipSize;
        public decimal AcademicalScholarshipSize { get { return ascholarshipSize; } set { ascholarshipSize = value; } }

        public AcademicalScholarship(string gpa)
        {
            if (gpa == "Отличная") AcademicalScholarshipSize = 2000;
            if (gpa == "Хорошая") AcademicalScholarshipSize = 1500;
            if (gpa == "Удовлетворительная") AcademicalScholarshipSize = 0;
        }
    }
}
