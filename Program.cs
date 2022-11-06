using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Salary_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string EmployeesFile = "./data/Employees.txt", LoansFile = "./data/Loans.txt", OvertimesFile = "./data/Overtimes.txt", SallariesFile = "./data/Sallaries.txt";
            List<Employee> employeesList = new List<Employee>();
            List<Loan> loansList = new List<Loan>();
            List<OverTime> overtimesList = new List<OverTime>();
            string[] seperators = { "\t", " " };
            Console.WriteLine(DateTime.Today.ToString());
            try
            {
                using (StreamReader sr = new StreamReader(EmployeesFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(seperators,StringSplitOptions.RemoveEmptyEntries);
                        employeesList.Add(new Employee(fields[0], fields[1], long.Parse(fields[2]), short.Parse(fields[3]), DateTime.Parse(fields[4] + " " + fields[5] + " " + fields[6]), decimal.Parse(fields[7]), bool.Parse(fields[8])));
                        
                    }
                    sr.Close();
                }

                using (StreamReader sr = new StreamReader(LoansFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                        loansList.Add(new Loan(long.Parse(fields[0]) , decimal.Parse(fields[1]) , decimal.Parse(fields[2]), DateTime.Parse(fields[3] + " " + fields[4] + " " + fields[5]), decimal.Parse(fields[6])));

                    }
                    sr.Close();
                }
                using (StreamReader sr = new StreamReader(OvertimesFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                        overtimesList.Add(new OverTime(long.Parse(fields[0]) , float.Parse(fields[1]) , DateTime.Parse(fields[2] + " " + fields[3] + " " + fields[4])));

                    }
                    sr.Close();
                }

                using (StreamWriter sw = new StreamWriter(SallariesFile))
                {
                    foreach(Employee em in employeesList)
                    {
                        int loanIndex = loansList.FindIndex( delegate(Loan fLoan) {return fLoan.EmployeeNo == em.EmployeeNo; } );
                        decimal monthlyPayment = loanIndex >= 0 ? loansList[loanIndex].MonthlyPayment : 0;
                        int overtimeIndex = overtimesList.FindIndex( delegate(OverTime fOverTime) {return fOverTime.EmployeeNo == em.EmployeeNo; } );
                        float tovertime = overtimeIndex >= 0 ? overtimesList[overtimeIndex].ToverTime : 0.0f;
                        decimal sallary = Sallary.ComputeSallary(em.BaseSallary, em.Married, em.Type, monthlyPayment, tovertime);
                        sw.WriteLine(em.EmployeeNo.ToString() + "\t" + sallary.ToString() + "\t" + em.HiringDate.ToString());
                        if (loanIndex >= 0)
                        {
                            loansList[loanIndex].DebitAmount -= loansList[loanIndex].MonthlyPayment;
                            if (loansList[loanIndex].DebitAmount == 0)
                                loansList.RemoveAt(loanIndex);
                        }
                        Console.WriteLine(em.ToString() + "\t" + sallary.ToString());
                    }
                    sw.Close();
                }
                using (StreamWriter sw = new StreamWriter(LoansFile))
                {
                    foreach (Loan loan in loansList)
                        sw.WriteLine(loan.ToString());
                    sw.Close();
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
