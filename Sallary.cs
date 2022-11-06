using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    static class Sallary
    {
        public static decimal ComputeSallary(decimal baseSallary, bool married, short type, decimal monthlyPayment = 0, float toverTime = 0)
        {
            decimal sallary = baseSallary + (decimal)( married ? 0.15 : 0) * baseSallary + (decimal)toverTime*3000;
            return sallary - ( monthlyPayment + (decimal)(type == 2 ? 0.15 : 0.10)*sallary );
        }
    }
}
