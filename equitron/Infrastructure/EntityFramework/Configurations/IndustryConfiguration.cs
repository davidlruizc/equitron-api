using Core.Industry.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class IndustryConfiguration : IEntityTypeConfiguration<Industry>
    {
        public void Configure(EntityTypeBuilder<Industry> builder)
        {
            builder.ToTable("Industry");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Type).IsRequired();
            builder.Property(e => e.Creation).IsRequired();
            builder.HasData(
                new Industry
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Type = "Technology",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Type = "Industrials",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Type = "N/A",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Type = "Consumer Cyclical",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e24"),
                    Type = "Healthcare",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e25"),
                    Type = "Healthcare",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e26"),
                    Type = "Communication Services",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e27"),
                    Type = "Financial Services",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e28"),
                    Type = "Financial Services",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e29"),
                    Type = "Consumer Defensive",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e30"),
                    Type = "Basic Materials",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e31"),
                    Type = "Real Estate",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e32"),
                    Type = "Energy",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e33"),
                    Type = "Utilities",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e34"),
                    Type = "Financial",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b36"),
                    Type = "Services",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba97"),
                    Type = "Consumer Goods",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Industry
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680451"),
                    Type = "Industrial Goods",
                    Creation = new DateTime(2023, 5, 30)
                });
        }
    }
}
