using System.Globalization;
using System;
using System.Windows;
using WealthManager.Model.Enums;
using WeathManager.Model;
using WealthManager.ViewModel;
using System.Collections.ObjectModel;

namespace WealthManager.View
{
    /// <summary>
    /// Lógica interna para UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        string Id;
        double Amount;

        public UpdatePage(string id)
        {
            InitializeComponent();
            Id = id;
        }

        private void updateFinance_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < UserModel.Finance.Count; i++)
            {
                FinanceModel finance = UserModel.Finance[i];
                if(finance.Id.ToString() == Id)
                {
                    Amount = (double) finance.Amount;
                    try
                    {
                        finance.Description = addDescription.Text;
                        finance.FinanceType = (FinanceTypes)typeFinanceComboBoxUpdt.SelectedIndex;
                        finance.IncomeType = (IncomeTypes)typeCategoryExpenseComboBox.SelectedIndex;
                        finance.Amount = decimal.Parse(addAmount.Text);
                        if (finance.Amount != 0)
                        {
                            UserModel.Balance -= Amount;
                        }
                        if (finance.FinanceType == FinanceTypes.Income)
                        {
                            UserModel.Balance += (double)finance.Amount;
                        }
                        else if (finance.FinanceType == FinanceTypes.Expense)
                        {
                            UserModel.Balance -= (double)finance.Amount;
                        }
                        UserModel.Finance.Insert(i, finance);
                        UserModel.Finance.RemoveAt(i+1);
                        FinancesVM.Instance.FinanceList[i] = finance;
                    }
                    catch (System.FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                        Close();
                    }
                    MessageBox.Show($"Sucess: {finance.Id}\n{finance.Amount}");
                    MainWindow.instance.UserBalance.Text = String.Format("{0}", UserModel.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                }
                break;
            }
            Close();
        }

        private void cancelUpdateFinance_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
