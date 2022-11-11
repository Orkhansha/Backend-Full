using Microsoft.EntityFrameworkCore.Migrations;

namespace Front_to_back.Migrations
{
    public partial class EditProductNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OurProducts_Categories_CategoryId",
                table: "OurProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_OurProducts_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OurProducts",
                table: "OurProducts");

            migrationBuilder.RenameTable(
                name: "OurProducts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_OurProducts_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "OurProducts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "OurProducts",
                newName: "IX_OurProducts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OurProducts",
                table: "OurProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OurProducts_Categories_CategoryId",
                table: "OurProducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_OurProducts_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "OurProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
