using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceReqApp.DataAccess.Migrations
{
    public partial class EmployeeRepairs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");
        }
    }
}
