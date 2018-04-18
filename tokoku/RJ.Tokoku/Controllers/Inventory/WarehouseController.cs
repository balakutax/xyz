using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RJ.Tokoku.DataLayer.InventoryManagement;
using RJ.Tokoku.Inventory;

namespace RJ.Tokoku.Controllers.Inventory
{
    public class WarehouseController : Controller
    {
        private InventoryManagement _inventoryManagement = new InventoryManagement();

        // GET: Warehouse
        public ActionResult Index() => View(_inventoryManagement.GetAllWarehouse());

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Warehouse warehouse)
        {
            try
            {
                _inventoryManagement.CreateWarehouse(warehouse);
                return RedirectToAction(nameof(Index));
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityError in ex.EntityValidationErrors)
                {
                    foreach (var propertyError in entityError.ValidationErrors)
                    {
                        ModelState.AddModelError(propertyError.PropertyName, propertyError.ErrorMessage);
                    }
                }
            }
            return View(warehouse);
        }

        [HttpGet]
        public ActionResult Edit(string warehouseCode)
        {
            if (!String.IsNullOrEmpty(warehouseCode))
            {
                var warehouseObj = _inventoryManagement.GetWarehouseById(warehouseCode);
                return View(warehouseObj);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Warehouse warehouse)
        {
            try
            {
                _inventoryManagement.EditWarehouse(warehouse);
                return RedirectToAction(nameof(Index));
            }
            catch(DbEntityValidationException ex)
            {
                foreach(var entityError in ex.EntityValidationErrors)
                {
                    foreach(var propertyError in entityError.ValidationErrors)
                    {
                        ModelState.AddModelError(propertyError.PropertyName, propertyError.ErrorMessage);
                    }
                }
            }
            return View(warehouse);
        }

        [HttpGet]
        public ActionResult Details(string warehouseCode, bool isDelete = false)
        {
            if (!String.IsNullOrEmpty(warehouseCode))
            {
                if (isDelete)
                {
                    ViewBag.IsDelete = true;
                }
                return View(_inventoryManagement.GetWarehouseById(warehouseCode));
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string warehouseCode)
        {
            if (String.IsNullOrEmpty(warehouseCode))
            {
                return View();
            }
            var warehouse = _inventoryManagement.GetWarehouseById(warehouseCode);
            _inventoryManagement.DeleteWarehouse(warehouse);
            return RedirectToAction(nameof(Index));
        }

    }
}