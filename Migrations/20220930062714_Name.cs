using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviNa.Migrations
{
    public partial class Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Producers");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "Name");
        }
    }
}
