using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoExamApp.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserStatus_StatusId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Users",
                newName: "userStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_StatusId",
                table: "Users",
                newName: "IX_Users_userStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserStatus_userStatusId",
                table: "Users",
                column: "userStatusId",
                principalTable: "UserStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserStatus_userStatusId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userStatusId",
                table: "Users",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_userStatusId",
                table: "Users",
                newName: "IX_Users_StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserStatus_StatusId",
                table: "Users",
                column: "StatusId",
                principalTable: "UserStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
