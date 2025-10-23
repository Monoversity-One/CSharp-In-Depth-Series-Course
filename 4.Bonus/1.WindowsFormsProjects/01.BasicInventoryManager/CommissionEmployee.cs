namespace EmployeePayrollDemo
{
    class CommissionEmployee : Employee
    {
        public int Salary;
        public int Sale;
        public void Add(string EName, string EHireDate, int salary, int sale)
        {
            Name = EName;
            HireDate = EHireDate;

            Sale = sale;
            Salary = salary + (sale * 10 / 100);
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Commission" +"    Monthly Salary:" + Salary.ToString() + "    Gross Sales:" + Sale.ToString() + "\n";
        }
    }
}
