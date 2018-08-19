﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId);
        }
    }
}
