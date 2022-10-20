using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoExamApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Status_StatusId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "UserStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStatus",
                table: "UserStatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserStatus_StatusId",
                table: "Users",
                column: "StatusId",
                principalTable: "UserStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserStatus_StatusId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStatus",
                table: "UserStatus");

            migrationBuilder.RenameTable(
                name: "UserStatus",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Status_StatusId",
                table: "Users",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
