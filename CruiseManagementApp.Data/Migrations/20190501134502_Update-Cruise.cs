using Microsoft.EntityFrameworkCore.Migrations;

namespace CruiseManagementApp.Data.Migrations
{
    public partial class UpdateCruise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PortOfDeparture",
                table: "Cruises",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PortOfDeparture",
                table: "Cruises",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
