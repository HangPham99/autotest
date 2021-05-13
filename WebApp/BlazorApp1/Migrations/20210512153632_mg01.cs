using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class mg01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FunctionTestingId",
                table: "TestScreens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestScreens_FunctionTestingId",
                table: "TestScreens",
                column: "FunctionTestingId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestScreens_FunctionTestings_FunctionTestingId",
                table: "TestScreens",
                column: "FunctionTestingId",
                principalTable: "FunctionTestings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestScreens_FunctionTestings_FunctionTestingId",
                table: "TestScreens");

            migrationBuilder.DropIndex(
                name: "IX_TestScreens_FunctionTestingId",
                table: "TestScreens");

            migrationBuilder.DropColumn(
                name: "FunctionTestingId",
                table: "TestScreens");
        }
    }
}
