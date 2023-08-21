using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WealthManager.View
{
    /// <summary>
    /// Interação lógica para Customers.xaml
    /// </summary>
    public partial class Customers : UserControl
    {
        public static Customers customersInstance;
        public int maxLenght = 8;
        public TextBox FirstName, Bio, Job, Phone, Email;
        private BitmapImage selectedImage = null;


        public Customers()
        {
            InitializeComponent();
            customersInstance = this;

            FirstName = firstName_tb;
            Bio = userBio_tb;
            Job = userJob_tb;
            Phone = phone_tb;
            Email = userEmail_tb;

            FirstName.Text = UserModel._name;
            Bio.Text = UserModel._bio;
            Job.Text = UserModel._jobs;
            Phone.Text = UserModel._phone;
            Email.Text = UserModel._email;

            string savedImagePath = UserModel.SelectedImagePath;

            if (!string.IsNullOrEmpty(savedImagePath))
            {
                BitmapImage savedImage = new BitmapImage(new Uri(savedImagePath));
                UserSettingsPhoto_btn.Background = new ImageBrush(savedImage);
            }
        }

        private void UserSettingsSavebtn_Click(object sender, RoutedEventArgs e)
        {
            UserModel._name = firstName_tb.Text;
            UserModel._phone = phone_tb.Text;
            UserModel._jobs = userJob_tb.Text;
            UserModel._email = userEmail_tb.Text;
            UserModel.Balance = 1801;
            UserModel._bio = userBio_tb.Text;

            string formattedText = firstName_tb.Text.Length > maxLenght ? firstName_tb.Text.Substring(0, maxLenght) : firstName_tb.Text;
            MainWindow.instance.Tb1.Text = String.Format("Hello, {0}!", formattedText);
            MainWindow.instance.userBalanceTb.Text = String.Format("{0}", UserModel.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
        }

        private void UserSettingsPhoto_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            openDialog.FilterIndex = 1;

            if (openDialog.ShowDialog() == true)
            {
                string imagePath = openDialog.FileName;

                // Save the image path in the application settings
                UserModel.SelectedImagePath = imagePath;

                // Load the selected image
                BitmapImage imageSource = new BitmapImage(new Uri(imagePath));
                imagePicture.ImageSource = imageSource;

                // Set the background of the button to the selected image
                Button button = (Button)sender;
                button.Background = new ImageBrush(imageSource);
                MainWindow.instance.MainButtonBackground.Background = new ImageBrush(imageSource);
            }
        }
    }
}
