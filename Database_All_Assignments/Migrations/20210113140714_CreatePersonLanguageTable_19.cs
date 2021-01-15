using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreatePersonLanguageTable_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage");

            migrationBuilder.AlterColumn<int>(
                name: "PersonLangID",
                table: "PersonLanguage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage",
                column: "PersonLangID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLanguage_LanguageID",
                table: "PersonLanguage",
                column: "LanguageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage");

            migrationBuilder.DropIndex(
                name: "IX_PersonLanguage_LanguageID",
                table: "PersonLanguage");

            migrationBuilder.AlterColumn<int>(
                name: "PersonLangID",
                table: "PersonLanguage",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage",
                columns: new[] { "LanguageID", "PersonLangID" });
        }
    }
}
