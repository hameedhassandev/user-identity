using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class changeLabSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Laptops",
                table: "Laptops");

            migrationBuilder.RenameTable(
                name: "Laptops",
                newName: "Labtops",
                newSchema: "security");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Labtops",
                schema: "security",
                table: "Labtops",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Labtops",
                schema: "security",
                table: "Labtops");

            migrationBuilder.RenameTable(
                name: "Labtops",
                schema: "security",
                newName: "Laptops");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laptops",
                table: "Laptops",
                column: "Id");
        }
    }
}
