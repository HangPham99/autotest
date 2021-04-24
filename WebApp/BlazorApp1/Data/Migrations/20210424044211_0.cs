using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Data.Migrations
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Links",
                table: "ProjectDetails");

            migrationBuilder.RenameColumn(
                name: "ScreenID",
                table: "Reports",
                newName: "TestcaseID");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Reports",
                newName: "FunctionID");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Projects",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "ScreenName",
                table: "ProjectDetails",
                newName: "FunctionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestcaseID",
                table: "Reports",
                newName: "ScreenID");

            migrationBuilder.RenameColumn(
                name: "FunctionID",
                table: "Reports",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Projects",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "FunctionName",
                table: "ProjectDetails",
                newName: "ScreenName");

            migrationBuilder.AddColumn<string>(
                name: "Links",
                table: "ProjectDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
