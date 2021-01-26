using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_All_Assignments.Migrations
{
    public partial class AppIdentityCU_28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (100)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "NVARCHAR (100)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }
    }
}
