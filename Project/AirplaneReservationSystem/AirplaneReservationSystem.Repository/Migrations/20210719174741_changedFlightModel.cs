using Microsoft.EntityFrameworkCore.Migrations;

namespace AirplaneReservationSystem.Repository.Migrations
{
    public partial class changedFlightModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxSeats",
                table: "Flights",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxSeats",
                table: "Flights");
        }
    }
}
