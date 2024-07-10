using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdminUserToAllRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into [security].[UserRoles] (UserId, RoleId) Select '726a0417-7235-4353-ab6e-a9d1febf7e3d',Id From [security].[Roles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [security].[UserRoles] Where UserId = '726a0417-7235-4353-ab6e-a9d1febf7e3d'");
        }
    }
}
