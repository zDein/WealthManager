using WeathManager.Model;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class CustomerVM : ViewModelBase
    {
        private readonly PageModel _pageModel;

        public CustomerVM()
        {
            _pageModel = new PageModel();
        }

        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }
        }

    }
}
