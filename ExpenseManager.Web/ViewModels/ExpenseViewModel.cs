using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseManager.Web.ViewModels
{
    public class ExpenseViewModel
    {
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}