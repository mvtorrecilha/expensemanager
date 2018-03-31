using ExpenseManager.Application.AppServices;
using ExpenseManager.Application.Interfaces;
using ExpenseManager.Domain.Interfaces;
using ExpenseManager.Domain.Interfaces.Services;
using ExpenseManager.Domain.Services;
using ExpenseManager.Infra.Data.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Infra.CrossCutting.Ioc
{
    public class DependencyMapper : NinjectModule
    {
        public override void Load()
        {
            this.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            this.Bind<ICategoryAppService>().To<CategoryAppService>();
            this.Bind<IExpenseAppService>().To<ExpenseAppService>();

            this.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            this.Bind<ICategoryService>().To<CategoryService>();
            this.Bind<IExpenseService>().To<ExpenseService>();

            this.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            this.Bind<ICategoryRepository>().To<CategoryRepository>();
            this.Bind<IExpenseRepository>().To<ExpenseRepository>();
        }
    }
}
