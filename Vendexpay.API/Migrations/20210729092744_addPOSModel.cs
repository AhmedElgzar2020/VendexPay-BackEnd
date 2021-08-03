using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendexpay.API.Migrations
{
    public partial class addPOSModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermnalNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IT_AssetNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIM_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    modefiedBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POs");
        }
    }
}
