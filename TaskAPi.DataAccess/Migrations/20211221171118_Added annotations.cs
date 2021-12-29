using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPi.DataAccess.Migrations
{
    public partial class Addedannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "12/7", "Colombo", "street1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "20 ", "Colombo", "street2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "52/1", "Kandy", "street3" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 12, 21, 22, 41, 17, 408, DateTimeKind.Local).AddTicks(4298), new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 12, 21, 22, 41, 17, 410, DateTimeKind.Local).AddTicks(1404), new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 12, 19, 23, 20, 42, 653, DateTimeKind.Local).AddTicks(3671), new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 12, 19, 23, 20, 42, 654, DateTimeKind.Local).AddTicks(7480), new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
