using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlayerDashboard.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    AccountCreatedDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    TotalPlaytimeMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    AverageGameTimeMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalGames = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalWins = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    GameMode = table.Column<int>(type: "INTEGER", nullable: false),
                    Won = table.Column<bool>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameSessions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "AccountCreatedDate", "AverageGameTimeMinutes", "DateOfBirth", "DisplayName", "EmailAddress", "Level", "TotalGames", "TotalPlaytimeMinutes", "TotalWins" },
                values: new object[] { 1, new DateOnly(2024, 8, 14), 126, new DateOnly(2008, 8, 10), "ProGamer123", "john.smith@microsoft.com", 120, 90, 11362, 39 });

            migrationBuilder.InsertData(
                table: "GameSessions",
                columns: new[] { "Id", "Date", "Duration", "GameMode", "PlayerId", "Score", "Won" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 14, 10, 54, 0, 0, DateTimeKind.Unspecified), 239, 2, 1, 3600, false },
                    { 2, new DateTime(2024, 8, 15, 16, 49, 0, 0, DateTimeKind.Unspecified), 82, 1, 1, 1600, true },
                    { 3, new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 118, 1, 1, 2900, true },
                    { 4, new DateTime(2024, 8, 17, 16, 26, 0, 0, DateTimeKind.Unspecified), 119, 1, 1, 2200, false },
                    { 5, new DateTime(2024, 8, 18, 17, 45, 0, 0, DateTimeKind.Unspecified), 53, 0, 1, 4000, true },
                    { 6, new DateTime(2024, 8, 19, 15, 7, 0, 0, DateTimeKind.Unspecified), 59, 0, 1, 3700, true },
                    { 7, new DateTime(2024, 8, 20, 16, 46, 0, 0, DateTimeKind.Unspecified), 134, 1, 1, 2200, true },
                    { 8, new DateTime(2024, 8, 21, 12, 8, 0, 0, DateTimeKind.Unspecified), 198, 0, 1, 1200, true },
                    { 9, new DateTime(2024, 8, 22, 15, 31, 0, 0, DateTimeKind.Unspecified), 51, 2, 1, 1900, true },
                    { 10, new DateTime(2024, 8, 23, 16, 5, 0, 0, DateTimeKind.Unspecified), 147, 1, 1, 3700, false },
                    { 11, new DateTime(2024, 8, 24, 10, 20, 0, 0, DateTimeKind.Unspecified), 50, 2, 1, 2800, true },
                    { 12, new DateTime(2024, 8, 25, 10, 4, 0, 0, DateTimeKind.Unspecified), 119, 1, 1, 3100, false },
                    { 13, new DateTime(2024, 8, 26, 10, 29, 0, 0, DateTimeKind.Unspecified), 71, 2, 1, 3000, true },
                    { 14, new DateTime(2024, 8, 27, 17, 25, 0, 0, DateTimeKind.Unspecified), 92, 0, 1, 1200, false },
                    { 15, new DateTime(2024, 8, 28, 17, 49, 0, 0, DateTimeKind.Unspecified), 93, 0, 1, 1100, false },
                    { 16, new DateTime(2024, 8, 29, 15, 2, 0, 0, DateTimeKind.Unspecified), 128, 1, 1, 1300, false },
                    { 17, new DateTime(2024, 8, 30, 16, 42, 0, 0, DateTimeKind.Unspecified), 203, 0, 1, 1600, true },
                    { 18, new DateTime(2024, 8, 31, 15, 48, 0, 0, DateTimeKind.Unspecified), 239, 2, 1, 3500, true },
                    { 19, new DateTime(2024, 9, 1, 12, 48, 0, 0, DateTimeKind.Unspecified), 160, 1, 1, 2500, false },
                    { 20, new DateTime(2024, 9, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 107, 1, 1, 2100, false },
                    { 21, new DateTime(2024, 9, 3, 16, 28, 0, 0, DateTimeKind.Unspecified), 225, 2, 1, 3600, false },
                    { 22, new DateTime(2024, 9, 4, 16, 33, 0, 0, DateTimeKind.Unspecified), 229, 0, 1, 2600, false },
                    { 23, new DateTime(2024, 9, 5, 17, 46, 0, 0, DateTimeKind.Unspecified), 52, 1, 1, 3600, false },
                    { 24, new DateTime(2024, 9, 6, 12, 25, 0, 0, DateTimeKind.Unspecified), 38, 0, 1, 2400, false },
                    { 25, new DateTime(2024, 9, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 70, 0, 1, 3100, true },
                    { 26, new DateTime(2024, 9, 8, 11, 53, 0, 0, DateTimeKind.Unspecified), 188, 2, 1, 1000, true },
                    { 27, new DateTime(2024, 9, 9, 15, 34, 0, 0, DateTimeKind.Unspecified), 58, 0, 1, 4000, false },
                    { 28, new DateTime(2024, 9, 10, 11, 11, 0, 0, DateTimeKind.Unspecified), 160, 1, 1, 2400, false },
                    { 29, new DateTime(2024, 9, 11, 15, 5, 0, 0, DateTimeKind.Unspecified), 162, 1, 1, 3200, true },
                    { 30, new DateTime(2024, 9, 12, 14, 4, 0, 0, DateTimeKind.Unspecified), 50, 0, 1, 1100, false },
                    { 31, new DateTime(2024, 9, 13, 14, 13, 0, 0, DateTimeKind.Unspecified), 122, 1, 1, 1000, false },
                    { 32, new DateTime(2024, 9, 14, 14, 52, 0, 0, DateTimeKind.Unspecified), 219, 1, 1, 1900, false },
                    { 33, new DateTime(2024, 9, 15, 16, 7, 0, 0, DateTimeKind.Unspecified), 231, 2, 1, 1800, false },
                    { 34, new DateTime(2024, 9, 16, 12, 43, 0, 0, DateTimeKind.Unspecified), 130, 2, 1, 3700, false },
                    { 35, new DateTime(2024, 9, 17, 10, 28, 0, 0, DateTimeKind.Unspecified), 188, 2, 1, 1500, false },
                    { 36, new DateTime(2024, 9, 18, 17, 7, 0, 0, DateTimeKind.Unspecified), 81, 1, 1, 3300, false },
                    { 37, new DateTime(2024, 9, 19, 12, 10, 0, 0, DateTimeKind.Unspecified), 171, 1, 1, 3900, true },
                    { 38, new DateTime(2024, 9, 20, 12, 18, 0, 0, DateTimeKind.Unspecified), 78, 1, 1, 4000, true },
                    { 39, new DateTime(2024, 9, 21, 12, 46, 0, 0, DateTimeKind.Unspecified), 104, 0, 1, 1800, false },
                    { 40, new DateTime(2024, 9, 22, 12, 59, 0, 0, DateTimeKind.Unspecified), 50, 0, 1, 3700, false },
                    { 41, new DateTime(2024, 9, 23, 11, 32, 0, 0, DateTimeKind.Unspecified), 192, 2, 1, 1600, false },
                    { 42, new DateTime(2024, 9, 24, 16, 54, 0, 0, DateTimeKind.Unspecified), 93, 0, 1, 3700, false },
                    { 43, new DateTime(2024, 9, 25, 17, 10, 0, 0, DateTimeKind.Unspecified), 117, 2, 1, 2200, false },
                    { 44, new DateTime(2024, 9, 26, 13, 22, 0, 0, DateTimeKind.Unspecified), 142, 2, 1, 2900, false },
                    { 45, new DateTime(2024, 9, 27, 17, 4, 0, 0, DateTimeKind.Unspecified), 41, 1, 1, 2600, true },
                    { 46, new DateTime(2024, 9, 28, 17, 2, 0, 0, DateTimeKind.Unspecified), 139, 2, 1, 3800, true },
                    { 47, new DateTime(2024, 9, 29, 11, 6, 0, 0, DateTimeKind.Unspecified), 217, 1, 1, 2200, true },
                    { 48, new DateTime(2024, 9, 30, 12, 2, 0, 0, DateTimeKind.Unspecified), 180, 1, 1, 3000, false },
                    { 49, new DateTime(2024, 10, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 2000, false },
                    { 50, new DateTime(2024, 10, 2, 10, 25, 0, 0, DateTimeKind.Unspecified), 50, 0, 1, 3800, false },
                    { 51, new DateTime(2024, 10, 3, 11, 20, 0, 0, DateTimeKind.Unspecified), 183, 0, 1, 3000, false },
                    { 52, new DateTime(2024, 10, 4, 17, 53, 0, 0, DateTimeKind.Unspecified), 201, 1, 1, 2100, false },
                    { 53, new DateTime(2024, 10, 5, 17, 49, 0, 0, DateTimeKind.Unspecified), 131, 2, 1, 3900, true },
                    { 54, new DateTime(2024, 10, 6, 10, 52, 0, 0, DateTimeKind.Unspecified), 194, 0, 1, 1100, true },
                    { 55, new DateTime(2024, 10, 7, 15, 19, 0, 0, DateTimeKind.Unspecified), 158, 2, 1, 1000, false },
                    { 56, new DateTime(2024, 10, 8, 16, 8, 0, 0, DateTimeKind.Unspecified), 56, 1, 1, 2600, true },
                    { 57, new DateTime(2024, 10, 9, 15, 6, 0, 0, DateTimeKind.Unspecified), 217, 2, 1, 2200, false },
                    { 58, new DateTime(2024, 10, 10, 12, 46, 0, 0, DateTimeKind.Unspecified), 155, 1, 1, 3900, false },
                    { 59, new DateTime(2024, 10, 11, 16, 5, 0, 0, DateTimeKind.Unspecified), 63, 0, 1, 3000, false },
                    { 60, new DateTime(2024, 10, 12, 16, 3, 0, 0, DateTimeKind.Unspecified), 225, 0, 1, 2800, true },
                    { 61, new DateTime(2024, 10, 13, 15, 37, 0, 0, DateTimeKind.Unspecified), 91, 2, 1, 1900, true },
                    { 62, new DateTime(2024, 10, 14, 11, 56, 0, 0, DateTimeKind.Unspecified), 49, 0, 1, 3100, false },
                    { 63, new DateTime(2024, 10, 15, 14, 9, 0, 0, DateTimeKind.Unspecified), 66, 1, 1, 3500, true },
                    { 64, new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 74, 1, 1, 1900, true },
                    { 65, new DateTime(2024, 10, 17, 10, 24, 0, 0, DateTimeKind.Unspecified), 43, 1, 1, 1700, true },
                    { 66, new DateTime(2024, 10, 18, 12, 29, 0, 0, DateTimeKind.Unspecified), 126, 2, 1, 1300, false },
                    { 67, new DateTime(2024, 10, 19, 15, 49, 0, 0, DateTimeKind.Unspecified), 85, 1, 1, 2700, true },
                    { 68, new DateTime(2024, 10, 20, 14, 50, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 3300, true },
                    { 69, new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 223, 2, 1, 3100, false },
                    { 70, new DateTime(2024, 10, 22, 11, 55, 0, 0, DateTimeKind.Unspecified), 111, 0, 1, 2200, false },
                    { 71, new DateTime(2024, 10, 23, 13, 40, 0, 0, DateTimeKind.Unspecified), 139, 0, 1, 1600, true },
                    { 72, new DateTime(2024, 10, 24, 16, 6, 0, 0, DateTimeKind.Unspecified), 203, 2, 1, 1600, false },
                    { 73, new DateTime(2024, 10, 25, 16, 12, 0, 0, DateTimeKind.Unspecified), 99, 0, 1, 3400, true },
                    { 74, new DateTime(2024, 10, 26, 15, 58, 0, 0, DateTimeKind.Unspecified), 213, 2, 1, 3500, false },
                    { 75, new DateTime(2024, 10, 27, 15, 57, 0, 0, DateTimeKind.Unspecified), 48, 1, 1, 2600, false },
                    { 76, new DateTime(2024, 10, 28, 15, 29, 0, 0, DateTimeKind.Unspecified), 128, 2, 1, 1500, false },
                    { 77, new DateTime(2024, 10, 29, 12, 51, 0, 0, DateTimeKind.Unspecified), 223, 2, 1, 3400, true },
                    { 78, new DateTime(2024, 10, 30, 15, 20, 0, 0, DateTimeKind.Unspecified), 186, 0, 1, 3200, false },
                    { 79, new DateTime(2024, 10, 31, 12, 4, 0, 0, DateTimeKind.Unspecified), 33, 2, 1, 1800, false },
                    { 80, new DateTime(2024, 11, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), 41, 2, 1, 2700, true },
                    { 81, new DateTime(2024, 11, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 231, 0, 1, 1800, true },
                    { 82, new DateTime(2024, 11, 3, 11, 49, 0, 0, DateTimeKind.Unspecified), 38, 1, 1, 4000, false },
                    { 83, new DateTime(2024, 11, 4, 15, 58, 0, 0, DateTimeKind.Unspecified), 139, 1, 1, 4000, true },
                    { 84, new DateTime(2024, 11, 5, 13, 59, 0, 0, DateTimeKind.Unspecified), 191, 2, 1, 3800, true },
                    { 85, new DateTime(2024, 11, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 162, 0, 1, 2900, true },
                    { 86, new DateTime(2024, 11, 7, 11, 18, 0, 0, DateTimeKind.Unspecified), 215, 1, 1, 2500, false },
                    { 87, new DateTime(2024, 11, 8, 16, 39, 0, 0, DateTimeKind.Unspecified), 37, 2, 1, 1100, false },
                    { 88, new DateTime(2024, 11, 9, 11, 6, 0, 0, DateTimeKind.Unspecified), 50, 1, 1, 1700, true },
                    { 89, new DateTime(2024, 11, 10, 16, 33, 0, 0, DateTimeKind.Unspecified), 49, 1, 1, 2600, false },
                    { 90, new DateTime(2024, 11, 11, 15, 11, 0, 0, DateTimeKind.Unspecified), 169, 1, 1, 2400, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameSessions_PlayerId",
                table: "GameSessions",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameSessions");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
