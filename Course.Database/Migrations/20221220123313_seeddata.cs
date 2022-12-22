using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comp.Database.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "CompanyName", "OrgNumber" },
                values: new object[,]
                {
                    { 1, "Intel", 638579531L },
                    { 2, "AMD", 754289571L }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName" },
                values: new object[,]
                {
                    { 1, "Company sales" },
                    { 2, "Private person sales" },
                    { 3, "Junior Marketing" },
                    { 4, "Senior Marketing" },
                    { 5, "Hardware developer" },
                    { 6, "Software developer" },
                    { 7, "Hardware reasearch" },
                    { 8, "Software research" },
                    { 9, "CEO" },
                    { 10, "CTO" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, 1, "Sales" },
                    { 2, 1, "Marketing" },
                    { 3, 1, "Development" },
                    { 4, 1, "Research" },
                    { 5, 2, "Sales" },
                    { 6, 2, "Marketing" },
                    { 7, 2, "Development" },
                    { 8, 2, "Research" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DepartmentId", "Firstname", "Lastname", "Salary", "Union" },
                values: new object[,]
                {
                    { 1, 1, "Marcus", "Gustafsson", 30000, false },
                    { 2, 2, "Peter", "Gustafsson", 32000, true },
                    { 3, 3, "Kalle", "Fredriksson", 39000, false },
                    { 4, 4, "Paul", "Goodman", 40000, false },
                    { 5, 5, "Sandra", "Carlsson", 41000, true },
                    { 6, 6, "Pete", "Friedman", 29000, false },
                    { 7, 7, "Emma", "Svensson", 43000, false },
                    { 8, 8, "Lina", "Wiklund", 37000, true }
                });

            migrationBuilder.InsertData(
                table: "PersonPositions",
                columns: new[] { "PersonId", "PositionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 9 },
                    { 2, 4 },
                    { 2, 10 },
                    { 3, 6 },
                    { 4, 7 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 5 },
                    { 8, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PersonPositions",
                keyColumns: new[] { "PersonId", "PositionId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
