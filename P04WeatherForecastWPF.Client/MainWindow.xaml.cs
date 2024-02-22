using P04WeatherForecastWPF.Client.Models;
using P04WeatherForecastWPF.Client.Services;
using P04WeatherForecastWPF.Client.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P04WeatherForecastWPF.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow(IMainViewModel viewModel)
        {
            InitializeComponent();

           // MainViewModel mainWindow = new MainViewModel();
            DataContext = viewModel;
         
        }
       
    }
}