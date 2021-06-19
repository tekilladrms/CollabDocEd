using Microsoft.EntityFrameworkCore.Migrations;

namespace CollabDocEd.Migrations
{
    public partial class someChangesComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Comments",
                newName: "Filename");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Comments",
                newName: "FileVersion");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Comments",
                newName: "Created");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creator",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Filename",
                table: "Comments",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "FileVersion",
                table: "Comments",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Comments",
                newName: "Date");
        }
    }
}
