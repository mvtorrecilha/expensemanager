using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Domain.Entities.Entities
{
    public class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public Category Category { get; set; }
    }
}
