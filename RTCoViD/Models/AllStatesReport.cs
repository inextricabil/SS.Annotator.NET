using System;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RTCoViD.Models
{
    public class AllStatesReport
    {
        [Key]
        public string ReportId { get; set; }
        [Name("date")]
        public string Date { get; set; }
        [Name("state")]
        public string State { get; set; }
        [Name("death")]
        public double? Death { get; set; }
        [Name("deathConfirmed")]
        public double? DeathConfirmed { get; set; }
        [Name("deathIncrease")]
        public double? DeathIncrease { get; set; }
        [Name("hospitalized")]
        public double? Hospitalized { get; set; }
        [Name("hospitalizedIncrease")]
        public double? HospitalizedIncrease { get; set; }
        [Name("negative")]
        public double? Negative { get; set; }
        [Name("negativeIncrease")]
        public double? NegativeIncrease { get; set; }
        [Name("negativeTestsAntibody")]
        public double? NegativeTestsAntibody { get; set; }
        [Name("negativeTestsPeopleAntibody")]
        public double? NegativeTestsPeopleAntibody { get; set; }
        [Name("negativeTestsViral")]
        public double? NegativeTestsViral { get; set; }
        [Name("onVentilatorCumulative")]
        public double? OnVentilatorCumulative { get; set; }
        [Name("onVentilatorCurrently")]
        public double? OnVentilatorCurrently { get; set; }
        [Name("positive")]
        public double? Positive { get; set; }
        [Name("positiveCasesViral")]
        public double? PositiveCasesViral { get; set; }
        [Name("positiveIncrease")]
        public double? PositiveIncrease { get; set; }
        [Name("positiveTestsAntibody")]
        public double? PositiveTestsAntibody { get; set; }
        [Name("positiveTestsAntigen")]
        public double? PositiveTestsAntigen { get; set; }
        [Name("positiveTestsPeopleAntibody")]
        public double? PositiveTestsPeopleAntibody { get; set; }
        [Name("positiveTestsPeopleAntigen")]
        public double? PositiveTestsPeopleAntigen { get; set; }
        [Name("positiveTestsViral")]
        public double? PositiveTestsViral { get; set; }
        [Name("recovered")]
        public double? Recovered { get; set; }
        [Name("totalTestEncountersViral")]
        public double? TotalTestEncountersViral { get; set; }
        [Name("totalTestEncountersViralIncrease")]
        public double? TotalTestEncountersViralIncrease { get; set; }
        [Name("totalTestResults")]
        public double? TotalTestResults { get; set; }
        [Name("totalTestResultsIncrease")]
        public double? TotalTestResultsIncrease { get; set; }
        [Name("totalTestsAntibody")]
        public double? TotalTestsAntibody { get; set; }
        [Name("totalTestsAntigen")]
        public double? TotalTestsAntigen { get; set; }
        [Name("totalTestsPeopleAntibody")]
        public double? TotalTestsPeopleAntibody { get; set; }
        [Name("totalTestsPeopleAntigen")]
        public double? TotalTestsPeopleAntigen { get; set; }
        [Name("totalTestsPeopleViral")]
        public double? TotalTestsPeopleViral { get; set; }
        [Name("totalTestsPeopleViralIncrease")]
        public double? TotalTestsPeopleViralIncrease { get; set; }
        [Name("totalTestsViral")]
        public double? TotalTestsViral { get; set; }
        [Name("totalTestsViralIncrease")]
        public double? TotalTestsViralIncrease { get; set; }
    }
}
