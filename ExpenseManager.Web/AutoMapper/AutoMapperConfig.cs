using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ExpenseManager.Web.ViewModels;
using ExpenseManager.Domain.Entities.Entities;

namespace ExpenseManager.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void ConfigureMapper()
        {
            Mapper.Initialize(cfg =>
            {
                #region  Entity To MVC ViewModel

                cfg.CreateMap<Category, CategoryViewModel>();
                cfg.CreateMap<Expense, ExpenseViewModel>();

                #endregion

                #region MVC ViewModel To Entity

                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<ExpenseViewModel, Expense>();

                #endregion
            });
        }
    }
}