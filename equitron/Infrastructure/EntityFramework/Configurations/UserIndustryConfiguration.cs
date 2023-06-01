using Core.Industry.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
	internal class UserIndustryConfiguration : IEntityTypeConfiguration<UserIndustry>
    {
		public void Configure(EntityTypeBuilder<UserIndustry> builder)
		{
            builder.ToTable("UserIndustry");
            builder.HasKey(u => u.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.IndustryId).IsRequired();
            builder.HasOne<Users>().WithMany().HasForeignKey(p => p.UserId);
            builder.HasOne<Industry>().WithMany().HasForeignKey(p => p.IndustryId);
        }
	}
}

