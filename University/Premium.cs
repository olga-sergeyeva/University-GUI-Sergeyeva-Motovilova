using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Premium
    {
        public Premium(decimal premPercent)
        {
            PremiumPercent = premPercent;
            PremiumSize = 0;
        }

        private decimal premiumPercent;
        public decimal PremiumPercent { get { return premiumPercent; } set { premiumPercent = value; } }

        private decimal premiumSize;
        public decimal PremiumSize { get { return premiumSize; } set { premiumSize = value; } }

        public decimal CountPremium(Salary sal, Premium prem)
        {
            PremiumSize = (sal.SalarySize * prem.premiumPercent) / 100;
            return premiumSize;
        }
    }
}
