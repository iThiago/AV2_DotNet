using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.EntityConfiguration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);
            Property(p => p.Name).IsRequired().HasMaxLength(150);
            Property(p => p.Brand).IsRequired().HasMaxLength(150);
            Property(p => p.Stock).IsRequired();
        }

    }
}
