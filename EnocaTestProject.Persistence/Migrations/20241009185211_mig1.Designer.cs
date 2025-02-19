﻿// <auto-generated />
using System;
using EnocaTestProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnocaTestProject.Persistence.Migrations
{
    [DbContext(typeof(EnocaTestProjectDB))]
    [Migration("20241009185211_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("CarrierIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("CarrierPlusDesiCost")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataState")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.CarrierConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CarrierCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<int>("CarrierMaxDesi")
                        .HasColumnType("int");

                    b.Property<int>("CarrierMinDesi")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataState")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId")
                        .IsUnique();

                    b.ToTable("CarrierConfigurations");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.CarrierReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CarrierCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CarrierReportDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataState")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("CarrierReport");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataState")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderCarrierCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDesi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.CarrierConfiguration", b =>
                {
                    b.HasOne("EnocaTestProject.Domain.Entities.Carrier", "Carrier")
                        .WithOne("CarrierConfiguration")
                        .HasForeignKey("EnocaTestProject.Domain.Entities.CarrierConfiguration", "CarrierId");

                    b.Navigation("Carrier");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.CarrierReport", b =>
                {
                    b.HasOne("EnocaTestProject.Domain.Entities.Carrier", "Carrier")
                        .WithMany("CarrierReports")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrier");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.Order", b =>
                {
                    b.HasOne("EnocaTestProject.Domain.Entities.Carrier", "Carrier")
                        .WithMany("Orders")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrier");
                });

            modelBuilder.Entity("EnocaTestProject.Domain.Entities.Carrier", b =>
                {
                    b.Navigation("CarrierConfiguration")
                        .IsRequired();

                    b.Navigation("CarrierReports");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
