using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RestaurantOrderSystem.Models;

namespace RestaurantOrderSystem.Functions
{

    //Order Line Sample : orderId*1:5,3:8,5:1,8:2,4:1    => 1:5 = foodId:count
    public static class orderFuncs
    {
        public static void Add(order ord)
        {
            StreamWriter sw = new StreamWriter("orders.txt", true);

            string line = ord.Id + "*";

            for (int i = 0; i < ord.foods.Count; i++)
            {

                line += ord.foods[i].Id + ":" + ord.foods[i].Count + ",";
            }

            sw.WriteLine(line);
            sw.Close();
        }

        public static void Delete()
        {

        }

        public static void Update()
        {

        }


        public static List<order> Read()
        {
            List<order> orders = new List<order>();

            StreamReader sr = new StreamReader("orders.txt", true);
            string line = sr.ReadLine();

            while (line != null)
            {
                order ord = new order();
                ord.foods = new List<food>();

                string[] lineArr = line.Split('*');

                ord.Id = int.Parse(lineArr[0]);

                string[] linefoods = lineArr[1].Split(',');

                foreach (var food in linefoods)
                {
                    if (!string.IsNullOrEmpty(food))
                    {
                        string[] singlefood = food.Split(':');
                        int id = int.Parse(singlefood[0]);

                        ord.foods.Add(GetFoodById(id));
                    }
                   
                }

                orders.Add(ord);

                line = sr.ReadLine();
            }


            sr.Close();

            return orders;
        }

        public static bool CanAddFood(int id, int count)
        {
            List<food> currentFoods = foodFuncs.Read();

            StreamReader sr = new StreamReader("foods.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] lineArr = line.Split('*');

                if (float.Parse(lineArr[2]) >= count)
                {
                    sr.Close();
                    return true;
                }

                line = sr.ReadLine();
            }

            sr.Close();
            return false;
        }


        //Foods Sample Line : 1*foodName*count*price
        public static food GetFoodById(int id)
        {
            food fd = new food();

            StreamReader sr = new StreamReader("foods.txt", true);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] linefoods = line.Split('*');

                if (int.Parse(linefoods[0]) == id)
                {
                    fd.Id = int.Parse(linefoods[0]);
                    fd.Name = linefoods[1];
                    fd.Count = int.Parse(linefoods[2]);
                    fd.Price = float.Parse(linefoods[3]);
                    break;
                }

                line = sr.ReadLine();
            }


            sr.Close();

            return fd;
        }


        public static List<int> CurrentOrderIds()
        {
            List<int> ids = new List<int>();

            StreamReader sr = new StreamReader("orders.txt", true);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] lineorders = line.Split('*');

                ids.Add(int.Parse(lineorders[0]));

                line = sr.ReadLine();
            }


            sr.Close();

            return ids;
        }

        public static float CalculateFoodsPrices(List<food> foods)
        {
            float price = 0;
            foreach (var item in foods)
            {
                item.Price = GetFoodById(item.Id).Price;
            }


            foreach (var item in foods)
            {
                price += item.Price * item.Count;
            }

            return price;
        }

    }
}
