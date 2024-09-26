﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramaWebMvc.Data;

namespace ProgramaWebMvc.Migrations
{
    [DbContext(typeof(ProgramaWebMvcContext))]
    [Migration("20210716061154_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProgramaWebMvc.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ProgramaWebMvc.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("Sellerid");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("Sellerid");

                    b.ToTable("SalesRecords");
                });

            modelBuilder.Entity("ProgramaWebMvc.Models.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<double>("baseSalary");

                    b.Property<DateTime>("birthDate");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("ProgramaWebMvc.Models.SalesRecord", b =>
                {
                    b.HasOne("ProgramaWebMvc.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("Sellerid");
                });

            modelBuilder.Entity("ProgramaWebMvc.Models.Seller", b =>
                {
                    b.HasOne("ProgramaWebMvc.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
