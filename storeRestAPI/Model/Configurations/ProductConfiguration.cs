using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Model.Configurations
{
    public class ProductConfiguration:IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.ToTable("product").HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).HasMaxLength(30);
        }
    }
}
