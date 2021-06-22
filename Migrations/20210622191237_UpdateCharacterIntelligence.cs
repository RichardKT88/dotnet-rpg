using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class UpdateCharacterIntelligence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inteligence",
                table: "Characters",
                newName: "Intelligence");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Intelligence",
                table: "Characters",
                newName: "Inteligence");
        }
    }
}
