using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceReqApp.DataAccess.Migrations
{
    public partial class FixCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerName",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerName",
                table: "Customers");
        }
    }
}
