using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBBI.Migrations
{
    public partial class dodanEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Application",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Application");
        }
    }
}
