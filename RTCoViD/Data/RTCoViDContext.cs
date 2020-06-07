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
    }
}
