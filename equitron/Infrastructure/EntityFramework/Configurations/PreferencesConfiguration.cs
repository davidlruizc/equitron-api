using Core.Preferences.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class PreferencesConfiguration : IEntityTypeConfiguration<Preferences>
    {
        public void Configure(EntityTypeBuilder<Preferences> builder)
        {
            builder.ToTable("preferences");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Symbol).IsRequired();

            builder.Property(p => p.Creation).IsRequired();

            builder.HasOne<Users>().WithMany().HasForeignKey(p => p.UserId);
        }
    }
}
