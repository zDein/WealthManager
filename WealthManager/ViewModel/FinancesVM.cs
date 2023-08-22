using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WeathManager.Model;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class FinancesVM : ViewModelBase
    {
        public static FinancesVM Instance;
        private readonly PageModel _pageModel;

        public ObservableCollection<FinanceModel> FinanceList { get; set; } = UserModel.Finance;

        public FinancesVM()
        {
            Instance = this;
            _pageModel = new PageModel();
        }
    }
}
