using ExpenseManager.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Application.Interfaces
{
    public interface IExpenseAppService : IAppServiceBase<Expense>
    {
    }
}
