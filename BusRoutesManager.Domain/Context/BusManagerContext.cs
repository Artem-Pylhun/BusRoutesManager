using BusRoutesManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Domain.Context
{
    public class BusManagerContext:DbContext
    {
        public BusManagerContext()
        {
            
        }
        public DbSet<Bus> Buses => Set<Bus>();
        public DbSet<BusStation> BusStations => Set<BusStation>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Route> Routes => Set<Route>();
        public DbSet<RouteNode> RouteNodes => Set<RouteNode>();
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<User> Users => Set<User>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=BusDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.ArrivalStation)
                .WithMany(s => s.ArrivalTickets)
                .HasForeignKey(t => t.ArrivalStationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.DepartureStation)
                .WithMany(s => s.DepartureTickets)
                .HasForeignKey(t => t.DepartureStationId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
