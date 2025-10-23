using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantOrderSystem.Models
{
    public class order
    {
        public int Id { get; set; }
        public List<food> foods { get; set; }
        public int[] foodsCounts { get; set; }
    }
}
