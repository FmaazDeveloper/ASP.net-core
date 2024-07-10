using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'726a0417-7235-4353-ab6e-a9d1febf7e3d', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEKo/niCgzm3Z2LypM5tTIeCnuSgHI4z8Mvn48rNx1XQ5oZkVy//fx4l7JbeVQcfhbw==', N'ODH2ILZPIDEYYGE6SBH5DDBBJYZYPZDH', N'd15a1ea5-eb1c-49a6-855e-0121faa00cfa', NULL, 0, 0, NULL, 1, 0, N'Mohammad', N'updated', null)\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '726a0417-7235-4353-ab6e-a9d1febf7e3d'");
        }
    }
}
