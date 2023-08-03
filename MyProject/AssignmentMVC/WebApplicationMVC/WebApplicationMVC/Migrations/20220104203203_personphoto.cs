using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMVC.Migrations
{
    public partial class personphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonPhoto",
                table: "Persons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryPhoto",
                table: "Countries",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonPhoto",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CountryPhoto",
                table: "Countries");
        }
    }
}
