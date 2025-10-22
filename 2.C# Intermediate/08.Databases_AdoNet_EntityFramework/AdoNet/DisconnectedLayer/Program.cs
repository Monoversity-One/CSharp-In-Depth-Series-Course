using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _08_2.AdoNetDisconnectedLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== DisconnectedLayer Unified Demos =====");
                Console.WriteLine("1) Build/print DataSet in-memory and XML (ConsoleApp1)");
                Console.WriteLine("2) SqlDataAdapter: Fill DataSet from Inventory and print (ConsoleApp2)");
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
                            Demo1_InMemoryDataSet();
                            break;
                        case "2":
                            Demo2_AdapterFillFromDb();
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

        // From ConsoleApp1
        private static void Demo1_InMemoryDataSet()
        {
            var carsInverntoryDS = new DataSet("Car Inventory");
            carsInverntoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInverntoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInverntoryDS.ExtendedProperties["Company"] = "AMZ Software group";

            FillDataSet(carsInverntoryDS);
            PrintDataSet(carsInverntoryDS);

            carsInverntoryDS.WriteXml("carsDataSet.xml");
            carsInverntoryDS.WriteXmlSchema("catsDataSet.xsd");

            carsInverntoryDS.Clear();
            Console.WriteLine("----------------------");
            carsInverntoryDS.ReadXml("carsDataSet.xml");
        }

        // From ConsoleApp2
        private static void Demo2_AdapterFillFromDb()
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DataSet ds = new DataSet("AutoLot");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Inventory", connectionString);
            adapter.Fill(ds, "Inventory");
            PrintDataSet(ds);
        }

        private static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine($"DataSet name = {ds.DataSetName}");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                Console.WriteLine($"Key = {de.Key},Value = {de.Value}");
            }
            Console.WriteLine();
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine($"=> {dt.TableName} Table : ");
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Columns[curCol].ColumnName + "\t");
                }
                Console.WriteLine("--------------------");
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void FillDataSet(DataSet carsInverntoryDS)
        {
            var carIDColumn = new DataColumn("CarID", typeof(int))
            {
                Caption = "Car ID",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption = "Pet Name" };

            var invertoryTable = new DataTable("Inventory");
            invertoryTable.Columns.AddRange(new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            DataRow carRow = invertoryTable.NewRow();
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["PetName"] = "Hamlet";
            invertoryTable.Rows.Add(carRow);

            carRow = invertoryTable.NewRow();
            carRow[1] = "Saab";
            carRow[2] = "Red";
            carRow[3] = "Sea Breeze";
            invertoryTable.Rows.Add(carRow);

            invertoryTable.PrimaryKey = new[] { invertoryTable.Columns[0] };

            carsInverntoryDS.Tables.Add(invertoryTable);
        }
    }
}
