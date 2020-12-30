using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreateLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageID",
                table: "GetPeopleList",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GetLanguageList",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(nullable: false),
                    PersonID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetLanguageList", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_GetLanguageList_GetPeopleList_PersonID",
                        column: x => x.PersonID,
                        principalTable: "GetPeopleList",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetPeopleList_LanguageID",
                table: "GetPeopleList",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_GetLanguageList_PersonID",
                table: "GetLanguageList",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_GetPeopleList_GetLanguageList_LanguageID",
                table: "GetPeopleList",
                column: "LanguageID",
                principalTable: "GetLanguageList",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetPeopleList_GetLanguageList_LanguageID",
                table: "GetPeopleList");

            migrationBuilder.DropTable(
                name: "GetLanguageList");

            migrationBuilder.DropIndex(
                name: "IX_GetPeopleList_LanguageID",
                table: "GetPeopleList");

            migrationBuilder.DropColumn(
                name: "LanguageID",
                table: "GetPeopleList");
        }
    }
}
