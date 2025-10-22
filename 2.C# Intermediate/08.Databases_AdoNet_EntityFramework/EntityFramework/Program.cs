using System;
using System.Linq;
using System.Data.Entity;
using _08_3.EFExample.AutoLotDAL.EF;
using _08_3.EFExample.AutoLotDAL.Models;
using _08_3.EFExample.AutoLotDAL.Repos;

namespace _08_3.EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== EFUnified Demos =====");
                Console.WriteLine("1) List Inventory");
                Console.WriteLine("2) Add/Delete Car");
                Console.WriteLine("3) List Customers & Orders");
                Console.WriteLine("4) Initialize/Seed DB");
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
                            ListInventory();
                            break;
                        case "2":
                            AddDeleteCar();
                            break;
                        case "3":
                            ListCustomersOrders();
                            break;
                        case "4":
                            InitializeDb();
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

        static void ListInventory()
        {
            using (var repo = new InventoryRepo())
            {
                var cars = repo.GetAll().ToList();
                Console.WriteLine("CarId\tMake\tColor\tPetName");
                foreach (var c in cars)
                {
                    Console.WriteLine($"{c.Id}\t{c.Make}\t{c.Color}\t{c.PetName}");
                }
            }
        }

        static void AddDeleteCar()
        {
            using (var repo = new InventoryRepo())
            {
                var car = new Inventory { Make = "Honda", Color = "Blue", PetName = "EFUnified" };
                repo.Add(car);
                repo.SaveChanges();
                Console.WriteLine($"Inserted CarId={car.Id}");
                repo.Delete(car);
                repo.SaveChanges();
                Console.WriteLine("Deleted inserted car.");
            }
        }

        static void ListCustomersOrders()
        {
            using (var db = new AutoLotEntities())
            {
                var customers = db.Customers.ToList();
                foreach (var cust in customers)
                {
                    Console.WriteLine($"{cust.Id}: {cust.FirstName} {cust.LastName}");
                }
                var orders = db.Orders.ToList();
                Console.WriteLine($"Orders count: {orders.Count}");
            }
        }

        static void InitializeDb()
        {
            Database.SetInitializer(new MyDataInitializer());
            using (var ctx = new AutoLotEntities())
            {
                ctx.Database.Initialize(true);
            }
            Console.WriteLine("Database initialized/seeded.");
        }
    }
}
