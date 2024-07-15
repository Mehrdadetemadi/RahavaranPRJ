using Microsoft.EntityFrameworkCore;
using RahavaranPRJ.Models;

namespace RahavaranPRJ.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<assessment> assessment { set; get; }
        public DbSet<cartable> cartable { set; get; }
        public DbSet<competenceIndicator> competenceIndicator { set; get; }
        public DbSet<course> course { set; get; }
        public DbSet<document> document { set; get; }
        public DbSet<monthlyForm> monthlyForm { set; get; }
        public DbSet<person> person { set; get; }
        public DbSet<position> position { set; get; }
        public DbSet<rule> rule { set; get; }
        public DbSet<user> user { set; get; }
        public DbSet<violation> violation { set; get; }

    }
}
