 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Loan
    {
        private long employeeNo;
        private decimal loanAmount, monthlyPayment , debitAmount;
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
        public decimal LoanAmount
        {
            get
            {
                return loanAmount;
            }
            set
            {
                if (value >= 0)
                    loanAmount = value;
                else
                    loanAmount = 0;
            }
        }
        public decimal MonthlyPayment
        {
            get
            {
                return monthlyPayment;
            }
            set
            {
                if (value >= 0)
                    monthlyPayment = value;
                else
                    monthlyPayment = 0;
            }
        }
        public decimal DebitAmount
        {
            get
            {
                return debitAmount;
            }
            set
            {
                if (value >= 0)
                    debitAmount = value;
                else
                    debitAmount = 0;
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

        public Loan(long pEmployeeNumber, decimal pLoanAmount, decimal pMonthlyPayment ,DateTime pDate, decimal pDebitAmount)
        {
            employeeNo = pEmployeeNumber;
            LoanAmount = pLoanAmount;
            MonthlyPayment = pMonthlyPayment;
            DebitAmount = pDebitAmount;
            date = pDate;
        }

        public override string ToString()
        {
            return EmployeeNo.ToString() + "\t" + LoanAmount.ToString() + "\t" + MonthlyPayment.ToString() + "\t" + Date.ToString() + "\t" + DebitAmount.ToString();
        }
    }
}
