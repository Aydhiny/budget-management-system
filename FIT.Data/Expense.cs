using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.Data
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public BudgetCategory Category { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Category.CategoryName;
        }
    }
}
