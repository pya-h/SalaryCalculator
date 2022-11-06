using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Person
    {
        protected string name, family;
        protected bool married;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                    name = "NO_NAME";
            }
        }

        public string Family
        {
            get
            {
                return family;
            }
            set
            {
                if (value != "")
                    family = value;
                else
                    family = "NO_NAME";
            }
        }

        public bool Married
        {
            get
            {
                return married;
            }
            set
            {
                married = value;
            }
        }

        public Person(string pName,string pFamily, bool pMarried)
        {
            Name = pName;
            Family = pFamily;
            Married = pMarried;
        }

        public string Fullname()
        {
            return Name + " " + Family;
        }
    }
}
