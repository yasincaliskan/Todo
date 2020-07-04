using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoList.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Todos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserID",
                table: "Todos",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_UserID",
                table: "Todos",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_UserID",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Todos");
        }
    }
}
