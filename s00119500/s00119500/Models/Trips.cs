using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s00119500.Models
{
    public class Trips
    {
        
        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TripsId { get; set; }
        public string name { get; set; }  // i.e sahara adventure
        public DateTime startDate { get; set; }  
        public DateTime endDate { get; set; }
        public int minimunNumberOfGuests { get; set; } // min amount required to be valid

        //public List<Legs> legs { get; set; }
        //public List<Guest> totalAssociatedGuests { get; set; }
    }

    public class Legs : Trips
    {
        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LegsId { get; set; }
        public int tripId { get; set; }
        public string legName { get; set; }
        public string startLocation { get; set; } // city name 
        public string endLocation { get; set; }   // city name 
        public DateTime legStartDate { get; set; }
        public DateTime legEndDate { get; set; }

        //public List<Guest> legsAssociatedGuests{ get; set; }
    }

    public class Guest
    {
        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int GuestId { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}//name