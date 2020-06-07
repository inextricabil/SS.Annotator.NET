using Microsoft.EntityFrameworkCore;
using RTCoViD.Models;

namespace RTCoViD.Data
{
    public class RTCoViDContext : DbContext
    {
        public RTCoViDContext (DbContextOptions<RTCoViDContext> options)
            : base(options)
        {
        }

        public DbSet<Tweet> Tweet { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<DailyConfirmedReport> DailyConfirmedReports { get; set; }
        public DbSet<DailyRecoveredReport> DailyRecoveredReports { get; set; }
        public DbSet<DailyDeathsReport> DailyDeathsReports { get; set; }
    }
}
