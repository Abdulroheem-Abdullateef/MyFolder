using Microsoft.EntityFrameworkCore.Migrations;

namespace KpiNew.Migrations
{
    public partial class ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "KpiRating",
                table: "EmployeeKpis",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "EmployeeKpis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "EmployeeKpis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KpiRating",
                table: "EmployeeKpis");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "EmployeeKpis");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "EmployeeKpis");
        }
    }
}
