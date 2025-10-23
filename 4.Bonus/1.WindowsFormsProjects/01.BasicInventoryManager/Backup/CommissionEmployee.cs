using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tamrin1
{
    class CommissionEmployee : Employee
    {
        public int Hogog_Month;
        public int Forosh;
        public void Add(string EName, string EHireDate, int Hogog, int EForosh)
        {
            Name = EName;
            HireDate = EHireDate;
            
            Forosh = EForosh;
            Hogog_Month = Hogog + (EForosh * 10 / 100);
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Commission" +
                   "    Monthly Salary:" + Hogog_Month.ToString() + "    Gross Sales:" + Forosh.ToString() + "\n";
        }
    }
}
