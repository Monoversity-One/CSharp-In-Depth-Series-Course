namespace _10.Object_OrientedProgramming._08.Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added.");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated.");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated.");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        { customerDal.Add(); }
    }

}
