using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RTCoViD.Migrations
{
    public partial class AllStatesReportsStringDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
