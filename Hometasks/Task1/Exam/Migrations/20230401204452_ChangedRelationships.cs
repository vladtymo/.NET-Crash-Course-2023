using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupermarketGoods");

            migrationBuilder.DropTable(
                name: "SupermarketProducts");

            migrationBuilder.AddColumn<long>(
                name: "SupermarketFK",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SupermarketFK",
                table: "Goods",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupermarketFK",
                table: "Products",
                column: "SupermarketFK");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_SupermarketFK",
                table: "Goods",
                column: "SupermarketFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Supermarkets_SupermarketFK",
                table: "Goods",
                column: "SupermarketFK",
                principalTable: "Supermarkets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supermarkets_SupermarketFK",
                table: "Products",
                column: "SupermarketFK",
                principalTable: "Supermarkets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Supermarkets_SupermarketFK",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supermarkets_SupermarketFK",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupermarketFK",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Goods_SupermarketFK",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "SupermarketFK",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupermarketFK",
                table: "Goods");

            migrationBuilder.CreateTable(
                name: "SupermarketGoods",
                columns: table => new
                {
                    SupermarketFK = table.Column<long>(type: "bigint", nullable: false),
                    GoodsFK = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupermarketGoods", x => new { x.SupermarketFK, x.GoodsFK });
                    table.ForeignKey(
                        name: "FK_SupermarketGoods_Goods_GoodsFK",
                        column: x => x.GoodsFK,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupermarketGoods_Supermarkets_SupermarketFK",
                        column: x => x.SupermarketFK,
                        principalTable: "Supermarkets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupermarketProducts",
                columns: table => new
                {
                    ProductFK = table.Column<long>(type: "bigint", nullable: false),
                    SupermarketFK = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupermarketProducts", x => new { x.ProductFK, x.SupermarketFK });
                    table.ForeignKey(
                        name: "FK_SupermarketProducts_Products_ProductFK",
                        column: x => x.ProductFK,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupermarketProducts_Supermarkets_SupermarketFK",
                        column: x => x.SupermarketFK,
                        principalTable: "Supermarkets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupermarketGoods_GoodsFK",
                table: "SupermarketGoods",
                column: "GoodsFK");

            migrationBuilder.CreateIndex(
                name: "IX_SupermarketProducts_SupermarketFK",
                table: "SupermarketProducts",
                column: "SupermarketFK");
        }
    }
}
