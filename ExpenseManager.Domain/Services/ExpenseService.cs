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
    public class ExpenseService : ServiceBase<Expense>, IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
            : base(expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
    }
}
