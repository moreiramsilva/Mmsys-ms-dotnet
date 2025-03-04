using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmsys.ProductManagementApi.Migrations
{
    public partial class AddOrderAndPersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "product",
                newName: "company_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "product",
                newName: "companyId");
        }
    }
}
