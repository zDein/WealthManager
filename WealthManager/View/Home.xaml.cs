using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using LiveCharts.SeriesAlgorithms;
using System;
using System.Globalization;
using System.Windows.Controls;
using WeathManager.Model;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using WealthManager.ViewModel;
using LiveChartsCore.SkiaSharpView.Extensions;
using System.Collections.Generic;

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {

        public int countExpenseTypes;
        public static Home homeInstance;
        public TextBlock homeNameTB, totalBalance, totalRevenue, totalExpenses;

        public Home()
        {
            InitializeComponent();
            homeInstance = this;
            homeNameTB = HomeUserName;
            TotalBalance = totalBalanceHome;
            totalExpenses = TotalExpenses;
            totalRevenue = TotalRevenue;
            SetUserInfo();
        }

        

        public void SetUserInfo()
        {
            if (String.IsNullOrEmpty(UserModel._name))
            {
                UserModel._name = "User";
                MainWindow.instance.UserNameMW.Text = "Hello, User!";
                MainWindow.instance.UserBalance.Text = "$0,00";
            }
            totalRevenue.Text = String.Format("{0}", UserModel.TotalRevenue.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))); ;
            totalExpenses.Text = String.Format("{0}", UserModel.TotalExpenses.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))); ;
            homeNameTB.Text = String.Format("Welcome back, {0}!", UserModel._name);
            TotalBalance.Text = String.Format("{0}", UserModel.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            MainWindow.instance.userBalanceTb.Text = TotalBalance.Text;

        }
    }
}
