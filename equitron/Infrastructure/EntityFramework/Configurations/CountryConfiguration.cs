using System;
using Core.Country.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
	internal class CountryConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.ToTable("country");
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Name).IsRequired();
			builder.Property(p => p.ShortName).IsRequired();
			builder.Property(p => p.Creation).IsRequired();

			builder.HasData(
				new Country
				{
					Id = Guid.Parse("0b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Argentina",
					ShortName = "ar",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("1b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Australia",
					ShortName = "au",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("2b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Belgium",
					ShortName = "be",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("3b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Brazil",
					ShortName = "br",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("4b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Canada",
					ShortName = "ca",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("5b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Switzerland",
					ShortName = "ch",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("5b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Chile",
					ShortName = "cl",
					Creation = new DateTime(2023, 5, 30)
				},

				new Country
				{
					Id = Guid.Parse("5b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "China",
					ShortName = "cn",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("6b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Czech Republic",
					ShortName = "cz",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("7b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Germany",
					ShortName = "de",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("8b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Denmark",
					ShortName = "dk",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("9b4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Estonia",
					ShortName = "ee",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("ab4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Egypt",
					ShortName = "eg",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("bb4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Spain",
					ShortName = "es",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("cb4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "European Union",
					ShortName = "eu",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("db4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "Finland",
					ShortName = "fi",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("eb4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "France",
					ShortName = "fr",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("fb4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"),
					Name = "United Kingdom",
					ShortName = "gb",
					Creation = new DateTime(2023, 5, 30)
				},
				new Country
				{
					Id = Guid.Parse("gb4a4f0e-4d5b-4f5f-8b1c-3d2e2d3f4e5f"), 
					Name = "Global",
					ShortName = "global",
					Creation = new DateTime(2023, 5, 30)
				});
		}
	}
}

