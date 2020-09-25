using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cbtest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cbtests",
                columns: table => new
                {
                    CbtestEntityId = table.Column<Guid>(nullable: false),
                    UserAction = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cbtests", x => x.CbtestEntityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cbtests");
        }
    }
}
