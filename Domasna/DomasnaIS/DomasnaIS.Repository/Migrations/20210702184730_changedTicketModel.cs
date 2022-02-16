using Microsoft.EntityFrameworkCore.Migrations;

namespace DomasnaIS.Repository.Migrations
{
    public partial class changedTicketModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoviePosterURL",
                table: "Tickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoviePosterURL",
                table: "Tickets");
        }
    }
}
