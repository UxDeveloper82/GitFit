using Microsoft.EntityFrameworkCore.Migrations;

namespace mysite.Migrations
{
    public partial class AddedLanguageToPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Portfolios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Portfolios");
        }
    }
}
