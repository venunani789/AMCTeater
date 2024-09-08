using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SevenBridgeAMCProj.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SevenBridges",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Showtime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SevenBridges", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "SevenBridges",
                columns: new[] { "MovieId", "Format", "Name", "Price", "Showtime" },
                values: new object[,]
                {
                    { 1, "Standard", "Casablanca", 10, "16:25" },
                    { 2, "IMAX", "Wonder Woman", 9, "15:00" },
                    { 3, "Standard", "Moonstruck", 7, "13:00" },
                    { 4, "IMAX", "Oppenheimer", 10, "13:10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SevenBridges");
        }
    }
}
