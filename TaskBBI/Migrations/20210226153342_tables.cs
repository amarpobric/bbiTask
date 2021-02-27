using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBBI.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationPackage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPackage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceOfResidence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceOfResidence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    PlaceOfResidenceId = table.Column<int>(nullable: false),
                    ApplicationPackageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationPackage_ApplicationPackageId",
                        column: x => x.ApplicationPackageId,
                        principalTable: "ApplicationPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_PlaceOfResidence_PlaceOfResidenceId",
                        column: x => x.PlaceOfResidenceId,
                        principalTable: "PlaceOfResidence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPackageId",
                table: "Application",
                column: "ApplicationPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_PlaceOfResidenceId",
                table: "Application",
                column: "PlaceOfResidenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "ApplicationPackage");

            migrationBuilder.DropTable(
                name: "PlaceOfResidence");
        }
    }
}
