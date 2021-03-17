using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyTripLog.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Forida",
                    Start = 4/20/2021,
                    End = 4/23/2021,
                    Accomodations = "Pool",
                    Todo = "Nothing"
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "California",
                    Start = 5/15/2021,
                    End = 5/20/2021,
                    Accomodations = "Pool",
                    Todo = "Nothing"
                },
                new Trip
                {
                    TripId = 3,
                    Destination = "Michigan",
                    Start = 6/23/2021,
                    End = 6/26/2021,
                    Accomodations = "Amusement Park",
                    Todo = "Go to park"
                }
                );
        }
    }
}
