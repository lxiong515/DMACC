using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Xiong.Migrations
{
    public partial class movieMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[] { 6, "Classic", 5m, new DateTime(1942, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casablanca" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[] { 7, "Action", 9m, new DateTime(2017, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Woman" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[] { 8, "Action", 12m, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Wick" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
