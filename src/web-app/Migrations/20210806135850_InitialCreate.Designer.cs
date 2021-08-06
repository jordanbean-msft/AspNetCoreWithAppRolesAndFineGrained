﻿// <auto-generated />
using AspNetCoreWithAppRoleAndFineGrained.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace web_app.Migrations
{
    [DbContext(typeof(AspNetCoreWithAppRoleAndFineGrainedDbContext))]
    [Migration("20210806135850_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AADGroupID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("BranchID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BranchID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.HasIndex("BranchID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Salary", b =>
                {
                    b.Property<int>("SalaryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("SalaryID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("SaleID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Employee", b =>
                {
                    b.HasOne("AspNetCoreWithAppRoleAndFineGrained.Models.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Salary", b =>
                {
                    b.HasOne("AspNetCoreWithAppRoleAndFineGrained.Models.Employee", "Employee")
                        .WithOne("Salary")
                        .HasForeignKey("AspNetCoreWithAppRoleAndFineGrained.Models.Salary", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Sale", b =>
                {
                    b.HasOne("AspNetCoreWithAppRoleAndFineGrained.Models.Employee", "Employee")
                        .WithMany("Sales")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Branch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AspNetCoreWithAppRoleAndFineGrained.Models.Employee", b =>
                {
                    b.Navigation("Salary");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
