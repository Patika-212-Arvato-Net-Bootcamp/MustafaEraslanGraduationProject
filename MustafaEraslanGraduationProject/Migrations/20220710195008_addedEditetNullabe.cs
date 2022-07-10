using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    public partial class addedEditetNullabe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "vote_count",
                table: "mytable",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "vote_average",
                table: "mytable",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<decimal>(
                name: "runtime",
                table: "mytable",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "revenue",
                table: "mytable",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<decimal>(
                name: "popularity",
                table: "mytable",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<long>(
                name: "budget",
                table: "mytable",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "vote_count",
                table: "mytable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "vote_average",
                table: "mytable",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "video",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "tagline",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "status",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "spoken_languages",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "runtime",
                table: "mytable",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "revenue",
                table: "mytable",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "release_date",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_countries",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "production_companies",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "poster_path",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "popularity",
                table: "mytable",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "overview",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_title",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "original_language",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "imdb_id",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "homepage",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "genres",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "budget",
                table: "mytable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "belongs_to_collection",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "adult",
                table: "mytable",
                type: "character(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(char),
                oldType: "character(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
