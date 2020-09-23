using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class FixSpellingInCommandModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platfrom",
                table: "Commands");

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Commands",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Commands");

            migrationBuilder.AddColumn<string>(
                name: "Platfrom",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
