using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.InventoryManagement
{
    public class WarehouseEntityConfiguration :EntityTypeConfiguration<Warehouse>
    {
        public WarehouseEntityConfiguration()
        {
            HasKey(x => x.code);
            Property(x => x.address).HasMaxLength(250);
            Property(x => x.city).HasMaxLength(150);
            Property(x => x.recid).HasDatabaseGeneratedOption(databaseGeneratedOption: DatabaseGeneratedOption.Identity);
        }
    }
}
