using P04WeatherForecastWPF.Client.ViewModels;
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
using System.Windows.Shapes;

namespace P04WeatherForecastWPF.Client
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    /// 
    
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _loginViewModel;

        public LoginView(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            _loginViewModel = loginViewModel;
            DataContext = _loginViewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _loginViewModel.Login(PasswordBox.Password);
        }
    }
}
