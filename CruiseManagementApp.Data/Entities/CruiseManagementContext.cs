using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CruiseManagementApp.Data.Entities
{
    public class CruiseManagementContext : DbContext
    {
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Cruise> Cruises { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeOnCruise> EmployeesOnCruises { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Ship> Ships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CruiseDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeOnCruise>()
                .HasOne(ec => ec.Cruise)
                .WithMany(c => c.Employees)
                .HasForeignKey(ec => ec.CruiseId);

            modelBuilder.Entity<EmployeeOnCruise>()
                .HasOne(ec => ec.Employee)
                .WithMany(e => e.Cruises)
                .HasForeignKey(ec => ec.EmployeeId);
        }
    }
}   
