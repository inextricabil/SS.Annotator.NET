using Microsoft.EntityFrameworkCore.Migrations;

namespace RTCoViD.Migrations
{
    public partial class NullsForLongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsViralIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleViralIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleAntigen",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsAntigen",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestResultsIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestResults",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestEncountersViralIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestEncountersViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Recovered",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsPeopleAntigen",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsAntigen",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PositiveCasesViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Positive",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "OnVentilatorCurrently",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "OnVentilatorCumulative",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsViral",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsAntibody",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "NegativeIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Negative",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "HospitalizedIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Hospitalized",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "DeathIncrease",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "DeathConfirmed",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Death",
                table: "AllStatesReports",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsViralIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleViralIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleAntigen",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsAntigen",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestsAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestResultsIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestResults",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestEncountersViralIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTestEncountersViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Recovered",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsPeopleAntigen",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsAntigen",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveTestsAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PositiveCasesViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Positive",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OnVentilatorCurrently",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OnVentilatorCumulative",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsViral",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsPeopleAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NegativeTestsAntibody",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NegativeIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Negative",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "HospitalizedIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Hospitalized",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DeathIncrease",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DeathConfirmed",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Death",
                table: "AllStatesReports",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
