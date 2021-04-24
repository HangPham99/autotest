using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Data.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Milestones",
                table: "ProjectDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Milestones",
                table: "ProjectDetails");
        }
    }
}
