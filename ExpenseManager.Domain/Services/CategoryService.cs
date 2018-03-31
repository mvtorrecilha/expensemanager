using ExpenseManager.Domain.Entities.Entities;
using ExpenseManager.Domain.Interfaces;
using ExpenseManager.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Domain.Services
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
            : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
