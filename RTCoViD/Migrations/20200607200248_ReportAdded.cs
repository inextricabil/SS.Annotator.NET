using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RTCoViD.Migrations
{
    public partial class ReportAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Verified",
                table: "Tweet",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "DailyConfirmedReports",
                columns: table => new
                {
                    DailyConfirmedReportId = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Value = table.Column<long>(nullable: false),
                    ReportId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyConfirmedReports", x => x.DailyConfirmedReportId);
                    table.ForeignKey(
                        name: "FK_DailyConfirmedReports_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyDeathsReports",
                columns: table => new
                {
                    DailyDeathsReportId = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Value = table.Column<long>(nullable: false),
                    ReportId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyDeathsReports", x => x.DailyDeathsReportId);
                    table.ForeignKey(
                        name: "FK_DailyDeathsReports_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyRecoveredReports",
                columns: table => new
                {
                    DailyRecoveredReportId = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Value = table.Column<long>(nullable: false),
                    ReportId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyRecoveredReports", x => x.DailyRecoveredReportId);
                    table.ForeignKey(
                        name: "FK_DailyRecoveredReports_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyConfirmedReports_ReportId",
                table: "DailyConfirmedReports",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyDeathsReports_ReportId",
                table: "DailyDeathsReports",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRecoveredReports_ReportId",
                table: "DailyRecoveredReports",
                column: "ReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyConfirmedReports");

            migrationBuilder.DropTable(
                name: "DailyDeathsReports");

            migrationBuilder.DropTable(
                name: "DailyRecoveredReports");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.AlterColumn<bool>(
                name: "Verified",
                table: "Tweet",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
