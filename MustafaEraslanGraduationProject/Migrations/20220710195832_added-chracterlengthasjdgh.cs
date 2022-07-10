using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    public partial class addedchracterlengthasjdgh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(50000)",
                maxLength: 50000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(5000000)",
                oldMaxLength: 5000000,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(5000000)",
                maxLength: 5000000,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(50000)",
                oldMaxLength: 50000,
                oldNullable: true);
        }
    }
}
