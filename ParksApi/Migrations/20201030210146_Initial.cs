using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NationalParkName = table.Column<string>(nullable: true),
                    NationalParkLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateParkName = table.Column<string>(nullable: true),
                    StateParkDescription = table.Column<string>(nullable: true),
                    StateParkLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(nullable: true),
                    StateDescription = table.Column<string>(nullable: true),
                    StateParkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_States_StateParks_StateParkId",
                        column: x => x.StateParkId,
                        principalTable: "StateParks",
                        principalColumn: "StateParkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StateJoins",
                columns: table => new
                {
                    StateJoinId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateParkId = table.Column<int>(nullable: true),
                    NationalParkId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateJoins", x => x.StateJoinId);
                    table.ForeignKey(
                        name: "FK_StateJoins_NationalParks_NationalParkId",
                        column: x => x.NationalParkId,
                        principalTable: "NationalParks",
                        principalColumn: "NationalParkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateJoins_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateJoins_StateParks_StateParkId",
                        column: x => x.StateParkId,
                        principalTable: "StateParks",
                        principalColumn: "StateParkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateJoins_NationalParkId",
                table: "StateJoins",
                column: "NationalParkId");

            migrationBuilder.CreateIndex(
                name: "IX_StateJoins_StateId",
                table: "StateJoins",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_StateJoins_StateParkId",
                table: "StateJoins",
                column: "StateParkId");

            migrationBuilder.CreateIndex(
                name: "IX_States_StateParkId",
                table: "States",
                column: "StateParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateJoins");

            migrationBuilder.DropTable(
                name: "NationalParks");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "StateParks");
        }
    }
}
