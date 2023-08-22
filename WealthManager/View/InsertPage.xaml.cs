using System;
using System.Globalization;
using System.Windows;
using WealthManager.Model.Enums;
using WealthManager.ViewModel;
using WeathManager.Model;

namespace WealthManager.View
{
    /// <summary>
    /// Lógica interna para InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        public Guid Guid { get; set; }

        public InsertPage()
        {
            InitializeComponent();
        }


        private void cancelInsertFinance_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveInsertFinance_Click(object sender, RoutedEventArgs e)
        {
            Guid = Guid.NewGuid();
            try
            {
                var finance = new FinanceModel();
                finance.Id = Guid;
                finance.Description = addDescription.Text;
                finance.FinanceType = (FinanceTypes)typeFinanceComboBox.SelectedIndex;
                finance.Amount = decimal.Parse(addAmount.Text);
                if (finance.FinanceType == FinanceTypes.Income)
                {
                    UserModel.Balance += (double)finance.Amount;
                }
                else if (finance.FinanceType == FinanceTypes.Expense)
                {
                    UserModel.Balance -= (double)finance.Amount;
                }
                UserModel.Finance.Add(finance);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            MainWindow.instance.UserBalance.Text = String.Format("{0}", UserModel.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            Close();
        }
    }
}
