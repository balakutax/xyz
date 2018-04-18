using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Trade
{
    public class SalesDetail
    {
        public int SalesId { get; set; }
        public int Qty { get; set; }
        public Decimal Price { get; set; }
        public Decimal TotalPrice { get; set; }
        public string ProductCode { get; set; }
    }
}
