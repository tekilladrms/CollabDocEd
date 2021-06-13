using Microsoft.EntityFrameworkCore.Migrations;

namespace CollabDocEd.Migrations
{
    public partial class someChangesInDocument7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Projects_ProjectId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Documents",
                newName: "Creator");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Documents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Proj",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Projects_ProjectId",
                table: "Documents",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Projects_ProjectId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Proj",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "Documents",
                newName: "UserId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Projects_ProjectId",
                table: "Documents",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
