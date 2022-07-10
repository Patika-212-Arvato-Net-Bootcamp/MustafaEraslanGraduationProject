using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    public partial class addedEditedAdult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(char),
                oldType: "character(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(1)",
                nullable: false,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);
        }
    }
}
