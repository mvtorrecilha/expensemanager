using ExpenseManager.Application.Interfaces;
using ExpenseManager.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseManager.Web.AutoMapper;

namespace ExpenseManager.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryApp;

        public CategoryController(ICategoryAppService categoryApp)
        {
            _categoryApp = categoryApp;
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var allcategories = _categoryApp.GetAll().To<IEnumerable<CategoryViewModel>>();
            return Json(allcategories, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetbyID(Guid id)
        {
            var categoryFound = _categoryApp.GetById(id).To<CategoryViewModel>();
            return Json(categoryFound, JsonRequestBehavior.AllowGet);
        }
    }
}