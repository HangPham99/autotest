using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FunctionTestingId",
                table: "TestScreens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectDetailId",
                table: "FunctionTestings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestScreens_FunctionTestingId",
                table: "TestScreens",
                column: "FunctionTestingId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionTestings_ProjectDetailId",
                table: "FunctionTestings",
                column: "ProjectDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionTestings_ProjectDetails_ProjectDetailId",
                table: "FunctionTestings",
                column: "ProjectDetailId",
                principalTable: "ProjectDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_FunctionTestings_ProjectDetails_ProjectDetailId",
                table: "FunctionTestings");

            migrationBuilder.DropForeignKey(
                name: "FK_TestScreens_FunctionTestings_FunctionTestingId",
                table: "TestScreens");

            migrationBuilder.DropIndex(
                name: "IX_TestScreens_FunctionTestingId",
                table: "TestScreens");

            migrationBuilder.DropIndex(
                name: "IX_FunctionTestings_ProjectDetailId",
                table: "FunctionTestings");

            migrationBuilder.DropColumn(
                name: "FunctionTestingId",
                table: "TestScreens");

            migrationBuilder.DropColumn(
                name: "ProjectDetailId",
                table: "FunctionTestings");
        }
    }
}
