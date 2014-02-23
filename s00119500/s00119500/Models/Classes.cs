using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s00119500.Models
{
    public class Classes
    {
    }

    public class Trips 
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Legs> _legs { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int minimunNumberOfGuests { get; set; }
    }

    public class Legs //: Trips
	{
        public int id { get; set; }
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; } 
	}

    public class Guest
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}