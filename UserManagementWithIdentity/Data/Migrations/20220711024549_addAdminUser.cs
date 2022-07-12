using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'78a9c66d-d501-4f87-9d50-ec06e862a00b', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGdv1tBCVyXCw0qzAX+iLz6Y8rOnr+mkcZWqnQy8Tjb7kC9+AFaYtTL9woGLkeVC3w==', N'OBVTP2LSYOCYI4U2OHB4YHFF3FF23P24', N'8097bccc-8e38-40aa-b3cd-9a584d8399ec', NULL, 0, 0, NULL, 1, 0, N'Admin', N'admin', null)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '68b5c620-134e-4ccd-b98b-988710f0518e'");
        }
    }
}
