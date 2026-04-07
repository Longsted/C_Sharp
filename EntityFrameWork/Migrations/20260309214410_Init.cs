using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "biler",
                columns: table => new
                {
                    BilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Ejer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_biler", x => x.BilId);
                });

            migrationBuilder.InsertData(
                table: "biler",
                columns: new[] { "BilId", "Ejer", "Name", "Weight" },
                values: new object[] { -1, "Katrine", "Ford", 1400 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "biler");
        }
    }
}
