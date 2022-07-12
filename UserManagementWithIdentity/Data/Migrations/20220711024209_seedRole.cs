using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class seedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "User", "user".ToUpper(), Guid.NewGuid().ToString() },
                schema: "security"
            );
            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[] { Guid.NewGuid().ToString(), "Admin", "admin".ToUpper(), Guid.NewGuid().ToString() },
               schema: "security"
           );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Roles]");
        }
    }
}

