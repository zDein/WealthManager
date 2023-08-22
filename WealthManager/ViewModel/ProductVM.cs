using WeathManager.Model;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class ProductVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string ProductAvailabity
        {
            get { return _pageModel.ProductStatus; }
            set { _pageModel.ProductStatus = value; OnPropertyChanged(); }
        }

        public ProductVM()
        {
            _pageModel = new PageModel();
            ProductAvailabity = "Out os stock";
        }
    }
}
