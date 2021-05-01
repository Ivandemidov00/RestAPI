using Microsoft.EntityFrameworkCore.Migrations;

namespace storeRestAPI.Migrations
{
    public partial class secondFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_productId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_userId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "orders",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "orders",
                newName: "productid");

            migrationBuilder.RenameIndex(
                name: "IX_orders_userId",
                table: "orders",
                newName: "IX_orders_userid");

            migrationBuilder.RenameIndex(
                name: "IX_orders_productId",
                table: "orders",
                newName: "IX_orders_productid");

            migrationBuilder.AlterColumn<short>(
                name: "userid",
                table: "orders",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "productid",
                table: "orders",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_productid",
                table: "orders",
                column: "productid",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_userid",
                table: "orders",
                column: "userid",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_productid",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_userid",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "orders",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "orders",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_userid",
                table: "orders",
                newName: "IX_orders_userId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_productid",
                table: "orders",
                newName: "IX_orders_productId");

            migrationBuilder.AlterColumn<short>(
                name: "userId",
                table: "orders",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "productId",
                table: "orders",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<short>(
                name: "IdProduct",
                table: "orders",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IdUser",
                table: "orders",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_productId",
                table: "orders",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_userId",
                table: "orders",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
