﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StdCoreApp.Data.EF.Extensitions;
using StdCoreApp.Data.Entities;

namespace StdCoreApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasColumnType("varchar(50)");
            // etc.
        }
    }
}