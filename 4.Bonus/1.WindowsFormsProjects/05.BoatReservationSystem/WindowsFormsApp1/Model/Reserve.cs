using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatReservationSystem.Model
{
    public class Reserve
    {
        public int Id { get; set; }
        public int Bid { get; set; }
        public int Sid { get; set; }
        public string SailorName { get; set; }
        public string BoatName { get; set; }
        public DateTime ReserveDate { get; set; }
    }
}
