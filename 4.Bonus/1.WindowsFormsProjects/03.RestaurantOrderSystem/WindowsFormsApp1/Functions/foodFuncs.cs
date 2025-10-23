using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantOrderSystem.Models;

namespace RestaurantOrderSystem.Functions
{
    public class foodFuncs
    {
        public static void Add(int id,string name,int count,float price)
        {
            List<food> currentFoods = Read();

            food newFood = new food()
            {
                Id = id,
                Name =  name,
                Price = price,
                Count = count
            };


            currentFoods.Add(newFood);

            //delete file first
            if (File.Exists("foods.txt"))
            {
                File.Delete("foods.txt");
            }

            
            //create new file with new items
            StreamWriter sw = new StreamWriter("foods.txt",true);
            foreach (var item in currentFoods)
            {
                string line = item.Id + "*" + item.Name + "*" + item.Count + "*" + item.Price;

                sw.WriteLine(line);
            }

            sw.Close();
        }

        public static void Delete(int id)
        {
            List<food> currentFoods = Read();

            food fd = currentFoods.Find(c => c.Id == id);

            currentFoods.Remove(fd);

            //delete file first
            if (File.Exists("foods.txt"))
            {
                File.Delete("foods.txt");
            }


            //create new file with new items
            StreamWriter sw = new StreamWriter("foods.txt", true);
            foreach (var item in currentFoods)
            {
                string line = item.Id + "*" + item.Name + "*" + item.Count + "*" + item.Price;

                sw.WriteLine(line);
            }

            sw.Close();
        }

        public static void Update(int id, string name, int count, float price)
        {
            List<food> currentFoods = Read();


            food fd = currentFoods.Find(c => c.Id == id);
            fd.Count = count;
            fd.Name = name;
            fd.Price = price;



            //delete file first
            if (File.Exists("foods.txt"))
            {
                File.Delete("foods.txt");
            }


            //create new file with new items
            StreamWriter sw = new StreamWriter("foods.txt", true);
            foreach (var item in currentFoods)
            {
                string line = item.Id + "*" + item.Name + "*" + item.Count + "*" + item.Price;

                sw.WriteLine(line);
            }

            sw.Close();
        }

        public static List<food> Read()
        {
            StreamReader sr = new StreamReader("foods.txt",true);
            string line = sr.ReadLine();

            List<food> foods = new List<food>();


            while (line != null)
            {
                string[] lineArr = line.Split('*');

                food fd = new food();
                fd.Id = int.Parse(lineArr[0]);
                fd.Name = lineArr[1];
                fd.Count = int.Parse(lineArr[2]);
                fd.Price = float.Parse(lineArr[3]);

                foods.Add(fd);

                line = sr.ReadLine();
            }


            sr.Close();

            return foods;
        }


        public static List<int> CurrentFoodIds()
        {
            List<int> ids = new List<int>();

            StreamReader sr = new StreamReader("foods.txt", true);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] linefoods = line.Split('*');

                ids.Add(int.Parse(linefoods[0]));

                line = sr.ReadLine();
            }


            sr.Close();

            return ids;
        }

    }
}
