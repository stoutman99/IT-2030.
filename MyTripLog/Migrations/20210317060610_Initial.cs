using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTripLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Accomodations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Todo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodations", "Destination", "End", "Start", "Todo" },
                values: new object[] { 1, "Pool", "Forida", 0, 0, "Nothing" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodations", "Destination", "End", "Start", "Todo" },
                values: new object[] { 2, "Pool", "California", 0, 0, "Nothing" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodations", "Destination", "End", "Start", "Todo" },
                values: new object[] { 3, "Amusement Park", "Michigan", 0, 0, "Go to park" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
