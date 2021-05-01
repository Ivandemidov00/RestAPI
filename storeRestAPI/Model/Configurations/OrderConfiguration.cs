using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Model.Configurations
{
    public class OrderConfiguration:IEntityTypeConfiguration<order>
    {
        public void Configure(EntityTypeBuilder<order> builder)
        {
            builder.ToTable("order").HasKey(prop => prop.Id);
            
        }
    }
}
