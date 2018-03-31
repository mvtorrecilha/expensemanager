using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ExpenseManager.Web.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        [ScriptIgnore]
        [JsonIgnore]
        public IEnumerable<ExpenseViewModel> Expenses { get; set; }
    }
}