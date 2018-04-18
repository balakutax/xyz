using System.Collections.Generic;
using RJ.Tokoku.DataLayer.Products;

namespace RJ.Tokoku.BusinessRule.Product.Interface
{
    public interface IProductManagement
    {
        DataLayer.Products.Product CreateProduct(string productCode, string productName, string serialNumber, int qty, string productGroupCode);
        ProductGroup CreateProductGroup(ProductGroup productGroup);
        ProductGroup EditProductGroup(ProductGroup productGroup);
        IEnumerable<DataLayer.Products.Product> GetAllProduct();
        IEnumerable<ProductGroup> GetAllProductGroup();
        DataLayer.Products.Product GetProductById(string productCode);
        ProductGroup GetProductGroupById(string productGroupCode);
    }
}