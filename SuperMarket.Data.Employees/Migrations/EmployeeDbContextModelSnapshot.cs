﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SuperMarket.Data.Employees.Data;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AadharDocument")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("aadhar_document");

                    b.Property<string>("AadharNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("aadhar_number");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<int>("Created_by")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("department");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("designation");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("firstName");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean")
                        .HasColumnName("verification");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("updated_at");

                    b.Property<int>("Updated_by")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<int?>("employeeSalaryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("employeeSalaryId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.EmployeeSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("Amount")
                        .HasColumnType("double precision")
                        .HasColumnName("amount");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<int>("Created_by")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int?>("SalaryComponentId")
                        .HasColumnType("integer")
                        .HasColumnName("salary_component_id");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("updated_at");

                    b.Property<int>("Updated_by")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("EmployeeSalary");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.SalaryComponents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ComponentName")
                        .HasColumnType("text")
                        .HasColumnName("component_name");

                    b.Property<string>("ComponentType")
                        .HasColumnType("text")
                        .HasColumnName("component_type");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<int>("Created_by")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("updated_at");

                    b.Property<int>("Updated_by")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<int?>("employeeSalaryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("employeeSalaryId");

                    b.ToTable("SalaryComponents");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<int>("Created_by")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamptz")
                        .HasColumnName("updated_at");

                    b.Property<int>("Updated_by")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.Property<int>("UserType")
                        .HasColumnType("integer")
                        .HasColumnName("user_type");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.Employee", b =>
                {
                    b.HasOne("SuperMarket.Data.Employees.Models.EmployeeSalary", "employeeSalary")
                        .WithMany("Employees")
                        .HasForeignKey("employeeSalaryId");

                    b.Navigation("employeeSalary");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.SalaryComponents", b =>
                {
                    b.HasOne("SuperMarket.Data.Employees.Models.EmployeeSalary", "employeeSalary")
                        .WithMany("SalaryComponents")
                        .HasForeignKey("employeeSalaryId");

                    b.Navigation("employeeSalary");
                });

            modelBuilder.Entity("SuperMarket.Data.Employees.Models.EmployeeSalary", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("SalaryComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
