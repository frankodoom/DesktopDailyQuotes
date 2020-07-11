using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyQuotes.Migrations
{
    public partial class quote_positions_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingKey = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastPositionX = table.Column<int>(nullable: false),
                    LastPositionY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
