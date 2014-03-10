using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s00119500.Models;

namespace s00119500.DAL
{
    public interface InterfaceTripRepository //: IDisposable
    {
        // show all trips 
        IQueryable<Trips> DisplayAllTrips();
        // add trip 
        //Trips addTrip(Trips t);
        //// add leg, you'll need the trip your adding it to
        //Legs addLeg(Legs l, Trips t);
    }
}
