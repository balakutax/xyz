using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RJ.Tokoku.BusinessRule.Product;
using RJ.Tokoku.BusinessRule.Product.Interface;
using RJ.Tokoku.DataLayer.Products;

namespace BusinessRule.Test
{
    [TestClass]
    public class ProductManagementTest
    {
        [TestMethod]
        public void TestGetAllProductGroup()
        {
            IEnumerable<ProductGroup> pg = new List<ProductGroup>
            {
                new ProductGroup { ProductGroupCode = "A", Description = "B", Recid = 1, Products = null}
            };
            Mock<IProductManagement> mockProductManagement = new Mock<IProductManagement>();
            mockProductManagement.Setup(x => x.GetAllProductGroup()).Returns(pg);
            Assert.IsNotNull(mockProductManagement.Object.GetAllProductGroup());
            foreach (var dt in mockProductManagement.Object.GetAllProductGroup())
                Assert.AreEqual("A", dt.ProductGroupCode);
        }
    }
}
