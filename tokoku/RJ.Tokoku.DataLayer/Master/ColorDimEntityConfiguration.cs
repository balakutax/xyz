using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Master
{
    public class ColorDimEntityConfiguration : EntityTypeConfiguration<ColorDim>
    {
        public ColorDimEntityConfiguration()
        {
            HasKey(x => x.ColorDimCode);
            Property(x => x.ColorDimCode).HasMaxLength(35);
            Property(x => x.Description).HasMaxLength(55).IsRequired();
            Property(x => x.RecId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
