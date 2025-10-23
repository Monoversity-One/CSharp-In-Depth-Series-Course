using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatReservationSystem.Model
{
    public class Sailor
    {
        public int Id { get; set; }
        public string SailorName { get; set; }
        public int SailorRate { get; set; }
        public DateTime SailorBirthDate { get; set; }
    }
}
