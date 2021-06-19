﻿using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product { Id = 1, Name = "Caderno", Description = "Caderno espiral 100 fôlhas", Price = 9.45m },
                new Product { Id = 2, Name = "Borracha", Description = "Borracha branca pequena", Price = 3.75m },
                new Product { Id = 3, Name = "Estojo", Description = "Estojo de plástico pequeno", Price = 5.25m }
            );
        }
    }
}
