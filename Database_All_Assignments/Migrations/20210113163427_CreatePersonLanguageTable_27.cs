using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreatePersonLanguageTable_27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage");

            migrationBuilder.DropIndex(
                name: "IX_PersonLanguage_PersonID",
                table: "PersonLanguage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage",
                columns: new[] { "PersonID", "LanguageID", "PersonLangID" });

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguage",
                table: "PersonLanguage",
                columns: new[] { "LanguageID", "PersonLangID" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonLanguage_PersonID",
                table: "PersonLanguage",
                column: "PersonID");
        }
    }
}
