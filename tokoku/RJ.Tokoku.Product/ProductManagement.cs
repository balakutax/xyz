using RJ.Tokoku.DataLayer;
using ProductModel = RJ.Tokoku.DataLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJ.Tokoku.BusinessRule.Product.Interface;

namespace RJ.Tokoku.BusinessRule.Product
{
    public class ProductManagement : IProductManagement
    {
        UnitOfWork uow = new UnitOfWork();

        #region Product Group
        public bool DeleteProductGroup(ProductModel.ProductGroup productGroup)
        {
            try
            {
                uow.ProductGroupRepo.Delete(productGroup);
                uow.Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public ProductModel.ProductGroup CreateProductGroup(ProductModel.ProductGroup productGroup)
        {
            uow.ProductGroupRepo.Insert(productGroup);
            uow.Save();
            return productGroup;
        }

        public ProductModel.ProductGroup EditProductGroup(ProductModel.ProductGroup productGroup)
        {
            uow.ProductGroupRepo.Update(productGroup);
            uow.Save();

            return productGroup;
        }

        public ProductModel.ProductGroup GetProductGroupById(string productGroupCode)
        {
            return uow.ProductGroupRepo.GetById(productGroupCode);
        }

        public IEnumerable<ProductModel.ProductGroup> GetAllProductGroup() => uow.ProductGroupRepo.Get();

        #endregion

        public IEnumerable<ProductModel.Product> GetAllProduct() => uow.ProductRepo.Get();

        public ProductModel.Product CreateProduct(
              string productCode
            , string productName
            , string serialNumber
            , int qty
            , string productGroupCode)
        {
            ProductModel.Product product = new ProductModel.Product
            {
                ProductCode = productCode,
                Name = productName,
                SerialNumber = serialNumber,
                Qty = qty,
                ProductGroupRef = uow.ProductGroupRepo.GetById(productGroupCode)
            };
            return uow.ProductRepo.Insert(product);
        }

        public ProductModel.Product GetProductById(string productCode)
        {
            return uow.ProductRepo.GetById(productCode);
        }
    }
}
