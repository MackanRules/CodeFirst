﻿// <auto-generated />
using Course.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Comp.Database.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20221221195819_NearlyDone")]
    partial class NearlyDone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Course.Database.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("OrgNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Companys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Intel",
                            OrgNumber = 638579531L
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "AMD",
                            OrgNumber = 754289571L
                        });
                });

            modelBuilder.Entity("Course.Database.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            DepartmentName = "Development"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 1,
                            DepartmentName = "Research"
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 2,
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 2,
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 2,
                            DepartmentName = "Development"
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 2,
                            DepartmentName = "Research"
                        });
                });

            modelBuilder.Entity("Course.Database.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<bool>("Union")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Firstname = "Marcus",
                            Lastname = "Gustafsson",
                            Salary = 30000,
                            Union = false
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Firstname = "Peter",
                            Lastname = "Gustafsson",
                            Salary = 32000,
                            Union = true
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Firstname = "Kalle",
                            Lastname = "Fredriksson",
                            Salary = 39000,
                            Union = false
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Firstname = "Paul",
                            Lastname = "Goodman",
                            Salary = 40000,
                            Union = false
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            Firstname = "Sandra",
                            Lastname = "Carlsson",
                            Salary = 41000,
                            Union = true
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 6,
                            Firstname = "Pete",
                            Lastname = "Friedman",
                            Salary = 29000,
                            Union = false
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 7,
                            Firstname = "Emma",
                            Lastname = "Svensson",
                            Salary = 43000,
                            Union = false
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 8,
                            Firstname = "Lina",
                            Lastname = "Wiklund",
                            Salary = 37000,
                            Union = true
                        });
                });

            modelBuilder.Entity("Course.Database.Entities.PersonPosition", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("PersonPositions");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            PositionId = 1
                        },
                        new
                        {
                            PersonId = 2,
                            PositionId = 4
                        },
                        new
                        {
                            PersonId = 3,
                            PositionId = 6
                        },
                        new
                        {
                            PersonId = 4,
                            PositionId = 7
                        },
                        new
                        {
                            PersonId = 5,
                            PositionId = 2
                        },
                        new
                        {
                            PersonId = 6,
                            PositionId = 3
                        },
                        new
                        {
                            PersonId = 7,
                            PositionId = 5
                        },
                        new
                        {
                            PersonId = 8,
                            PositionId = 8
                        },
                        new
                        {
                            PersonId = 1,
                            PositionId = 9
                        },
                        new
                        {
                            PersonId = 2,
                            PositionId = 10
                        });
                });

            modelBuilder.Entity("Course.Database.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionName = "Company sales"
                        },
                        new
                        {
                            Id = 2,
                            PositionName = "Private person sales"
                        },
                        new
                        {
                            Id = 3,
                            PositionName = "Junior Marketing"
                        },
                        new
                        {
                            Id = 4,
                            PositionName = "Senior Marketing"
                        },
                        new
                        {
                            Id = 5,
                            PositionName = "Hardware developer"
                        },
                        new
                        {
                            Id = 6,
                            PositionName = "Software developer"
                        },
                        new
                        {
                            Id = 7,
                            PositionName = "Hardware reasearch"
                        },
                        new
                        {
                            Id = 8,
                            PositionName = "Software research"
                        },
                        new
                        {
                            Id = 9,
                            PositionName = "CEO"
                        },
                        new
                        {
                            Id = 10,
                            PositionName = "CTO"
                        });
                });

            modelBuilder.Entity("PersonPosition", b =>
                {
                    b.Property<int>("PersonsId")
                        .HasColumnType("int");

                    b.Property<int>("PositionsId")
                        .HasColumnType("int");

                    b.HasKey("PersonsId", "PositionsId");

                    b.HasIndex("PositionsId");

                    b.ToTable("PersonPosition");
                });

            modelBuilder.Entity("Course.Database.Entities.Department", b =>
                {
                    b.HasOne("Course.Database.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Course.Database.Entities.Person", b =>
                {
                    b.HasOne("Course.Database.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Course.Database.Entities.PersonPosition", b =>
                {
                    b.HasOne("Course.Database.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course.Database.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("PersonPosition", b =>
                {
                    b.HasOne("Course.Database.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course.Database.Entities.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
