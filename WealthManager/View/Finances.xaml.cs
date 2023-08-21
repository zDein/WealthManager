using System;
using System.Collections.Generic;
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
using WealthManager.Model.Enums;
using WeathManager.Model;

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Finances.xaml
    /// </summary>
    public partial class Finances : UserControl
    {

        public Finances()
        {
            InitializeComponent();

            ShowListFinance();
        }

        public void ShowListFinance()
        {
            foreach (var finance in UserModel.Finance)
            {
                myDataGrid.Items.Add(finance);
            }
            CollectionViewSource.GetDefaultView(UserModel.Finance).Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var insertPage = new InsertPage();
            insertPage.ShowDialog();
        }
    }
}
