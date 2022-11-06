using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class OverTime
    {
        private long employeeNo;
        private float toverTime;
        private DateTime date;

        public long EmployeeNo
        {
            get
            {
                return employeeNo;
            }
            set
            {
                if (value >= 0)
                    employeeNo = value;
                else
                    employeeNo = 0;
            }
        }

        public float ToverTime
        {
            get
            {
                return toverTime;
            }
            set
            {
                if (value >= 0)
                    toverTime = value;
                else
                    toverTime = 0;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value != null)
                    date = value;
                else
                    date = DateTime.Today;
            }
        }

        public OverTime(long pEmployeeNo, float pToverTime, DateTime pDate)
        {
            EmployeeNo = pEmployeeNo;
            ToverTime = pToverTime;
            Date = pDate;
        }

    }
}
