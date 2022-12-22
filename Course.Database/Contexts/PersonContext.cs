using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Course.Database.Contexts
{
    public class PersonContext : DbContext
    {
        public DbSet<Company> Companys => Set<Company>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<PersonPosition> PersonPositions => Set<PersonPosition>();
        public DbSet<Position> Positions => Set<Position>();
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PersonPosition>().HasKey(pp =>
            new { pp.PersonId, pp.PositionId });
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var Companys = new List<Company>
            {
                new Company { Id = 1, CompanyName = "Intel", OrgNumber = 638579531},
                new Company { Id = 2, CompanyName = "AMD", OrgNumber = 754289571}
            };
            builder.Entity<Company>().HasData(Companys);

            var Departments = new List<Department>
            {
                new Department { Id = 1, CompanyId = 1, DepartmentName = "Sales"},
                new Department { Id = 2, CompanyId = 1, DepartmentName = "Marketing"},
                new Department { Id = 3, CompanyId = 1, DepartmentName = "Development"},
                new Department { Id = 4, CompanyId = 1, DepartmentName = "Research"},

                new Department { Id = 5, CompanyId = 2, DepartmentName = "Sales"},
                new Department { Id = 6, CompanyId = 2, DepartmentName = "Marketing"},
                new Department { Id = 7, CompanyId = 2, DepartmentName = "Development"},
                new Department { Id = 8, CompanyId = 2, DepartmentName = "Research"}
            };
            builder.Entity<Department>().HasData(Departments);

            var Positions = new List<Position>
            {
                new Position { Id = 1, PositionName = "Company sales"},
                new Position { Id = 2, PositionName = "Private person sales"},
                new Position { Id = 3, PositionName = "Junior Marketing"},
                new Position { Id = 4, PositionName = "Senior Marketing"},
                new Position { Id = 5, PositionName = "Hardware developer"},
                new Position { Id = 6, PositionName = "Software developer"},
                new Position { Id = 7, PositionName = "Hardware reasearch"},
                new Position { Id = 8, PositionName = "Software research"},
                new Position { Id = 9, PositionName = "CEO"},
                new Position { Id = 10, PositionName = "CTO"},
            };
            builder.Entity<Position>().HasData(Positions);

            var Persons = new List<Person>
            {
                new Person { Id = 1, DepartmentId = 1, Firstname = "Marcus", Lastname = "Gustafsson", 
                         Salary = 30000, Union = false},
                new Person { Id = 2, DepartmentId = 2, Firstname = "Peter", Lastname = "Gustafsson",
                         Salary = 32000, Union = true},
                new Person { Id = 3, DepartmentId = 3, Firstname = "Kalle", Lastname = "Fredriksson",
                         Salary = 39000, Union = false},
                new Person { Id = 4, DepartmentId = 4, Firstname = "Paul", Lastname = "Goodman",
                         Salary = 40000, Union = false},

                new Person { Id = 5, DepartmentId = 5, Firstname = "Sandra", Lastname = "Carlsson",
                         Salary = 41000, Union = true},
                new Person { Id = 6, DepartmentId = 6, Firstname = "Pete", Lastname = "Friedman",
                         Salary = 29000, Union = false},
                new Person { Id = 7, DepartmentId = 7, Firstname = "Emma", Lastname = "Svensson",
                         Salary = 43000, Union = false},
                new Person { Id = 8, DepartmentId = 8, Firstname = "Lina", Lastname = "Wiklund",
                         Salary = 37000, Union = true},
            };
            builder.Entity<Person>().HasData(Persons);

            var PersonPositions = new List<PersonPosition>
            {
                new PersonPosition { PersonId = 1, PositionId = 1},
                new PersonPosition { PersonId = 2, PositionId = 4},
                new PersonPosition { PersonId = 3, PositionId = 6},
                new PersonPosition { PersonId = 4, PositionId = 7},

                new PersonPosition { PersonId = 5, PositionId = 2},
                new PersonPosition { PersonId = 6, PositionId = 3},
                new PersonPosition { PersonId = 7, PositionId = 5},
                new PersonPosition { PersonId = 8, PositionId = 8},

                new PersonPosition { PersonId = 1, PositionId = 9},
                new PersonPosition { PersonId = 2, PositionId = 10},
            };
            builder.Entity<PersonPosition>().HasData(PersonPositions);

        }

    }
}
