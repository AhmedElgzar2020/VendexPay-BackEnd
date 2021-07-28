using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class AddVendorModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "buildingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentVendorId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_Vendors_ParentVendorId",
                        column: x => x.ParentVendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RenewalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RenewalExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marchants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marchants_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marchants_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marchants_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarchantId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Marchants_MarchantId",
                        column: x => x.MarchantId,
                        principalTable: "Marchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarchantId = table.Column<int>(type: "int", nullable: false),
                    ZoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingTypeid = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_buildingTypes_BuildingTypeid",
                        column: x => x.BuildingTypeid,
                        principalTable: "buildingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offices_Marchants_MarchantId",
                        column: x => x.MarchantId,
                        principalTable: "Marchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MarchantId",
                table: "Contacts",
                column: "MarchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_VendorId",
                table: "Contracts",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_VendorId",
                table: "Managers",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Marchants_CityId",
                table: "Marchants",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Marchants_CompanyTypeId",
                table: "Marchants",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Marchants_VendorId",
                table: "Marchants",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_BuildingTypeid",
                table: "Offices",
                column: "BuildingTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_MarchantId",
                table: "Offices",
                column: "MarchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_ParentVendorId",
                table: "Vendors",
                column: "ParentVendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "buildingTypes");

            migrationBuilder.DropTable(
                name: "Marchants");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
