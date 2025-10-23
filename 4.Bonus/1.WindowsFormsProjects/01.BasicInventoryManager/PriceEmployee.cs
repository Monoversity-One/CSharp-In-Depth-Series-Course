namespace EmployeePayrollDemo
{
    class PriceEmployee : Employee
    {
        public int Salary;

        public void Add(string EName, string EHireDate, int salary)
        {
            Name = EName;
            HireDate = EHireDate;
            Salary = salary;
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Contract" + "    Service Wage:" + Salary.ToString() + "\n";
        }
    }
}
