using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supermarkets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supermarkets", x => x.Id);
                });

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
                    SupermarketFK = table.Column<long>(type: "bigint", nullable: false),
                    ProductFK = table.Column<long>(type: "bigint", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupermarketGoods");

            migrationBuilder.DropTable(
                name: "SupermarketProducts");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Supermarkets");
        }
    }
}
