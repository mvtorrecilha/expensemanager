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
    public class ExpenseAppService : AppServiceBase<Expense>, IExpenseAppService
    {
        private readonly IExpenseService _expenseService;

        public ExpenseAppService(IExpenseService expenseService)
            : base(expenseService)
        {
            _expenseService = expenseService;
        }
    }
}
