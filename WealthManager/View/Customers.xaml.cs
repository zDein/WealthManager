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
using WealthManager.ViewModel;

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Customers.xam
    /// </summary>
    public partial class Customers : UserControl
    {
        public MainWindow MainWindowReference { get; set; }
        private CustomerVM UserInfo;
        public Customers()
        {
            UserInfo = new CustomerVM();
            MainWindowReference = new MainWindow();
            InitializeComponent();
        }

        private void UserSettingsSaveInfo_btn_Click(object sender, RoutedEventArgs e)
        {
            UserInfo.FirstName = firstName_tb.Text;
            MainWindowReference.UserNameMW.Text = UserInfo.FirstName.ToString();
        }
    }
}
