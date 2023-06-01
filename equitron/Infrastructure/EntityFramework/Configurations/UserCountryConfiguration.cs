using Core.Country.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
	internal class UserCountryConfiguration : IEntityTypeConfiguration<UserCountry>
    {
		public void Configure(EntityTypeBuilder<UserCountry> builder)
		{
			builder.ToTable("UserCountry");
            builder.HasKey(u => u.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.CountryId).IsRequired();
            builder.HasOne<Users>().WithMany().HasForeignKey(p => p.UserId);
            builder.HasOne<Country>().WithMany().HasForeignKey(p => p.CountryId);
        }
	}
}