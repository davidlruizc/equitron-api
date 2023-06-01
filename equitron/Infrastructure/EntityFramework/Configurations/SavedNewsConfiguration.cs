using Core.SavedNews.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
	internal class SavedNewsConfiguration : IEntityTypeConfiguration<SavedNews>
    {
		public void Configure(EntityTypeBuilder<SavedNews> builder)
		{
			builder.ToTable("SavedNews");
			builder.HasKey(p => p.Id);
			builder.Property(p => p.UserId).IsRequired();
			builder.Property(p => p.NewsId).IsRequired();
			builder.Property(p => p.Title).IsRequired();
			builder.Property(p => p.Creation).IsRequired();
		}
	}
}

