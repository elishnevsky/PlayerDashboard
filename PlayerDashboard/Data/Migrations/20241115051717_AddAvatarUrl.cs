using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerDashboard.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAvatarUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Players",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 15, 17, 25, 0, 0, DateTimeKind.Unspecified), 44, 4000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 16, 13, 1, 0, 0, DateTimeKind.Unspecified), 147, 2700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 170, 0, 2600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), 137, 1900, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 29, 0, 0, DateTimeKind.Unspecified), 113, 2, 3400 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 42, 0, 0, DateTimeKind.Unspecified), 150, 4000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 5, 0, 0, DateTimeKind.Unspecified), 74, 2700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 25, 0, 0, DateTimeKind.Unspecified), 80, 2, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 23, 13, 33, 0, 0, DateTimeKind.Unspecified), 93, 2700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 24, 17, 18, 0, 0, DateTimeKind.Unspecified), 37, 2600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 25, 17, 51, 0, 0, DateTimeKind.Unspecified), 76, 1600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 36, 0, 0, DateTimeKind.Unspecified), 37, 2, 1300, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 27, 14, 19, 0, 0, DateTimeKind.Unspecified), 64, 1, 1600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Duration", "GameMode", "Won" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 16, 0, 0, DateTimeKind.Unspecified), 216, 1, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 4, 0, 0, DateTimeKind.Unspecified), 212, 3200 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 39, 0, 0, DateTimeKind.Unspecified), 122, 0, 3700, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 10, 0, 0, DateTimeKind.Unspecified), 217, 1, 3100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 57, 0, 0, DateTimeKind.Unspecified), 68, 1, 2400 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 49, 4000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 24, 0, 0, DateTimeKind.Unspecified), 60, 1700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 3, 0, 0, DateTimeKind.Unspecified), 76, 1, 2900, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 43, 0, 0, DateTimeKind.Unspecified), 166, 2, 1300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 6, 13, 51, 0, 0, DateTimeKind.Unspecified), 169, 0, 3300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 7, 10, 18, 0, 0, DateTimeKind.Unspecified), 44, 2, 1100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 8, 13, 35, 0, 0, DateTimeKind.Unspecified), 82, 2, 3800, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 9, 13, 39, 0, 0, DateTimeKind.Unspecified), 31, 2300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 35, 0, 0, DateTimeKind.Unspecified), 223, 3900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 11, 11, 51, 0, 0, DateTimeKind.Unspecified), 153, 0, 1400, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 23, 0, 0, DateTimeKind.Unspecified), 60, 2, 2100, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 13, 12, 33, 0, 0, DateTimeKind.Unspecified), 54, 1300, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 14, 10, 47, 0, 0, DateTimeKind.Unspecified), 120, 1600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 15, 10, 42, 0, 0, DateTimeKind.Unspecified), 191, 2, 3200 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), 70, 0, 3500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 1, 0, 0, DateTimeKind.Unspecified), 69, 1700, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 18, 14, 53, 0, 0, DateTimeKind.Unspecified), 215, 2200, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 24, 0, 0, DateTimeKind.Unspecified), 99, 0, 3500, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 20, 10, 57, 0, 0, DateTimeKind.Unspecified), 79, 0, 3000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 21, 11, 35, 0, 0, DateTimeKind.Unspecified), 173, 0, 1300, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 22, 10, 26, 0, 0, DateTimeKind.Unspecified), 183, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 176, 1, 2300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 18, 0, 0, DateTimeKind.Unspecified), 131, 1, 3100, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 25, 12, 51, 0, 0, DateTimeKind.Unspecified), 101, 1, 3600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 26, 12, 30, 0, 0, DateTimeKind.Unspecified), 90, 1900, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 27, 13, 21, 0, 0, DateTimeKind.Unspecified), 181, 0, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 28, 14, 47, 0, 0, DateTimeKind.Unspecified), 46, 2, 1300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 29, 17, 17, 0, 0, DateTimeKind.Unspecified), 187, 1, 1500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 30, 11, 57, 0, 0, DateTimeKind.Unspecified), 216, 0, 1400, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 144, 2, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 20, 0, 0, DateTimeKind.Unspecified), 187, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Duration" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 29, 0, 0, DateTimeKind.Unspecified), 111 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 4, 12, 47, 0, 0, DateTimeKind.Unspecified), 93, 2, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 5, 17, 32, 0, 0, DateTimeKind.Unspecified), 166, 3400 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 37, 0, 0, DateTimeKind.Unspecified), 49, 0, 1100, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 7, 17, 57, 0, 0, DateTimeKind.Unspecified), 99, 1, 3900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 8, 12, 22, 0, 0, DateTimeKind.Unspecified), 152, 2500, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 33, 0, 0, DateTimeKind.Unspecified), 33, 0, 3100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 1, 0, 0, DateTimeKind.Unspecified), 103, 1, 1100, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 11, 10, 33, 0, 0, DateTimeKind.Unspecified), 191, 0, 3700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 22, 0, 0, DateTimeKind.Unspecified), 93, 1, 1000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 54, 0, 0, DateTimeKind.Unspecified), 183, 1500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 14, 12, 58, 0, 0, DateTimeKind.Unspecified), 168, 1, 3500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 13, 0, 0, DateTimeKind.Unspecified), 56, 2800, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 16, 14, 36, 0, 0, DateTimeKind.Unspecified), 57, 0, 3300, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 17, 16, 16, 0, 0, DateTimeKind.Unspecified), 103, 2, 1600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 18, 10, 54, 0, 0, DateTimeKind.Unspecified), 54, 2, 2700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 19, 10, 12, 0, 0, DateTimeKind.Unspecified), 142, 0, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 20, 10, 13, 0, 0, DateTimeKind.Unspecified), 125, 1300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Duration", "GameMode", "Won" },
                values: new object[] { new DateTime(2024, 10, 21, 11, 10, 0, 0, DateTimeKind.Unspecified), 71, 2, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 47, 0, 0, DateTimeKind.Unspecified), 89, 1, 3500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 33, 0, 0, DateTimeKind.Unspecified), 76, 1400, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 23, 0, 0, DateTimeKind.Unspecified), 49, 2, 3000, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 25, 14, 3, 0, 0, DateTimeKind.Unspecified), 205, 1, 2200 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 26, 13, 33, 0, 0, DateTimeKind.Unspecified), 139, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 27, 14, 2, 0, 0, DateTimeKind.Unspecified), 45, 0, 3600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 28, 11, 46, 0, 0, DateTimeKind.Unspecified), 228, 2, 3100, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 49, 0, 0, DateTimeKind.Unspecified), 55, 1, 2700, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 34, 0, 0, DateTimeKind.Unspecified), 98, 0, 2200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 55, 0, 0, DateTimeKind.Unspecified), 112, 1, 1500, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 145, 2000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 51, 0, 0, DateTimeKind.Unspecified), 129, 0, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 3, 11, 7, 0, 0, DateTimeKind.Unspecified), 40, 2, 2100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 11, 4, 13, 28, 0, 0, DateTimeKind.Unspecified), 113, 1500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), 70, 2600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 6, 11, 50, 0, 0, DateTimeKind.Unspecified), 86, 1, 2800, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 7, 10, 35, 0, 0, DateTimeKind.Unspecified), 178, 2, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 56, 0, 0, DateTimeKind.Unspecified), 115, 2, 2600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 9, 13, 18, 0, 0, DateTimeKind.Unspecified), 86, 1, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 10, 14, 58, 0, 0, DateTimeKind.Unspecified), 89, 2, 1500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 39, 0, 0, DateTimeKind.Unspecified), 70, 2, 2300, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 12, 10, 46, 0, 0, DateTimeKind.Unspecified), 82, 2, 3000, false });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountCreatedDate", "AvatarUrl", "AverageGameTimeMinutes", "TotalPlaytimeMinutes", "TotalWins" },
                values: new object[] { new DateOnly(2024, 8, 15), "https://cdn.jsdelivr.net/gh/alohe/memojis/png/upstream_17.png", 113, 10230, 47 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 54, 0, 0, DateTimeKind.Unspecified), 239, 3600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 49, 0, 0, DateTimeKind.Unspecified), 82, 1600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 118, 1, 2900, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 26, 0, 0, DateTimeKind.Unspecified), 119, 2200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 18, 17, 45, 0, 0, DateTimeKind.Unspecified), 53, 0, 4000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 19, 15, 7, 0, 0, DateTimeKind.Unspecified), 59, 3700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 46, 0, 0, DateTimeKind.Unspecified), 134, 2200, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 8, 0, 0, DateTimeKind.Unspecified), 198, 0, 1200 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 31, 0, 0, DateTimeKind.Unspecified), 51, 1900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 5, 0, 0, DateTimeKind.Unspecified), 147, 3700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 24, 10, 20, 0, 0, DateTimeKind.Unspecified), 50, 2800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 4, 0, 0, DateTimeKind.Unspecified), 119, 1, 3100, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 29, 0, 0, DateTimeKind.Unspecified), 71, 2, 3000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Duration", "GameMode", "Won" },
                values: new object[] { new DateTime(2024, 8, 27, 17, 25, 0, 0, DateTimeKind.Unspecified), 92, 0, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 8, 28, 17, 49, 0, 0, DateTimeKind.Unspecified), 93, 1100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 2, 0, 0, DateTimeKind.Unspecified), 128, 1, 1300, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 42, 0, 0, DateTimeKind.Unspecified), 203, 0, 1600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 48, 0, 0, DateTimeKind.Unspecified), 239, 2, 3500 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 1, 12, 48, 0, 0, DateTimeKind.Unspecified), 160, 2500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 107, 2100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 28, 0, 0, DateTimeKind.Unspecified), 225, 2, 3600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 33, 0, 0, DateTimeKind.Unspecified), 229, 0, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 46, 0, 0, DateTimeKind.Unspecified), 52, 1, 3600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 6, 12, 25, 0, 0, DateTimeKind.Unspecified), 38, 0, 2400 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 70, 0, 3100, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 8, 11, 53, 0, 0, DateTimeKind.Unspecified), 188, 1000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 34, 0, 0, DateTimeKind.Unspecified), 58, 4000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 10, 11, 11, 0, 0, DateTimeKind.Unspecified), 160, 1, 2400, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 5, 0, 0, DateTimeKind.Unspecified), 162, 1, 3200, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 12, 14, 4, 0, 0, DateTimeKind.Unspecified), 50, 1100, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 13, 0, 0, DateTimeKind.Unspecified), 122, 1000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 14, 14, 52, 0, 0, DateTimeKind.Unspecified), 219, 1, 1900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 7, 0, 0, DateTimeKind.Unspecified), 231, 2, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 43, 0, 0, DateTimeKind.Unspecified), 130, 3700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 28, 0, 0, DateTimeKind.Unspecified), 188, 1500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 18, 17, 7, 0, 0, DateTimeKind.Unspecified), 81, 1, 3300, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 10, 0, 0, DateTimeKind.Unspecified), 171, 1, 3900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 20, 12, 18, 0, 0, DateTimeKind.Unspecified), 78, 1, 4000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 46, 0, 0, DateTimeKind.Unspecified), 104, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 22, 12, 59, 0, 0, DateTimeKind.Unspecified), 50, 0, 3700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 32, 0, 0, DateTimeKind.Unspecified), 192, 2, 1600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 54, 0, 0, DateTimeKind.Unspecified), 93, 0, 3700, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 10, 0, 0, DateTimeKind.Unspecified), 117, 2200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 26, 13, 22, 0, 0, DateTimeKind.Unspecified), 142, 2, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 27, 17, 4, 0, 0, DateTimeKind.Unspecified), 41, 1, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 28, 17, 2, 0, 0, DateTimeKind.Unspecified), 139, 2, 3800, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 9, 29, 11, 6, 0, 0, DateTimeKind.Unspecified), 217, 1, 2200, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 2, 0, 0, DateTimeKind.Unspecified), 180, 1, 3000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 39, 2000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "Duration" },
                values: new object[] { new DateTime(2024, 10, 2, 10, 25, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 3, 11, 20, 0, 0, DateTimeKind.Unspecified), 183, 0, 3000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 53, 0, 0, DateTimeKind.Unspecified), 201, 2100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 5, 17, 49, 0, 0, DateTimeKind.Unspecified), 131, 2, 3900, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 6, 10, 52, 0, 0, DateTimeKind.Unspecified), 194, 0, 1100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 19, 0, 0, DateTimeKind.Unspecified), 158, 1000, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 8, 0, 0, DateTimeKind.Unspecified), 56, 1, 2600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 6, 0, 0, DateTimeKind.Unspecified), 217, 2, 2200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 46, 0, 0, DateTimeKind.Unspecified), 155, 1, 3900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 5, 0, 0, DateTimeKind.Unspecified), 63, 0, 3000, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 3, 0, 0, DateTimeKind.Unspecified), 225, 2800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 37, 0, 0, DateTimeKind.Unspecified), 91, 2, 1900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 14, 11, 56, 0, 0, DateTimeKind.Unspecified), 49, 3100, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 9, 0, 0, DateTimeKind.Unspecified), 66, 1, 3500, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 74, 1, 1900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 17, 10, 24, 0, 0, DateTimeKind.Unspecified), 43, 1, 1700, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 18, 12, 29, 0, 0, DateTimeKind.Unspecified), 126, 2, 1300 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 49, 0, 0, DateTimeKind.Unspecified), 85, 2700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "Duration", "GameMode", "Won" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 50, 0, 0, DateTimeKind.Unspecified), 39, 1, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 223, 2, 3100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 22, 11, 55, 0, 0, DateTimeKind.Unspecified), 111, 2200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 40, 0, 0, DateTimeKind.Unspecified), 139, 0, 1600, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 6, 0, 0, DateTimeKind.Unspecified), 203, 2, 1600 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 12, 0, 0, DateTimeKind.Unspecified), 99, 3400 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 26, 15, 58, 0, 0, DateTimeKind.Unspecified), 213, 2, 3500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 27, 15, 57, 0, 0, DateTimeKind.Unspecified), 48, 1, 2600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 29, 0, 0, DateTimeKind.Unspecified), 128, 2, 1500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 29, 12, 51, 0, 0, DateTimeKind.Unspecified), 223, 2, 3400, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 30, 15, 20, 0, 0, DateTimeKind.Unspecified), 186, 0, 3200, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 10, 31, 12, 4, 0, 0, DateTimeKind.Unspecified), 33, 1800, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), 41, 2, 2700 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 231, 0, 1800 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "Duration", "Score" },
                values: new object[] { new DateTime(2024, 11, 3, 11, 49, 0, 0, DateTimeKind.Unspecified), 38, 4000 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "Duration", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 58, 0, 0, DateTimeKind.Unspecified), 139, 4000, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 5, 13, 59, 0, 0, DateTimeKind.Unspecified), 191, 2, 3800, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 162, 0, 2900 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 7, 11, 18, 0, 0, DateTimeKind.Unspecified), 215, 1, 2500, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "Duration", "GameMode", "Score" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 39, 0, 0, DateTimeKind.Unspecified), 37, 2, 1100 });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 9, 11, 6, 0, 0, DateTimeKind.Unspecified), 50, 1, 1700, true });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 33, 0, 0, DateTimeKind.Unspecified), 49, 1, 2600, false });

            migrationBuilder.UpdateData(
                table: "GameSessions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "Duration", "GameMode", "Score", "Won" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 11, 0, 0, DateTimeKind.Unspecified), 169, 1, 2400, true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountCreatedDate", "AverageGameTimeMinutes", "TotalPlaytimeMinutes", "TotalWins" },
                values: new object[] { new DateOnly(2024, 8, 14), 126, 11362, 39 });
        }
    }
}
