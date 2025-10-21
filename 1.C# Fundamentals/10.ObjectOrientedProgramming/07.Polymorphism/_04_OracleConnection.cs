namespace _10.Object_OrientedProgramming._07.Polymorphism
{
    public class OracleConenction : DbConnection
    {
        public OracleConenction(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnetion is open.");
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection is closed.");
        }
    }
}