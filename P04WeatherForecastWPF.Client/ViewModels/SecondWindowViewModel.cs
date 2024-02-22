using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public class SecondWindowViewModel : ObservableObject, IMainViewModel
    {
        private string _parametr;

        public string Parametr
        {
            get => _parametr;
            set => SetProperty(ref _parametr, value);
        }

        // Konstruktor, który przyjmuje parametr
        public SecondWindowViewModel()
        {
            
        }
    }
}
