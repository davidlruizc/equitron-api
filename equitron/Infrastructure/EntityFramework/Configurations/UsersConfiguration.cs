using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.Property(p => p.Token).IsRequired();

            builder.Property(p => p.Creation).IsRequired();
        }
    }
}
