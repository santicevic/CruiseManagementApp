﻿// <auto-generated />
using System;
using CruiseManagementApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CruiseManagementApp.Data.Migrations
{
    [DbContext(typeof(CruiseManagementContext))]
    [Migration("20190430114946_CabinUpdate")]
    partial class CabinUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Cabin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Cabins");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Cruise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PortOfDeparture");

                    b.Property<int>("ShipId");

                    b.HasKey("Id");

                    b.HasIndex("ShipId");

                    b.ToTable("Cruises");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.EmployeeOnCruise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CruiseId");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CruiseId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesOnCruises");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabinId");

                    b.Property<int>("CruiseId");

                    b.Property<int>("PassengerId");

                    b.HasKey("Id");

                    b.HasIndex("CabinId");

                    b.HasIndex("CruiseId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<DateTime>("YearOfAssembly");

                    b.HasKey("Id");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Cruise", b =>
                {
                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Ship", "Ship")
                        .WithMany("Cruises")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.EmployeeOnCruise", b =>
                {
                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Cruise", "Cruise")
                        .WithMany("Employees")
                        .HasForeignKey("CruiseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Employee", "Employee")
                        .WithMany("Cruises")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CruiseManagementApp.Data.Entities.Models.Reservation", b =>
                {
                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Cabin", "Cabin")
                        .WithMany("Reservations")
                        .HasForeignKey("CabinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Cruise", "Cruise")
                        .WithMany("Reservations")
                        .HasForeignKey("CruiseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CruiseManagementApp.Data.Entities.Models.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
