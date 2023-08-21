using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WealthManager.ViewModel;
using System.Windows.Media.Imaging;
using WealthManager.Model.Enums;

namespace WeathManager.Model
{
    public class FinanceModel
    {

        // Informações da finança
        public object UserId;
        public FinanceTypes FinanceType { get; set; }
        public ExpenseTypes ExpenseType { get; set; }
        public IncomeTypes IncomeType { get; set; }
        public string Description { get; set; } = string.Empty;
        public object DateAdded { get; set; } = DateTime.Now.ToShortDateString();
        public decimal Amount { get; set; }
    }
}
