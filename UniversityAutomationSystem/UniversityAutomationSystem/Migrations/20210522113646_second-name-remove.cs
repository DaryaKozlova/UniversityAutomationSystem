using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityAutomationSystem.Migrations
{
    public partial class secondnameremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
