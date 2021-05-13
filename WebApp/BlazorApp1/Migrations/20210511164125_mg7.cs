using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class mg7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FunctionId",
                table: "FunctionTestings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FunctionTestings_FunctionId",
                table: "FunctionTestings",
                column: "FunctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionTestings_ProjectDetails_FunctionId",
                table: "FunctionTestings",
                column: "FunctionId",
                principalTable: "ProjectDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionTestings_ProjectDetails_FunctionId",
                table: "FunctionTestings");

            migrationBuilder.DropIndex(
                name: "IX_FunctionTestings_FunctionId",
                table: "FunctionTestings");

            migrationBuilder.DropColumn(
                name: "FunctionId",
                table: "FunctionTestings");
        }
    }
}
