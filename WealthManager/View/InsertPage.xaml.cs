using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WealthManager.Model.Enums;
using WeathManager.Model;

namespace WealthManager.View
{
    /// <summary>
    /// Lógica interna para InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {


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
            try
            {
                var finance = new FinanceModel();
                finance.UserId = Guid.NewGuid().ToString();
                finance.Description = addDescription.Text;
                finance.FinanceType = (FinanceTypes) typeFinanceComboBox.SelectedIndex;
                finance.Amount = decimal.Parse(addAmount.Text);
                UserModel.Finance.Add(finance);
            }catch(System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            Close();
        }

        

    }
}
