using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class UpdateVendorModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Marchants_MarchantId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Vendors_VendorId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MarchantId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MarchantId",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "officeId",
                table: "Marchants",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_VendorId",
                table: "Contacts",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Vendors_VendorId",
                table: "Contacts",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Vendors_VendorId",
                table: "Managers",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Vendors_VendorId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Vendors_VendorId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_VendorId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "officeId",
                table: "Marchants");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Managers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MarchantId",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MarchantId",
                table: "Contacts",
                column: "MarchantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Marchants_MarchantId",
                table: "Contacts",
                column: "MarchantId",
                principalTable: "Marchants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Vendors_VendorId",
                table: "Managers",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
