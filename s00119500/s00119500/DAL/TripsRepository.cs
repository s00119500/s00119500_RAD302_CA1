using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using s00119500.Models;
/// logic for methods
namespace s00119500.DAL
{
    public class TripsRepository : InterfaceTripRepository
    {
        private ContextClass _ctxClass;
        public TripsRepository()
        {
            _ctxClass = new ContextClass();
        }

        public IQueryable<s00119500.Models.Trips> DisplayAllTrips()
        {

            return _ctxClass.Trips;
        }
        //public IQueryable<College2.Models.Student> GetAllStudents()
        //{
        //    return _ctx.Students.Include(s => s.Enrollments).OrderBy(s => s.LastName);
        //}

    }
}