using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreatePersonLanguageTable_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageID",
                table: "PersonLanguage");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "PersonLanguage");

            migrationBuilder.AddColumn<int>(
                name: "PersonLanguagePersonLangID",
                table: "GetPeopleList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonLanguagePersonLangID",
                table: "GetLanguageList",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GetPeopleList_PersonLanguagePersonLangID",
                table: "GetPeopleList",
                column: "PersonLanguagePersonLangID");

            migrationBuilder.CreateIndex(
                name: "IX_GetLanguageList_PersonLanguagePersonLangID",
                table: "GetLanguageList",
                column: "PersonLanguagePersonLangID");

            migrationBuilder.AddForeignKey(
                name: "FK_GetLanguageList_PersonLanguage_PersonLanguagePersonLangID",
                table: "GetLanguageList",
                column: "PersonLanguagePersonLangID",
                principalTable: "PersonLanguage",
                principalColumn: "PersonLangID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GetPeopleList_PersonLanguage_PersonLanguagePersonLangID",
                table: "GetPeopleList",
                column: "PersonLanguagePersonLangID",
                principalTable: "PersonLanguage",
                principalColumn: "PersonLangID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetLanguageList_PersonLanguage_PersonLanguagePersonLangID",
                table: "GetLanguageList");

            migrationBuilder.DropForeignKey(
                name: "FK_GetPeopleList_PersonLanguage_PersonLanguagePersonLangID",
                table: "GetPeopleList");

            migrationBuilder.DropIndex(
                name: "IX_GetPeopleList_PersonLanguagePersonLangID",
                table: "GetPeopleList");

            migrationBuilder.DropIndex(
                name: "IX_GetLanguageList_PersonLanguagePersonLangID",
                table: "GetLanguageList");

            migrationBuilder.DropColumn(
                name: "PersonLanguagePersonLangID",
                table: "GetPeopleList");

            migrationBuilder.DropColumn(
                name: "PersonLanguagePersonLangID",
                table: "GetLanguageList");

            migrationBuilder.AddColumn<int>(
                name: "LanguageID",
                table: "PersonLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "PersonLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
