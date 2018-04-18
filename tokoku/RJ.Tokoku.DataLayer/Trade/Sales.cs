using RJ.Tokoku.DataLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Trade
{
    public class Sales
    {
        public Sales()
        {
            SalesDetails = new HashSet<SalesDetail>();
        }
        public int SalesId { get; set; }
        public string Invoice { get; set; }
        public Decimal TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Recid { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
