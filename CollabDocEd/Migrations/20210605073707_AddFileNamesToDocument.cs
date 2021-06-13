using Microsoft.EntityFrameworkCore.Migrations;

namespace CollabDocEd.Migrations
{
    public partial class AddFileNamesToDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmazonFilename",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filename",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmazonFilename",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Filename",
                table: "Documents");
        }
    }
}
