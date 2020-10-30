using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class NationalParkFix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalParkDescription",
                table: "NationalParks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalParkDescription",
                table: "NationalParks");
        }
    }
}
