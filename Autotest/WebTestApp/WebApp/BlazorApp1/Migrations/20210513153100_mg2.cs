using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionTestings_ProjectDetails_ProjectDetailId",
                table: "FunctionTestings");

            migrationBuilder.DropIndex(
                name: "IX_FunctionTestings_ProjectDetailId",
                table: "FunctionTestings");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectDetailId",
                table: "FunctionTestings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProjectDetailId",
                table: "FunctionTestings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
