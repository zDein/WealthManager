using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeathManager.Model
{
    public class UserModel : INotifyPropertyChanged
    {
        // Instancia estática da classe para ser usada por todo o programa
        public static UserModel instance;

        // Variaveis da propria classe
        public static decimal TotalRevenue = 0;
        public static decimal TotalExpenses = 0;

        // Informações básicas do usuário
        public static Guid _id = Guid.NewGuid();
        public static string _name = string.Empty;
        public static string _phone = string.Empty;
        public static string _jobs = string.Empty;
        public static string _email = string.Empty;
        public static string _bio = string.Empty;
        public static double Balance { get; set; }
        public static ObservableCollection<FinanceModel> Finance { get; set; } = new ObservableCollection<FinanceModel>();
        public static ObservableCollection<decimal> ListAmounts { get; set; } = new ObservableCollection<decimal>();



        // Salva o caminho da imagem selecionada
        public static string? SelectedImagePath { get; set; } = string.Empty;


        public UserModel()
        {
            instance = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
