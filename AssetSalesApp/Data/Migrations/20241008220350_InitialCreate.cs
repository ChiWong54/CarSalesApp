using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetSalesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    DateAcquired = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InUse = table.Column<bool>(type: "INTEGER", nullable: false),
                    PurchasePrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "DateAcquired", "InUse", "Location", "Name", "PurchasePrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Location1", "Asset1", 1234.0 },
                    { 2, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Location2", "Asset2", 4321.0 },
                    { 3, new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Location3", "Asset3", 2345.0 },
                    { 4, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Location4", "Asset4", 5432.0 },
                    { 5, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Location5", "Asset5", 3456.0 },
                    { 6, new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Location6", "Asset6", 6543.0 },
                    { 7, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Location7", "Asset7", 4567.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
