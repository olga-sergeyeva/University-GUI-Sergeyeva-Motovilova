using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class SocialScholarship
    {
        private decimal sscholarshipSize;
        public decimal SocialScholarshipSize { get { return sscholarshipSize; } set { sscholarshipSize = value; } }

        public SocialScholarship(string privilege)
        {
            if (privilege == "Нет") SocialScholarshipSize = 0;
            if (privilege == "Дети-сироты") SocialScholarshipSize = 2000;
            if (privilege == "Малообеспеченная семья") SocialScholarshipSize = 2500;
        }
    }
}
