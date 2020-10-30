﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20201030234326_NationalParkFix1")]
    partial class NationalParkFix1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NationalParkDescription");

                    b.Property<string>("NationalParkLocation");

                    b.Property<string>("NationalParkName");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");
                });

            modelBuilder.Entity("ParksApi.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StateDescription");

                    b.Property<string>("StateName");

                    b.Property<int?>("StateParkId");

                    b.HasKey("StateId");

                    b.HasIndex("StateParkId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("ParksApi.Models.StateJoin", b =>
                {
                    b.Property<int>("StateJoinId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("NationalParkId");

                    b.Property<int>("StateId");

                    b.Property<int?>("StateParkId");

                    b.HasKey("StateJoinId");

                    b.HasIndex("NationalParkId");

                    b.HasIndex("StateId");

                    b.HasIndex("StateParkId");

                    b.ToTable("StateJoins");
                });

            modelBuilder.Entity("ParksApi.Models.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StateParkDescription");

                    b.Property<string>("StateParkLocation");

                    b.Property<string>("StateParkName");

                    b.HasKey("StateParkId");

                    b.ToTable("StateParks");
                });

            modelBuilder.Entity("ParksApi.Models.State", b =>
                {
                    b.HasOne("ParksApi.Models.StatePark")
                        .WithMany("States")
                        .HasForeignKey("StateParkId");
                });

            modelBuilder.Entity("ParksApi.Models.StateJoin", b =>
                {
                    b.HasOne("ParksApi.Models.NationalPark", "NationalPark")
                        .WithMany("States")
                        .HasForeignKey("NationalParkId");

                    b.HasOne("ParksApi.Models.State", "State")
                        .WithMany("StateJoins")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ParksApi.Models.StatePark", "StatePark")
                        .WithMany()
                        .HasForeignKey("StateParkId");
                });
#pragma warning restore 612, 618
        }
    }
}
