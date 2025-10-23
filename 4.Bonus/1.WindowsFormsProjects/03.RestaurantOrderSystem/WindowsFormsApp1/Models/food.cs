using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantOrderSystem.Models
{
    public class food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
    }
}
