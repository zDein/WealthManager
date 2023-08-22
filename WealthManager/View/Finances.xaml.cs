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

        }

        private void updateInfoDG_Click(object sender, RoutedEventArgs e)
        {
            var updatePage = new UpdatePage();
            updatePage.ShowDialog();
        }
    }
}
