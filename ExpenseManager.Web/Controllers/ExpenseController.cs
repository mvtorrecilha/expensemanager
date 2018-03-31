using ExpenseManager.Application.Interfaces;
using ExpenseManager.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ExpenseManager.Web.AutoMapper;
using ExpenseManager.Domain.Entities.Entities;

namespace ExpenseManager.Web.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseAppService _expenseApp;

        public ExpenseController(IExpenseAppService expenseApp)
        {
            _expenseApp = expenseApp;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var allExpenses = _expenseApp.AllIncluding(p=>p.Category).To<IEnumerable<ExpenseViewModel>>();
            return Json(allExpenses, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetbyID(Guid id)
        {
            var expenseFound = _expenseApp.GetById(id).To<ExpenseViewModel>();
            return Json(expenseFound, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllByIdAllIncluding(Guid id)
        {
            var expenseFound = _expenseApp.GetById(id).To<ExpenseViewModel>();
            return Json(expenseFound, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(ExpenseViewModel expense)
        {
            var expenseModel = expense.To<Expense>();
            if (ModelState.IsValid)
            {              
                if(expenseModel.Id != default(Guid))
                    _expenseApp.Update(expenseModel);
                else
                    _expenseApp.Add(expenseModel);
                    
            }

            return Json(expenseModel, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var expenseFound = _expenseApp.GetById(id).To<ExpenseViewModel>();
            if(expenseFound != null)
            {
                var expenseModel = expenseFound.To<Expense>();
                _expenseApp.Remove(expenseModel);
            }
            return Json(expenseFound, JsonRequestBehavior.AllowGet);
        }


    }
}