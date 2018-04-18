using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Products
{
    public class ProductGroup
    {
        public ProductGroup()
        {
            Products = new HashSet<Product>();
        }
        public string ProductGroupCode { get; set; }
        public string Description { get; set; }
        public int Recid { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
