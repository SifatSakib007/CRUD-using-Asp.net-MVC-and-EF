using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuadTheoryLimited_Task.Migrations
{
    /// <inheritdoc />
    public partial class dataInClassTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "CreatedDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(456), "Class 1" },
                    { 2, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(457), "Class 2" },
                    { 3, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(459), "Class 3" },
                    { 4, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(460), "Class 4" },
                    { 5, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(461), "Class 5" },
                    { 6, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(462), "Class 6" },
                    { 7, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(463), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(464), "Class 7" },
                    { 8, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(465), "Class 8" },
                    { 9, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(466), "Class 9" },
                    { 10, new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 6, 2, 17, 6, 7, 306, DateTimeKind.Local).AddTicks(467), "Class 10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
