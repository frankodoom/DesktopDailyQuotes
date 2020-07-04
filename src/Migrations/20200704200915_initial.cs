using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyQuotes.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    count = table.Column<int>(nullable: false),
                    totalCount = table.Column<int>(nullable: false),
                    lastItemIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    _id = table.Column<string>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    author = table.Column<string>(nullable: true),
                    length = table.Column<int>(nullable: false),
                    QuoteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x._id);
                    table.ForeignKey(
                        name: "FK_Result_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Result_QuoteId",
                table: "Result",
                column: "QuoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
