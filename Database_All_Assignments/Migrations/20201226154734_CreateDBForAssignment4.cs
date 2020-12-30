using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class CreateDBForAssignment4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetCountriesList",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCountriesList", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "GetCitiesList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: false),
                    States = table.Column<string>(nullable: false),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCitiesList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetCitiesList_GetCountriesList_CountryId",
                        column: x => x.CountryId,
                        principalTable: "GetCountriesList",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GetPeopleList",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 80, nullable: false),
                    LastName = table.Column<string>(maxLength: 80, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    Address = table.Column<string>(maxLength: 80, nullable: false),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetPeopleList", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_GetPeopleList_GetCitiesList_CityId",
                        column: x => x.CityId,
                        principalTable: "GetCitiesList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetCitiesList_CountryId",
                table: "GetCitiesList",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GetPeopleList_CityId",
                table: "GetPeopleList",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetPeopleList");

            migrationBuilder.DropTable(
                name: "GetCitiesList");

            migrationBuilder.DropTable(
                name: "GetCountriesList");
        }
    }
}
