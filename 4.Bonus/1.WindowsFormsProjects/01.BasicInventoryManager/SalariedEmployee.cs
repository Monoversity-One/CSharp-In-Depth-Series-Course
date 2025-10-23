namespace EmployeePayrollDemo
{
    class SalariedEmployee : Employee
    {
        public int MonthlySalary;
        public void Add(string EName, string EHireDate, int monthlySalary)
        {
            Name = EName;
            HireDate = EHireDate;
            MonthlySalary = monthlySalary;
        }

        public string GetInfo()
        {
            return "Employee Name:" + Name + "    Hire Date:" + HireDate + "    Employee Type: Salaried"  +"    Monthly Salary:" + MonthlySalary.ToString() + "\n";
        }
    }
}
