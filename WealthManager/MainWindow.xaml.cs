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
using WealthManager.View;
using WealthManager.ViewModel;
using WeathManager.Model;

namespace WealthManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;
        public TextBlock? Tb1, userBalanceTb;
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            Tb1 = UserNameMW;
            userBalanceTb = UserBalance;

            string savedImagePath = UserModel.SelectedImagePath;
            if (!string.IsNullOrEmpty(savedImagePath))
            {
                BitmapImage savedImage = new BitmapImage(new Uri(savedImagePath));
                MainButtonBackground.Background = new ImageBrush(savedImage);
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
