using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Employee : Person
    {
        private long emplyeeNo;
        private short type;
        private DateTime hiringDate;
        private decimal baseSallary;
        public long EmployeeNo
        {
            get
            {
                return emplyeeNo;
            }
            set
            {
                emplyeeNo = value;
            }
        }

        public short Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == 1 || value == 2)
                    type = value;
                else
                    type = 1;
            }
        }

        public DateTime HiringDate
        {
            get
            {
                return hiringDate;
            }
            set
            {
                if (value != null)
                    hiringDate = value;
                else
                    hiringDate = DateTime.Today;
            }
        }

        public decimal BaseSallary
        {
            get
            {
                return baseSallary;
            }
            set
            {
                if (value <= 0)
                    baseSallary = 0;
                else
                    baseSallary = value;
            }
        }
        public Employee(string pName,string pFamily, long pEmployeeNo,short pType,DateTime pHiringDate, decimal pBaseSallary,bool pMarried) : base( pName , pFamily , pMarried )
        {
            EmployeeNo = pEmployeeNo;
            Type = pType;
            HiringDate = pHiringDate;
            BaseSallary = pBaseSallary;

        }

        public override string ToString()
        {
            return Fullname() + "\t" + HiringDate.ToString();
        }
    }
}
