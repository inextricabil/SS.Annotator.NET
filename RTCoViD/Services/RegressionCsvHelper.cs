using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using RTCoViD.Data;

namespace RTCoViD.Services
{
    public class RegressionCsvHelper : IRegressionCsvHelper
    {
        public static string GetRegressionCsv(RTCoViDContext context)
        {
            var records = new List<RegressionRow>();



            var path = GetRegressionCsvFilePath();

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }

            return path;
        }

        public static string GetRegressionCsvFilePath()
        {
            var regressionCsvFilesFolder = "Data";
            var reportsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), regressionCsvFilesFolder,
                "regression.csv");
            return reportsFilesFolderPath;
        }
    }


    public class RegressionRow
    {
        public double Date { get; set; }
        public double LocationId { get; set; }
        public double PositiveScore { get; set; }
        public double NegativeScore { get; set; }
        public double NeutralScore { get; set; }
        public double NumberOfKeywordsFound { get; set; }
        public double Death { get; set; }
        public double DeathConfirmed { get; set; }
        public double DeathIncrease { get; set; }
        public double Hospitalized { get; set; }
        public double HospitalizedIncrease { get; set; }
        public double Negative { get; set; }
        public double NegativeIncrease { get; set; }
        public double NegativeTestsAntibody { get; set; }
        public double NegativeTestsPeopleAntibody { get; set; }
        public double NegativeTestsViral { get; set; }
        public double OnVentilatorCumulative { get; set; }
        public double OnVentilatorCurrently { get; set; }
        public double Positive { get; set; }
        public double PositiveCasesViral { get; set; }
        public double PositiveIncrease { get; set; }
        public double PositiveTestsAntibody { get; set; }
        public double PositiveTestsAntigen { get; set; }
        public double PositiveTestsPeopleAntibody { get; set; }
        public double PositiveTestsPeopleAntigen { get; set; }
        public double PositiveTestsViral { get; set; }
        public double Recovered { get; set; }
        public double TotalTestEncountersViral { get; set; }
        public double TotalTestEncountersViralIncrease { get; set; }
        public double TotalTestResults { get; set; }
        public double TotalTestResultsIncrease { get; set; }
        public double TotalTestsAntibody { get; set; }
        public double TotalTestsAntigen { get; set; }
        public double TotalTestsPeopleAntibody { get; set; }
        public double TotalTestsPeopleAntigen { get; set; }
        public double TotalTestsPeopleViral { get; set; }
        public double TotalTestsPeopleViralIncrease { get; set; }
        public double TotalTestsViral { get; set; }
        public double TotalTestsViralIncrease { get; set; }
    }

    public interface IRegressionCsvHelper
    {

    }
}
