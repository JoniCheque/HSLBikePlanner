﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Contexts;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(BicycleDataContext))]
    [Migration("20230307204606_SetDistanceToInt")]
    partial class SetDistanceToInt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Distance")
                        .HasColumnType("INTEGER");

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
