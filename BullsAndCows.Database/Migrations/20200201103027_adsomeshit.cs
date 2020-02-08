using Microsoft.EntityFrameworkCore.Migrations;

namespace BullsAndCows.Database.Migrations
{
    public partial class adsomeshit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attempts = table.Column<int>(nullable: false),
                    CorrectNumber = table.Column<int>(nullable: false),
                    LatestEnteredNumber = table.Column<int>(nullable: false),
                    Cows = table.Column<int>(nullable: false),
                    Bulls = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
