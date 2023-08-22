using System.Windows.Input;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand ShipmentCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductVM();
        private void Transaction(object obj) => CurrentView = new FinancesVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            TransactionsCommand = new RelayCommand(Transaction);
            ShipmentCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);

            // Pagina inicial
            CurrentView = new HomeVM();
        }
    }
}
