using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tamrin1
{
    class SalariedEmployee : Employee
    {
        public int Hogog_Month;
        public void Add(string EName, string EHireDate, int Hogog)
        {
            Name = EName;
            HireDate = EHireDate;
            Hogog_Month = Hogog;
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Salaried"  +"    Monthly Salary:" + Hogog_Month.ToString() + "\n";
        }
    }
}
