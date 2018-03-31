using ExpenseManager.Application.Interfaces;
using ExpenseManager.Domain.Entities.Entities;
using ExpenseManager.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Application.AppServices
{
    public class CategoryAppService : AppServiceBase<Category>, ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService)
            : base(categoryService)
        {
            _categoryService = categoryService;
        }
    }
}
