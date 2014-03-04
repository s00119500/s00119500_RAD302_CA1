using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s00119500.Models
{
    public class Trips
    {
        public int TripsId { get; set; }
        public string name { get; set; }  // i.e sahara adventure
        public DateTime startDate { get; set; }  
        public DateTime endDate { get; set; }
        public int minimunNumberOfGuests { get; set; } // min amount required to be valid

        public List<Legs> legs { get; set; }
        public List<Guest> associatedGuests { get; set; }
    }

    public class Legs : Trips
    {
        public int LegsId { get; set; }
        public string legName { get; set; }
        public string startLocation { get; set; } // city name 
        public string endLocation { get; set; }   // city name 
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class Guest
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
    }
}//name