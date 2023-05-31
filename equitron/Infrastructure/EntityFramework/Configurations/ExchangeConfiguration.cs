using Core.Exchange.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class ExchangeConfiguration : IEntityTypeConfiguration<Exchange>
    {
        public void Configure(EntityTypeBuilder<Exchange> builder)
        {
            builder.ToTable("exchange");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.UniqueId).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Country).IsRequired();
            builder.Property(e => e.Creation).IsRequired();

            builder.HasData(
                new Exchange
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    UniqueId = "NASDAQ",
                    Name = "NASDAQ Stock Exchange",
                    Country = "ud",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    UniqueId = "NYSE",
                    Name = "New York Stock Exchange",
                    Country = "us",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    UniqueId = "DJI",
                    Name = "Dow Jones Industrial Average",
                    Country = "us",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    UniqueId = "OTC",
                    Name = "Over-the-counter",
                    Country = "us",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("b27d5296-2ab6-4afa-8c02-61c9340e1e24"),
                    UniqueId = "NYSEARCA",
                    Name = "NYSE Arca",
                    Country = "us",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    UniqueId = "NYSEAMERICAN",
                    Name = "NYSE American",
                    Country = "us",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    UniqueId = "CCY",
                    Name = "Currency",
                    Country = "global",
                    Creation = new DateTime(2023, 5, 30)
                },
                new Exchange
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca52"),
                    UniqueId = "TSXV",
                    Name = "TSX Venture Exchange",
                    Country = "ca",
                    Creation = new DateTime(2023, 5, 30)
                });
        }
    }
}
