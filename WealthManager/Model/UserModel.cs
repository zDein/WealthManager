using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WealthManager.ViewModel;
using System.Windows.Media.Imaging;

namespace WeathManager.Model
{
    public class UserModel : INotifyPropertyChanged
    {
        // Instancia estática da classe para ser usada por todo o programa
        public static UserModel instance;
        
        // Informações básicas do usuário
        public static Guid _id = Guid.NewGuid();
        public static string _name = string.Empty;
        public static string _phone = string.Empty;
        public static string _jobs = string.Empty;
        public static string _email = string.Empty;
        public static string _bio = string.Empty;
        public static double Balance { get; set; }

        // Salva o caminho da imagem selecionada
        public static string? SelectedImagePath { get; set; } = string.Empty;


        public UserModel()
        {
            instance = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
