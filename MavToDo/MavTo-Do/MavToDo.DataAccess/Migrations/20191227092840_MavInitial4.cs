using Microsoft.EntityFrameworkCore.Migrations;

namespace MavToDo.DataAccess.Migrations
{
    public partial class MavInitial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ThingsToDos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ThingsToDos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
