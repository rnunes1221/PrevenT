using Microsoft.EntityFrameworkCore.Migrations;

namespace PreventWebMVC.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prev_Computer_ComputerId",
                table: "Prev");

            migrationBuilder.AlterColumn<int>(
                name: "ComputerId",
                table: "Prev",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prev_Computer_ComputerId",
                table: "Prev",
                column: "ComputerId",
                principalTable: "Computer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prev_Computer_ComputerId",
                table: "Prev");

            migrationBuilder.AlterColumn<int>(
                name: "ComputerId",
                table: "Prev",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Prev_Computer_ComputerId",
                table: "Prev",
                column: "ComputerId",
                principalTable: "Computer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
