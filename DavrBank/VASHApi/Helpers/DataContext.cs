using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VASHApi.Entities;

namespace VASHApi.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        //public override int SaveChanges()
        //{
        //    ChangeTracker.DetectChanges();
        //    return base.SaveChanges();
        //}

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
    }
}
