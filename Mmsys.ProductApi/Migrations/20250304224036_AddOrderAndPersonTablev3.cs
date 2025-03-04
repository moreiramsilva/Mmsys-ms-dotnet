using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmsys.ProductManagementApi.Migrations
{
    public partial class AddOrderAndPersonTablev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_order_OrderId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_OrderId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "product",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_OrderId",
                table: "product",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_order_OrderId",
                table: "product",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "Id");
        }
    }
}
