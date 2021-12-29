using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPi.DataAccess.Migrations
{
    public partial class AuthorEntitiydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Authorid",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[] { 1, "James William" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[] { 2, "Merry Diyas" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[] { 3, "Stein Martin" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Authorid", "Created", "Due" },
                values: new object[] { 1, new DateTime(2021, 12, 19, 23, 20, 42, 653, DateTimeKind.Local).AddTicks(3671), new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "Authorid", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 3, new DateTime(2021, 12, 19, 23, 20, 42, 654, DateTimeKind.Local).AddTicks(7480), " test from db", new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 0, "Watch television" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_Authorid",
                table: "Todos",
                column: "Authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_Authorid",
                table: "Todos",
                column: "Authorid",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_Authorid",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_Authorid",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Authorid",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 12, 18, 15, 34, 47, 378, DateTimeKind.Local).AddTicks(38), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
