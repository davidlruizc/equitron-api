using Core.Exchange.Domain.Model;
using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
	internal class UserExchangeConfiguration : IEntityTypeConfiguration<UserExchange>
    {
		public void Configure(EntityTypeBuilder<UserExchange> builder)
		{
            builder.ToTable("UserExchange");
            builder.HasKey(u => u.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.ExchangeId).IsRequired();
            builder.HasOne<Users>().WithMany().HasForeignKey(p => p.UserId);
            builder.HasOne<Exchange>().WithMany().HasForeignKey(p => p.ExchangeId);
        }
	}
}

