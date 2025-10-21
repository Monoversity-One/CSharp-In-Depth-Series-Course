namespace _14.Structs
{
    class _01_Struct
    {
        void CreateEmployee()
        {
            Employee emp = new Employee();
            emp.Salary = 1000;
            emp.FullName = "Elliot One";
            emp.JobTittle = "Programmer";
            Console.WriteLine($"Salary = {emp.Salary}");
        }
    }

    struct Employee
    {
        public string FullName;
        public string JobTittle;
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
