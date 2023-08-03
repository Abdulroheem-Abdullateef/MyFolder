using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMVC.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countries_CountryId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CountryId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Countries_CountryId",
                table: "Persons",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
