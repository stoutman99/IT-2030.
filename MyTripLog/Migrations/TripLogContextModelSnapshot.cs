﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTripLog.Models;

namespace MyTripLog.Migrations
{
    [DbContext(typeof(TripLogContext))]
    partial class TripLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTripLog.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accomodations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("End")
                        .HasColumnType("int");

                    b.Property<int>("Start")
                        .HasColumnType("int");

                    b.Property<string>("Todo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            Accomodations = "Pool",
                            Destination = "Forida",
                            End = 0,
                            Start = 0,
                            Todo = "Nothing"
                        },
                        new
                        {
                            TripId = 2,
                            Accomodations = "Pool",
                            Destination = "California",
                            End = 0,
                            Start = 0,
                            Todo = "Nothing"
                        },
                        new
                        {
                            TripId = 3,
                            Accomodations = "Amusement Park",
                            Destination = "Michigan",
                            End = 0,
                            Start = 0,
                            Todo = "Go to park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}