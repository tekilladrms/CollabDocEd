using Microsoft.EntityFrameworkCore.Migrations;

namespace CollabDocEd.Migrations
{
    public partial class RemoveNameFromDocumentAndAddFileVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Documents",
                newName: "FileVersion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileVersion",
                table: "Documents",
                newName: "Name");
        }
    }
}
