using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class updateVendorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Marchants_VendorId",
                table: "Marchants");

            migrationBuilder.CreateIndex(
                name: "IX_Marchants_VendorId",
                table: "Marchants",
                column: "VendorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Marchants_VendorId",
                table: "Marchants");

            migrationBuilder.CreateIndex(
                name: "IX_Marchants_VendorId",
                table: "Marchants",
                column: "VendorId");
        }
    }
}
