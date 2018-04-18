using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Products
{
    public class ProductGroupEntityConfiguration : EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupEntityConfiguration()
        {
            HasKey(x => x.ProductGroupCode);
            HasMany(e => e.Products)
                .WithOptional(fk => fk.ProductGroupRef)
                .HasForeignKey(fk => fk.ProductGroupCode);
            Property(x => x.ProductGroupCode).HasMaxLength(25);
            Property(x => x.Description).HasMaxLength(150);
            Property(x => x.Recid).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
