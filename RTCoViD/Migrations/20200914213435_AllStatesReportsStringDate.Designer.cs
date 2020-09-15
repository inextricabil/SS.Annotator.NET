﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RTCoViD.Data;

namespace RTCoViD.Migrations
{
    [DbContext(typeof(RTCoViDContext))]
    [Migration("20200914213435_AllStatesReportsStringDate")]
    partial class AllStatesReportsStringDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RTCoViD.Models.AllStatesReport", b =>
                {
                    b.Property<string>("ReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<double>("Death");

                    b.Property<double>("DeathConfirmed");

                    b.Property<double>("DeathIncrease");

                    b.Property<double>("Hospitalized");

                    b.Property<double>("HospitalizedIncrease");

                    b.Property<double>("Negative");

                    b.Property<double>("NegativeIncrease");

                    b.Property<double>("NegativeTestsAntibody");

                    b.Property<double>("NegativeTestsPeopleAntibody");

                    b.Property<double>("NegativeTestsViral");

                    b.Property<double>("OnVentilatorCumulative");

                    b.Property<double>("OnVentilatorCurrently");

                    b.Property<double>("Positive");

                    b.Property<double>("PositiveCasesViral");

                    b.Property<double>("PositiveIncrease");

                    b.Property<double>("PositiveTestsAntibody");

                    b.Property<double>("PositiveTestsAntigen");

                    b.Property<double>("PositiveTestsPeopleAntibody");

                    b.Property<double>("PositiveTestsPeopleAntigen");

                    b.Property<double>("PositiveTestsViral");

                    b.Property<double>("Recovered");

                    b.Property<string>("State");

                    b.Property<double>("TotalTestEncountersViral");

                    b.Property<double>("TotalTestEncountersViralIncrease");

                    b.Property<double>("TotalTestResults");

                    b.Property<double>("TotalTestResultsIncrease");

                    b.Property<double>("TotalTestsAntibody");

                    b.Property<double>("TotalTestsAntigen");

                    b.Property<double>("TotalTestsPeopleAntibody");

                    b.Property<double>("TotalTestsPeopleAntigen");

                    b.Property<double>("TotalTestsPeopleViral");

                    b.Property<double>("TotalTestsPeopleViralIncrease");

                    b.Property<double>("TotalTestsViral");

                    b.Property<double>("TotalTestsViralIncrease");

                    b.HasKey("ReportId");

                    b.ToTable("AllStatesReports");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyConfirmedReport", b =>
                {
                    b.Property<string>("DailyConfirmedReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("ReportId");

                    b.Property<long>("Value");

                    b.HasKey("DailyConfirmedReportId");

                    b.HasIndex("ReportId");

                    b.ToTable("DailyConfirmedReports");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyDeathsReport", b =>
                {
                    b.Property<string>("DailyDeathsReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("ReportId");

                    b.Property<long>("Value");

                    b.HasKey("DailyDeathsReportId");

                    b.HasIndex("ReportId");

                    b.ToTable("DailyDeathsReports");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyRecoveredReport", b =>
                {
                    b.Property<string>("DailyRecoveredReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("ReportId");

                    b.Property<long>("Value");

                    b.HasKey("DailyRecoveredReportId");

                    b.HasIndex("ReportId");

                    b.ToTable("DailyRecoveredReports");
                });

            modelBuilder.Entity("RTCoViD.Models.Report", b =>
                {
                    b.Property<string>("ReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("Province");

                    b.HasKey("ReportId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("RTCoViD.Models.Tweet", b =>
                {
                    b.Property<string>("TweetId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Location");

                    b.Property<string>("Text");

                    b.Property<string>("UserId");

                    b.Property<int>("Verified");

                    b.HasKey("TweetId");

                    b.ToTable("Tweet");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyConfirmedReport", b =>
                {
                    b.HasOne("RTCoViD.Models.Report", "Report")
                        .WithMany("DailyConfirmedReports")
                        .HasForeignKey("ReportId");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyDeathsReport", b =>
                {
                    b.HasOne("RTCoViD.Models.Report", "Report")
                        .WithMany("DailyDeathsReports")
                        .HasForeignKey("ReportId");
                });

            modelBuilder.Entity("RTCoViD.Models.DailyRecoveredReport", b =>
                {
                    b.HasOne("RTCoViD.Models.Report", "Report")
                        .WithMany("DailyRecoveredReports")
                        .HasForeignKey("ReportId");
                });
#pragma warning restore 612, 618
        }
    }
}
