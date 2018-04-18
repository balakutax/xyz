using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer.Master
{
    public class ColorDim
    {
        public string ColorDimCode { get; set; }
        public string Description { get; set; }
        public int RecId { get; set; }
    }
}
