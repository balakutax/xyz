using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Products
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal GoodsAvailableForSale { get; set; }
        public int Recid { get; set; }
        public string ProductGroupCode { get; set; }
        public virtual ProductGroup ProductGroupRef { get; set; }
    }
}
