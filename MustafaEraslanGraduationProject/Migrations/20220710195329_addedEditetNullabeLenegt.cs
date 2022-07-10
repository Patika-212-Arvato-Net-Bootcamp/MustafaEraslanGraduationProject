using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    public partial class addedEditetNullabeLenegt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(2147483647)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(2147483647)",
                oldMaxLength: 2147483647,
                oldNullable: true);
        }
    }
}
