using Microsoft.EntityFrameworkCore;

namespace DemoMauiApp.DataAccess.Configurations
{
    public class MauiDbContext : DbContext
    {
        public MauiDbContext(DbContextOptions<MauiDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
