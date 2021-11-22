﻿// <auto-generated />
using System;
using DemoNetcore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoNetcore.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DemoNetcore.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DemoNetcore.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("movie");
                });

            modelBuilder.Entity("DemoNetcore.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonFullName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("DemoNetcore.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Productname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DemoNetcore.Models.hoadon", b =>
                {
                    b.Property<int>("hoadonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("hoadonCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("hoadonFullName")
                        .HasColumnType("TEXT");

                    b.HasKey("hoadonId");

                    b.HasIndex("PersonId");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("DemoNetcore.Models.Nhanvien", b =>
                {
                    b.HasBaseType("DemoNetcore.Models.Person");

                    b.Property<string>("NhanvienCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("NhanvienFullName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NhanvienId")
                        .HasColumnType("INTEGER");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("DemoNetcore.Models.Student", b =>
                {
                    b.HasBaseType("DemoNetcore.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DemoNetcore.Models.khachhang", b =>
                {
                    b.HasBaseType("DemoNetcore.Models.Person");

                    b.Property<string>("khachhangCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("khachhangFullName")
                        .HasColumnType("TEXT");

                    b.ToTable("khachhang");
                });

            modelBuilder.Entity("DemoNetcore.Models.hoadon", b =>
                {
                    b.HasOne("DemoNetcore.Models.Person", "Person")
                        .WithMany("hoadons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DemoNetcore.Models.Nhanvien", b =>
                {
                    b.HasOne("DemoNetcore.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DemoNetcore.Models.Nhanvien", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoNetcore.Models.Student", b =>
                {
                    b.HasOne("DemoNetcore.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DemoNetcore.Models.Student", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoNetcore.Models.khachhang", b =>
                {
                    b.HasOne("DemoNetcore.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DemoNetcore.Models.khachhang", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoNetcore.Models.Person", b =>
                {
                    b.Navigation("hoadons");
                });
#pragma warning restore 612, 618
        }
    }
}
