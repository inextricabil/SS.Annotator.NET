using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RTCoViD.Migrations
{
    public partial class AllStatesReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllStatesReports",
                columns: table => new
                {
                    ReportId = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Death = table.Column<double>(nullable: false),
                    DeathConfirmed = table.Column<double>(nullable: false),
                    DeathIncrease = table.Column<double>(nullable: false),
                    Hospitalized = table.Column<double>(nullable: false),
                    HospitalizedIncrease = table.Column<double>(nullable: false),
                    Negative = table.Column<double>(nullable: false),
                    NegativeIncrease = table.Column<double>(nullable: false),
                    NegativeTestsAntibody = table.Column<double>(nullable: false),
                    NegativeTestsPeopleAntibody = table.Column<double>(nullable: false),
                    NegativeTestsViral = table.Column<double>(nullable: false),
                    OnVentilatorCumulative = table.Column<double>(nullable: false),
                    OnVentilatorCurrently = table.Column<double>(nullable: false),
                    Positive = table.Column<double>(nullable: false),
                    PositiveCasesViral = table.Column<double>(nullable: false),
                    PositiveIncrease = table.Column<double>(nullable: false),
                    PositiveTestsAntibody = table.Column<double>(nullable: false),
                    PositiveTestsAntigen = table.Column<double>(nullable: false),
                    PositiveTestsPeopleAntibody = table.Column<double>(nullable: false),
                    PositiveTestsPeopleAntigen = table.Column<double>(nullable: false),
                    PositiveTestsViral = table.Column<double>(nullable: false),
                    Recovered = table.Column<double>(nullable: false),
                    TotalTestEncountersViral = table.Column<double>(nullable: false),
                    TotalTestEncountersViralIncrease = table.Column<double>(nullable: false),
                    TotalTestResults = table.Column<double>(nullable: false),
                    TotalTestResultsIncrease = table.Column<double>(nullable: false),
                    TotalTestsAntibody = table.Column<double>(nullable: false),
                    TotalTestsAntigen = table.Column<double>(nullable: false),
                    TotalTestsPeopleAntibody = table.Column<double>(nullable: false),
                    TotalTestsPeopleAntigen = table.Column<double>(nullable: false),
                    TotalTestsPeopleViral = table.Column<double>(nullable: false),
                    TotalTestsPeopleViralIncrease = table.Column<double>(nullable: false),
                    TotalTestsViral = table.Column<double>(nullable: false),
                    TotalTestsViralIncrease = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllStatesReports", x => x.ReportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllStatesReports");
        }
    }
}
