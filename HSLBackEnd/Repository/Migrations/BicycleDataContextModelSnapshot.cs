﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Contexts;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(BicycleDataContext))]
    partial class BicycleDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Repository.Entities.BicycleDataEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureStationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureStationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Distance")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Return")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReturnStationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReturnStationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BicycleDataEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
