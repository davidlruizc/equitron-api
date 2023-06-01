using Core.Country.Domain.Model;
using Core.Exchange.Domain.Model;
using Core.Industry.Domain.Model;
using Core.SavedNews.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public partial class EquitronContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Exchange> Exchange { get; set; }
        public DbSet<Industry> Industry { get; set; }
        public DbSet<SavedNews> SavedNews { get; set; }
        public DbSet<UserCountry> UserCountry { get; set; }
        public DbSet<UserExchange> UserExchange { get; set; }
        public DbSet<UserIndustry> UserIndustry { get; set; }

        public EquitronContext() { }

        public EquitronContext(DbContextOptions<EquitronContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.UsersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CountryConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ExchangeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.IndustryConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SavedNewsConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserExchangeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserCountryConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserIndustryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
