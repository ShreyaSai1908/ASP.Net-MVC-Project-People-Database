using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreatePersonLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetLanguageList_GetPeopleList_PersonID",
                table: "GetLanguageList");

            migrationBuilder.DropForeignKey(
                name: "FK_GetPeopleList_GetLanguageList_LanguageID",
                table: "GetPeopleList");

            migrationBuilder.DropIndex(
                name: "IX_GetPeopleList_LanguageID",
                table: "GetPeopleList");

            migrationBuilder.DropIndex(
                name: "IX_GetLanguageList_PersonID",
                table: "GetLanguageList");

            migrationBuilder.DropColumn(
                name: "LanguageID",
                table: "GetPeopleList");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "GetLanguageList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageID",
                table: "GetPeopleList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "GetLanguageList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GetPeopleList_LanguageID",
                table: "GetPeopleList",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_GetLanguageList_PersonID",
                table: "GetLanguageList",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_GetLanguageList_GetPeopleList_PersonID",
                table: "GetLanguageList",
                column: "PersonID",
                principalTable: "GetPeopleList",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GetPeopleList_GetLanguageList_LanguageID",
                table: "GetPeopleList",
                column: "LanguageID",
                principalTable: "GetLanguageList",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
