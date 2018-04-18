using RJ.Tokoku.DataLayer.Master;
using RJ.Tokoku.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RJ.Tokoku.Controllers.Master
{
    public class ColorDimController : Controller
    {
        private DimensionManagement dimensionManagement = new DimensionManagement();
        // GET: ColorDim
        public ActionResult Index() => View(dimensionManagement.GetAllColorDim());

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ColorDim colorDim)
        {
            try
            {
                dimensionManagement.CreateColorDim(colorDim);
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
            return View(colorDim);
        }

        public ActionResult Edit(string colorDimCode)
        {
            if (!String.IsNullOrEmpty(colorDimCode))
            {
                var colorObj = dimensionManagement.GetColorDimById(colorDimCode);
                return View(colorObj);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(ColorDim colorDim)
        {
            try
            {
                dimensionManagement.EditColorDim(colorDim);
                return RedirectToAction(nameof(Index));
            }
            catch(DbEntityValidationException ex)
            {
                foreach (var entityError in ex.EntityValidationErrors)
                {
                    foreach(var propertyError in entityError.ValidationErrors)
                    {
                        ModelState.AddModelError(propertyError.PropertyName, propertyError.ErrorMessage);
                    }
                }
            }
            return View(colorDim);
        }
    }
}