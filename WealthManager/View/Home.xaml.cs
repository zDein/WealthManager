using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WealthManager.View;
using WealthManager.ViewModel;
using WeathManager.Model;

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Home.xaml
    /// </summary>
    public partial class Home : UserControl
    { 
        public static Home homeInstance;
        public TextBlock homeNameTB, totalBalance;

        public Home()
        {
            InitializeComponent();
            homeInstance = this;
            homeNameTB = HomeUserName;
            TotalBalance = totalBalanceHome;
            SetUserInfo();
        }

        public void SetUserInfo()
        {
            if(String.IsNullOrEmpty(UserModel._name))
            {
                UserModel._name = "User";
                MainWindow.instance.UserNameMW.Text = "Hello, User!";
                MainWindow.instance.UserBalance.Text = "$0,00";
            }
            homeNameTB.Text = String.Format("Welcome back, {0}!", UserModel._name);
            TotalBalance.Text = String.Format("{0}", UserModel.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
