using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    public partial class editedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpokenLanguages",
                table: "mytable",
                newName: "spoken_languages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "spoken_languages",
                table: "mytable",
                newName: "SpokenLanguages");
        }
    }
}
