using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class AddVendorDocumentsModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balaiya_Documents_DocumentId",
                table: "Balaiya");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerCard_Documents_DocumentId",
                table: "ComputerCard");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerCardAuthorizer_Documents_DocumentId",
                table: "ComputerCardAuthorizer");

            migrationBuilder.DropForeignKey(
                name: "FK_CR_Documents_DocumentId",
                table: "CR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CR",
                table: "CR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerCardAuthorizer",
                table: "ComputerCardAuthorizer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerCard",
                table: "ComputerCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balaiya",
                table: "Balaiya");

            migrationBuilder.RenameTable(
                name: "CR",
                newName: "CRs");

            migrationBuilder.RenameTable(
                name: "ComputerCardAuthorizer",
                newName: "ComputerCardAuthorizers");

            migrationBuilder.RenameTable(
                name: "ComputerCard",
                newName: "ComputerCards");

            migrationBuilder.RenameTable(
                name: "Balaiya",
                newName: "Balaiyas");

            migrationBuilder.RenameIndex(
                name: "IX_CR_DocumentId",
                table: "CRs",
                newName: "IX_CRs_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_ComputerCardAuthorizer_DocumentId",
                table: "ComputerCardAuthorizers",
                newName: "IX_ComputerCardAuthorizers_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_ComputerCard_DocumentId",
                table: "ComputerCards",
                newName: "IX_ComputerCards_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Balaiya_DocumentId",
                table: "Balaiyas",
                newName: "IX_Balaiyas_DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CRs",
                table: "CRs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerCardAuthorizers",
                table: "ComputerCardAuthorizers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerCards",
                table: "ComputerCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balaiyas",
                table: "Balaiyas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Balaiyas_Documents_DocumentId",
                table: "Balaiyas",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerCardAuthorizers_Documents_DocumentId",
                table: "ComputerCardAuthorizers",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerCards_Documents_DocumentId",
                table: "ComputerCards",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CRs_Documents_DocumentId",
                table: "CRs",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balaiyas_Documents_DocumentId",
                table: "Balaiyas");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerCardAuthorizers_Documents_DocumentId",
                table: "ComputerCardAuthorizers");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerCards_Documents_DocumentId",
                table: "ComputerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_CRs_Documents_DocumentId",
                table: "CRs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CRs",
                table: "CRs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerCards",
                table: "ComputerCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerCardAuthorizers",
                table: "ComputerCardAuthorizers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balaiyas",
                table: "Balaiyas");

            migrationBuilder.RenameTable(
                name: "CRs",
                newName: "CR");

            migrationBuilder.RenameTable(
                name: "ComputerCards",
                newName: "ComputerCard");

            migrationBuilder.RenameTable(
                name: "ComputerCardAuthorizers",
                newName: "ComputerCardAuthorizer");

            migrationBuilder.RenameTable(
                name: "Balaiyas",
                newName: "Balaiya");

            migrationBuilder.RenameIndex(
                name: "IX_CRs_DocumentId",
                table: "CR",
                newName: "IX_CR_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_ComputerCards_DocumentId",
                table: "ComputerCard",
                newName: "IX_ComputerCard_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_ComputerCardAuthorizers_DocumentId",
                table: "ComputerCardAuthorizer",
                newName: "IX_ComputerCardAuthorizer_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Balaiyas_DocumentId",
                table: "Balaiya",
                newName: "IX_Balaiya_DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CR",
                table: "CR",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerCard",
                table: "ComputerCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerCardAuthorizer",
                table: "ComputerCardAuthorizer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balaiya",
                table: "Balaiya",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Balaiya_Documents_DocumentId",
                table: "Balaiya",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerCard_Documents_DocumentId",
                table: "ComputerCard",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerCardAuthorizer_Documents_DocumentId",
                table: "ComputerCardAuthorizer",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CR_Documents_DocumentId",
                table: "CR",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
