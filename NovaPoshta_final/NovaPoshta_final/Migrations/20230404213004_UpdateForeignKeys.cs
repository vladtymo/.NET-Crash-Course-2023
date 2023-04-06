using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPoshta_final.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Offices_PostOfficeId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "AddresseeId",
                table: "Parcels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_AddresseeId",
                table: "Parcels",
                column: "AddresseeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Offices_PostOfficeId",
                table: "Employees",
                column: "PostOfficeId",
                principalTable: "Offices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Clients_AddresseeId",
                table: "Parcels",
                column: "AddresseeId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Offices_PostOfficeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Clients_AddresseeId",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_AddresseeId",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "AddresseeId",
                table: "Parcels");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Offices_PostOfficeId",
                table: "Employees",
                column: "PostOfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
