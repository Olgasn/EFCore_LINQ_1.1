﻿// <auto-generated />
using EFCore_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFCore_LINQ.Migrations
{
    [DbContext(typeof(FuelContext))]
    [Migration("20171008184338_InitialSqlite")]
    partial class InitialSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("EFCore_LINQ.Models.Fuel", b =>
                {
                    b.Property<int>("FuelID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("FuelDensity");

                    b.Property<string>("FuelType");

                    b.HasKey("FuelID");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("EFCore_LINQ.Models.Operation", b =>
                {
                    b.Property<int>("OperationID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("FuelID");

                    b.Property<float?>("Inc_Exp");

                    b.Property<int?>("TankID");

                    b.HasKey("OperationID");

                    b.HasIndex("FuelID");

                    b.HasIndex("TankID");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("EFCore_LINQ.Models.Tank", b =>
                {
                    b.Property<int>("TankID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TankMaterial");

                    b.Property<string>("TankPicture");

                    b.Property<string>("TankType");

                    b.Property<float>("TankVolume");

                    b.Property<float>("TankWeight");

                    b.HasKey("TankID");

                    b.ToTable("Tanks");
                });

            modelBuilder.Entity("EFCore_LINQ.Models.Operation", b =>
                {
                    b.HasOne("EFCore_LINQ.Models.Fuel", "Fuel")
                        .WithMany("Operations")
                        .HasForeignKey("FuelID");

                    b.HasOne("EFCore_LINQ.Models.Tank", "Tank")
                        .WithMany("Operations")
                        .HasForeignKey("TankID");
                });
#pragma warning restore 612, 618
        }
    }
}
