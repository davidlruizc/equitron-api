using Core.Preferences.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public partial class EquitronContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Preferences> Preferences { get; set; }

        public EquitronContext() { }

        public EquitronContext(DbContextOptions<EquitronContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.UsersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PreferencesConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
