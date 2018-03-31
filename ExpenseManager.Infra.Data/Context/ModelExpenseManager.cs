using ExpenseManager.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Infra.Data.Context
{
    public class ModelExpenseManager : DbContext
    {
        public ModelExpenseManager()
            : base("name=ModelExpenseManager")
        {
            Database.SetInitializer<DbContext>(new CreateDatabaseIfNotExists<DbContext>());

        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }
    }
}
