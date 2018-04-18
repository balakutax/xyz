using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RJ.Tokoku.BusinessRule.Product;
using RJ.Tokoku.DataLayer.Products;

namespace RJ.Tokoku.Controllers.Product
{
    public class ProductGroupController : Controller
    {
        private ProductManagement productManagement;
        public ProductGroupController()
        {
            productManagement = new ProductManagement();
        }
        // GET: ProductGroup
        public ViewResult Index()
        {            
            return View(productManagement.GetAllProductGroup());
        }

        [HttpGet]
        public ActionResult Details(string productGroupCode, bool isDelete = false)
        {
            if (!String.IsNullOrEmpty(productGroupCode))
            {
                if (isDelete)
                {
                    ViewBag.IsDelete = true;
                }
                return View(productManagement.GetProductGroupById(productGroupCode));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string productGroupCode)
        {
            if (!String.IsNullOrEmpty(productGroupCode))
            {
                return View(productManagement.GetProductGroupById(productGroupCode));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductGroup productGroup)
        {
            if (ModelState.IsValid)
            {
                productManagement.EditProductGroup(productGroup);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductGroup productGroup)
        {
            if (ModelState.IsValid)
            {
                productManagement.CreateProductGroup(productGroup);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult Delete(string productGroupCode)
        {
            if (String.IsNullOrEmpty(productGroupCode))
            {
                return View();
            }
            var productGroup = productManagement.GetProductGroupById(productGroupCode);
            productManagement.DeleteProductGroup(productGroup);
            return RedirectToAction(nameof(Index));
        }
    }
}