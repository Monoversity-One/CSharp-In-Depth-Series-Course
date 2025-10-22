using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using _07.LINQ.AutoLotDAL.BulkImport;
using _07.LINQ.AutoLotDAL.DataOperations;
using _07.LINQ.AutoLotDAL.Models;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Collections.Generic;

namespace _07.LINQ
{
    class Program
    {
        enum DataProvider
        {
            SqlServer, OleDb, Odbc, None
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== ConnectedLayer Unified Demos =====");
                Console.WriteLine("1) Demo: Basic provider connection type (ConsoleApp1)");
                Console.WriteLine("2) Demo: DbProviderFactories and read Inventory (ConsoleApp2)");
                Console.WriteLine("3) Demo: AutoLot DAL operations & transaction (ConsoleApp3)");
                Console.WriteLine("4) Demo: Bulk copy sample (ConsoleApp3)");
                Console.WriteLine("Q) Quit");
                Console.Write("Select: ");
                var key = Console.ReadLine();
                if (string.Equals(key, "q", StringComparison.OrdinalIgnoreCase)) break;
                Console.WriteLine();

                try
                {
                    switch (key)
                    {
                        case "1":
                            Demo1_ProviderConnectionType();
                            break;
                        case "2":
                            Demo2_DbProviderFactories();
                            break;
                        case "3":
                            Demo3_DalOperations();
                            break;
                        case "4":
                            DoBulkCopy();
                            break;
                        default:
                            Console.WriteLine("Unknown selection.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
            }
        }

        static void Demo1_ProviderConnectionType()
        {
            IDbConnection dbConnection = GetConnection(DataProvider.SqlServer);
            Console.WriteLine(dbConnection.GetType().Name);
        }

        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
                    connection = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection();
                    break;
                case DataProvider.None:
                    break;
            }
            return connection;
        }

        static void Demo2_DbProviderFactories()
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

            DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);

            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("There was an issue creating the Connection");
                    return;
                }

                Console.WriteLine($"Your connection object is a : {connection.GetType().Name}");

                connection.ConnectionString = connectionString;
                connection.Open();

                Console.WriteLine($"SQL Server Version = {connection.ServerVersion}");

                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    Console.WriteLine("There was an issue creating the Command");
                    return;
                }

                Console.WriteLine($"Your command object is a : {command.GetType().Name}");

                command.Connection = connection;
                command.CommandText = "Select * From Inventory";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    Console.WriteLine($"Your data reader object is a : {dataReader.GetType().Name}");
                    Console.WriteLine("\n*** Current Inventory ***");
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"-> Car #{dataReader["CarId"]} is a {dataReader["Make"]}.");
                    }
                }
            }
        }

        static void Demo3_DalOperations()
        {
            Console.WriteLine("======================================");
            InventoryDal dal = new InventoryDal();
            var list = dal.GetAllInventory();
            Console.WriteLine("=============== All Car ===============");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.CarId}\t{item.Make}\t{item.Color}\t{item.PetName}");
            }
            Console.WriteLine();

            var car = dal.GetCar(list.OrderBy(x => x.Color).Select(x => x.CarId).First());
            Console.WriteLine("=============== First Car By Color ===============");
            Console.WriteLine($"{car.CarId}\t{car.Make}\t{car.Color}\t{car.PetName}");

            try
            {
                dal.DeleteCar(5);
                Console.WriteLine("Car deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred : {ex.Message}");
            }

            dal.InsertAuto(new Car { Color = "Blue", Make = "Pilot", PetName = "TowMonster" });
            list = dal.GetAllInventory();

            var newCar = list.First(x => x.PetName == "TowMonster");
            Console.WriteLine("=============== New Car ===============");
            Console.WriteLine($"{newCar.CarId}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");

            dal.DeleteCar(newCar.CarId);

            var petName = dal.LookUpPetName(car.CarId);
            Console.WriteLine("=============== Pet Name ===============");
            Console.WriteLine($"Car pet name: {petName}");

            Console.WriteLine("***** Simple Transaction Example *****\n");
            bool throwEx = true;
            Console.Write("Do you want to throw an exception (Y or N): ");
            var userAnswer = Console.ReadLine();
            if (userAnswer?.ToLower() == "n")
            {
                throwEx = false;
            }
            var dal2 = new InventoryDal();
            dal2.ProccessCreditRisk(throwEx, 1);
            Console.WriteLine("Check CreditRisk table for results");
        }

        public static void DoBulkCopy()
        {
            Console.WriteLine(" ************** Do Bulk Copy ************** ");
            var cars = new List<Car>
            {
                new Car() {Color = "Blue", Make = "Honda", PetName = "MyCar1"},
                new Car() {Color = "Red", Make = "Volvo", PetName = "MyCar2"},
                new Car() {Color = "White", Make = "VW", PetName = "MyCar3"},
                new Car() {Color = "Yellow", Make = "Toyota", PetName = "MyCar4"}
            };
            ProcessBulkImport.ExecuteBulkImport(cars, "Inventory");
            InventoryDal dal = new InventoryDal();
            var list = dal.GetAllInventory();
            Console.WriteLine(" ************** All Cars ************** ");
            Console.WriteLine("CarId\tMake\tColor\tPet Name");
            foreach (var itm in list)
            {
                Console.WriteLine($"{itm.CarId}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
            }
            Console.WriteLine();
        }
    }
}
