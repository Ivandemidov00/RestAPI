using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace storeRestAPI.Model.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder)
        {
            builder.ToTable("user").HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).HasMaxLength(30);
        }

    }
}
