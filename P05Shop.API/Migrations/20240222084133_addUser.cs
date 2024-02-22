using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 6, 15, 1, 33, 451, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2024, 1, 16, 11, 40, 7, 87, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 7, 6, 33, 50, 360, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 6, 18, 47, 20, 719, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 8, 20, 5, 32, 449, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 21, 7, 53, 5, 558, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 22, 7, 5, 17, 968, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 14, 22, 19, 45, 657, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 5, 14, 19, 1, 113, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2024, 1, 26, 6, 1, 10, 575, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 24, 23, 15, 14, 716, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 3, 3, 47, 11, 490, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 2, 9, 0, 40, 410, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 28, 22, 13, 18, 897, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 17, 15, 19, 11, 927, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 7, 14, 0, 394, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 14, 21, 35, 31, 972, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 11, 23, 18, 13, 331, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 10, 36, 12, 911, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 29, 12, 6, 57, 393, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 6, 23, 29, 51, 581, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 19, 18, 57, 13, 851, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 18, 12, 47, 21, 169, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 20, 5, 23, 40, 399, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 5, 6, 52, 31, 962, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 31, 0, 28, 52, 86, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 22, 12, 32, 28, 82, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 14, 14, 58, 23, 194, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 7, 1, 29, 17, 187, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 4, 2, 24, 40, 403, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2024, 1, 28, 0, 50, 29, 600, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 7, 20, 37, 55, 539, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 15, 21, 6, 56, 789, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 14, 14, 22, 44, 628, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 1, 19, 15, 2, 623, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 21, 13, 49, 0, 156, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 18, 5, 22, 13, 552, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 29, 3, 23, 53, 871, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 24, 11, 2, 8, 431, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 11, 7, 48, 25, 55, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 23, 14, 53, 47, 203, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 15, 2, 4, 46, 632, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 9, 17, 51, 0, 188, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 13, 15, 31, 25, 347, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 21, 11, 37, 48, 417, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 24, 16, 19, 59, 976, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 29, 11, 19, 34, 279, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 11, 8, 11, 51, 705, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 25, 12, 53, 55, 307, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 12, 2, 2, 54, 486, DateTimeKind.Local).AddTicks(9944));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 18, 15, 49, 5, 490, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 28, 12, 27, 39, 126, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 19, 7, 21, 22, 399, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 18, 19, 34, 52, 759, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 20, 20, 53, 4, 488, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 11, 2, 8, 40, 37, 598, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 3, 7, 52, 50, 8, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 26, 23, 7, 17, 696, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 15, 15, 6, 33, 153, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 8, 6, 48, 42, 614, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 7, 0, 2, 46, 756, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 15, 4, 34, 43, 530, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 14, 9, 48, 12, 449, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 10, 23, 0, 50, 937, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 29, 16, 6, 43, 967, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 17, 8, 1, 32, 434, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 26, 22, 23, 4, 12, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 24, 0, 5, 45, 371, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 17, 11, 23, 44, 950, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 10, 12, 54, 29, 433, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 19, 0, 17, 23, 621, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 31, 19, 44, 45, 891, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 31, 13, 34, 53, 209, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 1, 6, 11, 12, 438, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 17, 7, 40, 4, 2, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 13, 1, 16, 24, 125, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 3, 13, 20, 0, 122, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 26, 15, 45, 55, 233, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 19, 2, 16, 49, 226, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 14, 3, 12, 12, 442, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 10, 1, 38, 1, 639, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 19, 21, 25, 27, 578, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 27, 21, 54, 28, 829, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 24, 15, 10, 16, 668, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 11, 20, 2, 34, 663, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 3, 14, 36, 32, 196, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 30, 6, 9, 45, 592, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 11, 4, 11, 25, 911, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 5, 11, 49, 40, 470, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 23, 8, 35, 57, 94, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 5, 15, 41, 19, 242, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 27, 2, 52, 18, 672, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 21, 18, 38, 32, 228, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 25, 16, 18, 57, 386, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 3, 12, 25, 20, 456, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 6, 17, 7, 32, 16, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 11, 12, 7, 6, 318, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 23, 8, 59, 23, 744, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 6, 13, 41, 27, 346, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 24, 2, 50, 26, 526, DateTimeKind.Local).AddTicks(4157));
        }
    }
}
