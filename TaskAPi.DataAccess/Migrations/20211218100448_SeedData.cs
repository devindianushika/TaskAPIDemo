using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPi.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2021, 12, 18, 15, 34, 47, 378, DateTimeKind.Local).AddTicks(38), " Physical health relared task from DB", new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 0, "Morning Exercising" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
