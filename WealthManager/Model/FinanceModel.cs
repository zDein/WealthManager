using System;
using WealthManager.Model.Enums;

namespace WeathManager.Model
{
    public class FinanceModel
    {

        // Informações da finança
        public Guid Id { get; set; }
        public FinanceTypes FinanceType { get; set; }
        public ExpenseTypes ExpenseType { get; set; }
        public IncomeTypes IncomeType { get; set; }
        public string Description { get; set; } = string.Empty;
        public object DateAdded { get; set; } = DateTime.Now.ToShortDateString();
        public decimal Amount { get; set; }
    }
}
