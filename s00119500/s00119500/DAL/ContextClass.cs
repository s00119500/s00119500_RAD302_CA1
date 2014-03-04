using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using s00119500.Models;
using System.Data.Entity;

namespace s00119500.DAL
{
    public class ContextClass: DbContext /// had problems with DBContext
                                         /// forgot to install entity framework...
    {
        public DbSet<Trips> Trips { get; set; }
        public DbSet<Legs> Legs { get; set; }
        public DbSet<Guest> Guest { get; set; }
        
        //set connection string
        //public TravelContext() : base("TravelDatabase")
        //{
        //    Database.SetInitializer(new SchoolInitializer());
        //}

    }// end db Class

    class TravelInitializer : DropCreateDatabaseIfModelChanges<ContextClass>
        /// this will drop the create database() if the model changes
    {
        public override void seed(ContextClass context)
        {
            /// seed data into database
            var seededTrips = new List<Trips> {
            new Trips { name="Sahara Adventure", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") },
            new Trips { name="Pan American Highway", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") },
            new Trips { name="Oriental Express", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") }
            };// end list
            
            seededTrips.ForEach(t=> context.Trips.Add(t));/// adds seeded trips to the db
            context.SaveChanges();                        ///saves changes

            

        }// end seed 
    }

}// namespace