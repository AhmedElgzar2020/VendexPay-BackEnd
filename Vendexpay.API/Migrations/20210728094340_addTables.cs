using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class addTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            
            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampignId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumers_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumers_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_VendorId",
                table: "Campaigns",
                column: "VendorId");


            migrationBuilder.CreateIndex(
                name: "IX_Consumers_CampaignId",
                table: "Consumers",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_VendorId",
                table: "Consumers",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumers");

            
            migrationBuilder.DropTable(
                name: "Campaigns");

        }
    }
}
