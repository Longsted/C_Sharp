using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class AddReservedel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_biler",
                table: "biler");

            migrationBuilder.DropColumn(
                name: "Ejer",
                table: "biler");

            migrationBuilder.RenameTable(
                name: "biler",
                newName: "Biler");

            migrationBuilder.AddColumn<int>(
                name: "EjerId",
                table: "Biler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biler",
                table: "Biler",
                column: "BilId");

            migrationBuilder.CreateTable(
                name: "Ejere",
                columns: table => new
                {
                    EjerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForNavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejere", x => x.EjerId);
                });

            migrationBuilder.CreateTable(
                name: "Reservedel",
                columns: table => new
                {
                    ReservedelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mærke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservedel", x => x.ReservedelId);
                });

            migrationBuilder.CreateTable(
                name: "BilReservedel",
                columns: table => new
                {
                    BilerBilId = table.Column<int>(type: "int", nullable: false),
                    ReservedeleReservedelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilReservedel", x => new { x.BilerBilId, x.ReservedeleReservedelId });
                    table.ForeignKey(
                        name: "FK_BilReservedel_Biler_BilerBilId",
                        column: x => x.BilerBilId,
                        principalTable: "Biler",
                        principalColumn: "BilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BilReservedel_Reservedel_ReservedeleReservedelId",
                        column: x => x.ReservedeleReservedelId,
                        principalTable: "Reservedel",
                        principalColumn: "ReservedelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Biler",
                keyColumn: "BilId",
                keyValue: -1,
                column: "EjerId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Ejere",
                columns: new[] { "EjerId", "ForNavn", "SurName" },
                values: new object[] { 1, "Katrine", "H" });

            migrationBuilder.CreateIndex(
                name: "IX_Biler_EjerId",
                table: "Biler",
                column: "EjerId");

            migrationBuilder.CreateIndex(
                name: "IX_BilReservedel_ReservedeleReservedelId",
                table: "BilReservedel",
                column: "ReservedeleReservedelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biler_Ejere_EjerId",
                table: "Biler",
                column: "EjerId",
                principalTable: "Ejere",
                principalColumn: "EjerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biler_Ejere_EjerId",
                table: "Biler");

            migrationBuilder.DropTable(
                name: "BilReservedel");

            migrationBuilder.DropTable(
                name: "Ejere");

            migrationBuilder.DropTable(
                name: "Reservedel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biler",
                table: "Biler");

            migrationBuilder.DropIndex(
                name: "IX_Biler_EjerId",
                table: "Biler");

            migrationBuilder.DropColumn(
                name: "EjerId",
                table: "Biler");

            migrationBuilder.RenameTable(
                name: "Biler",
                newName: "biler");

            migrationBuilder.AddColumn<string>(
                name: "Ejer",
                table: "biler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_biler",
                table: "biler",
                column: "BilId");

            migrationBuilder.UpdateData(
                table: "biler",
                keyColumn: "BilId",
                keyValue: -1,
                column: "Ejer",
                value: "Katrine");
        }
    }
}
