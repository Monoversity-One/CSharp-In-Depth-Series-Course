using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tamrin1
{
    class PriceEmployee : Employee
    {
        public int Hogog_Khedmat;

        public void Add(string EName, string EHireDate, int Hogog)
        {
            Name = EName;
            HireDate = EHireDate;
            Hogog_Khedmat = Hogog;
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Contract" +
                   "    Service Salary:" + Hogog_Khedmat.ToString() + "\n";
        }
    }
}
