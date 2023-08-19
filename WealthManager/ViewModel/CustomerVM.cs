using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeathManager.Model;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class CustomerVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        private readonly UserModel TheUserModel;
        private Guid _id = Guid.NewGuid();
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _jobs = string.Empty;
        private string _email = string.Empty;
        private string _bio = string.Empty;


        public CustomerVM()
        {
            _pageModel = new PageModel();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static UserModel CreateNewUser()
        {
            return new UserModel();
        }

        public Guid Id { get { return _id; } }

        public string FirstName
        {
            get { return _firstName; }
            set { if (FirstName != null) _firstName = value; NotifyPropertyChanged(); OnPropertyChanged(); }
        }

        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }
        }

    }
}
