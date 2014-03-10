using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using s00119500.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace s00119500.DAL
{
    public class ContextClass: DbContext 
                                         
    {
        public DbSet<Trips> Trips { get; set; }
        public DbSet<Legs> Legs { get; set; }
        public DbSet<Guest> Guest { get; set; }
        
        //set connection string
        public ContextClass() : base("TravelDatabase")
        {
            Database.SetInitializer(new TravelInitializer());
        }

        // changes th db table names from pural to singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }// end db Class

    public class TravelInitializer : DropCreateDatabaseIfModelChanges<ContextClass>
        /// this will drop the create database() if the model changes
    {
        protected override void Seed(ContextClass context) // protected /  Seed not seed...
        {
            /// seed data into database
            var seededTrips = new List<Trips> 
            {
            new Trips { name="Tunisan Adventure", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") },
            new Trips { name="An Irish Road", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") },
            new Trips { name="Why go to France?", minimunNumberOfGuests=50, startDate= DateTime.Parse("1/12/2015"), endDate=DateTime.Parse("29/12/2015") }
            };// end list
            
            seededTrips.ForEach(t=> context.Trips.Add(t));/// adds seeded trips to the db
            context.SaveChanges();                        ///saves changes

            var seededLegs = new List<Legs> {
                new Legs{ legName="Tunisan Road", tripId=1, legStartDate=DateTime.Parse("1/12/2015"),legEndDate=DateTime.Parse("7/12/2015"),
                        startLocation="Gabes",endLocation="Gadamis"},
                new Legs{ legName="Gadamis Straight", tripId=1, legStartDate=DateTime.Parse("8/12/2015"),legEndDate=DateTime.Parse("10/12/2015"),
                        startLocation="Gadamis",endLocation="Tassilì National Park"},
                new Legs{ legName="Home Run", tripId=1, legStartDate=DateTime.Parse("12/12/2015"),legEndDate=DateTime.Parse("13/12/2015"),
                        startLocation="Tassilì National Park",endLocation="Gabis"},

                new Legs{ legName="Dublin Away", tripId=2, legStartDate=DateTime.Parse("8/12/2015"),legEndDate=DateTime.Parse("10/12/2015"),
                        startLocation="Dublin",endLocation="Offally"},
                new Legs{ legName="Out of Offally", tripId=2, legStartDate=DateTime.Parse("10/12/2015"),legEndDate=DateTime.Parse("12/12/2015"),
                        startLocation="Offally",endLocation="Connemara"},
                new Legs{ legName="Connemaran Potholes", tripId=2, legStartDate=DateTime.Parse("1/12/2015"),legEndDate=DateTime.Parse("7/12/2015"),
                        startLocation="Connemara",endLocation="Connemara"},// lot o potholes
                new Legs{ legName="Home Run", tripId=2, legStartDate=DateTime.Parse("1/12/2015"),legEndDate=DateTime.Parse("7/12/2015"),
                        startLocation="Connemara",endLocation="Dublin"}

            };// end seededLegs

            //add legs to db 
            seededLegs.ForEach(l => context.Legs.Add(l));
            context.SaveChanges();

        }// end seed 
    }

}// namespace