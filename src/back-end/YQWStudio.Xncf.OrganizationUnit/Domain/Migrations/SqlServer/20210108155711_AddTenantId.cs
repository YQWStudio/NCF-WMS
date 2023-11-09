using Microsoft.EntityFrameworkCore.Migrations;

namespace YQWStudio.Xncf.OrganizationUnit.Migrations.Migrations.SqlServer
{
    public partial class AddTenantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "YQWStudio_OrganizationUnit_Color",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "YQWStudio_OrganizationUnit_Color");
        }
    }
}
