using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WeathManager.Model;

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Finances.xaml
    /// </summary>
    public partial class Finances : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public Finances()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var insertPage = new InsertPage();
            insertPage.ShowDialog();
        }

        private void deleteInfoDG_Click(object sender, RoutedEventArgs e)
        {
            string id = (((Button)sender).DataContext as FinanceModel).Id.ToString();
            for (int i = 0; i < UserModel.Finance.Count; i++)
            {
                FinanceModel finance = UserModel.Finance[i];
                if (finance.Id.ToString() == id)
                {
                    if(finance.FinanceType == Model.Enums.FinanceTypes.Expense)
                    {
                        UserModel.Balance += (double) UserModel.Finance[i].Amount;
                        UserModel.TotalExpenses -= UserModel.Finance[i].Amount;
                    }
                    else if(finance.FinanceType == Model.Enums.FinanceTypes.Income)
                    {
                        UserModel.Balance -= (double) UserModel.Finance[i].Amount;
                        UserModel.TotalRevenue -= UserModel.Finance[i].Amount;
                    }
                    UserModel.Finance.RemoveAt(i);
                }
            }
        }

        private void updateInfoDG_Click(object sender, RoutedEventArgs e)
        {
            string id = (((Button) sender).DataContext as FinanceModel).Id.ToString();
            var updatePage = new UpdatePage(id);
            updatePage.ShowDialog();
        }
    }
}
