using Microsoft.EntityFrameworkCore.Migrations;

namespace CollabDocEd.Migrations
{
    public partial class SomeChangesInDocument8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmazonFilename",
                table: "Documents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmazonFilename",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
