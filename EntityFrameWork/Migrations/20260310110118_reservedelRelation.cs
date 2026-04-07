using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class reservedelRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Biler",
                keyColumn: "BilId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Biler",
                columns: new[] { "BilId", "EjerId", "Name", "Weight" },
                values: new object[] { 1, 1, "Ford", 1400 });

            migrationBuilder.UpdateData(
                table: "Ejere",
                keyColumn: "EjerId",
                keyValue: 1,
                column: "ForNavn",
                value: "John");

            migrationBuilder.InsertData(
                table: "Reservedel",
                columns: new[] { "ReservedelId", "Mærke", "Name" },
                values: new object[,]
                {
                    { 1, "Bosch", "Bremser" },
                    { 2, "Mann", "Oliefilter" },
                    { 3, "NGK", "Tændrør" }
                });

            migrationBuilder.InsertData(
                table: "BilReservedel",
                columns: new[] { "BilerBilId", "ReservedeleReservedelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BilReservedel",
                keyColumns: new[] { "BilerBilId", "ReservedeleReservedelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BilReservedel",
                keyColumns: new[] { "BilerBilId", "ReservedeleReservedelId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Reservedel",
                keyColumn: "ReservedelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Biler",
                keyColumn: "BilId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservedel",
                keyColumn: "ReservedelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservedel",
                keyColumn: "ReservedelId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Biler",
                columns: new[] { "BilId", "EjerId", "Name", "Weight" },
                values: new object[] { -1, 1, "Ford", 1400 });

            migrationBuilder.UpdateData(
                table: "Ejere",
                keyColumn: "EjerId",
                keyValue: 1,
                column: "ForNavn",
                value: "Katrine");
        }
    }
}
