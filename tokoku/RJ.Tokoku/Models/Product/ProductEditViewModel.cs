using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductModel = RJ.Tokoku.DataLayer.Products;

namespace RJ.Tokoku.Models.Product
{
    public class ProductEditViewModel
    {
        public ProductModel.Product ProductToEdit { get; set; }
        public SelectList ProductGroups { get; set; }
    }
}