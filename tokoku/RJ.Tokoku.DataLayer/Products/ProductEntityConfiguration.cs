using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Products
{
    public class ProductEntityConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductEntityConfiguration()
        {
            HasKey(x => x.ProductCode);
            Property(x => x.ProductCode).HasMaxLength(15);
            Property(x => x.Name).HasMaxLength(150);
            Property(x => x.Recid).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
