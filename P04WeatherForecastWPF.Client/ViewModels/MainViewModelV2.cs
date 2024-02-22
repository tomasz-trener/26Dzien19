using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastWPF.Client.Commands;
using P04WeatherForecastWPF.Client.Models;
using P04WeatherForecastWPF.Client.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P04WeatherForecastWPF.Client.ViewModels
{

    // ObservableObject - z biblioteki CommunityToolkit
    // 1) dodaje obsluge kolekcji obserowowalnych (ObservableCollection)
    // 2) od razu implementuje intrefejs inotifyPropertyChanged (nie musze korzystać z base viewmodel)
    // 3) mamy mozliowosc uproszczenia deklaracji pól i właściwości poprzez uzycie ObservableProperty ale uwaga - ono wymaga tego aby klasa była partial 
    // 4) ma zaimplementowana obsluge zdarzen [RelayCommand] 
    public partial class MainViewModelV2 : ObservableObject, IMainViewModel
    {
        private string _cityName = "warszawa";
        // private City[] _cities;
        private City _selectedCity;
        //private Weather _weather;

        private readonly IAccuWeatherService _accuWeatherService;

        public string CityName
        {
            get
            {
                return _cityName;
            }
            set
            {
                _cityName = value;
            }
        }

        public ObservableCollection<City> Cities {get; set;}

        [ObservableProperty]
        private Weather weather;

        // tego nie potrzebuje wykorzystuje ObservableCollection, które automatycznie powiadamia inrefejsy gdy aktualizuje listę 
        //public City[] Cities
        //{
        //    get { return _cities; }
        //    set {
        //        _cities = value;
        //        OnPropertyChanged();
        //    }
        //}

        public City SelectedCity
        { 
            get => _selectedCity; 
            set
            {
                _selectedCity = value;
                OnPropertyChanged();
                loadWeather();
            } 
        }

        // tego teraz nie potrzebuje bo jest ono automatycznie generowane przez atrybut [ObservableProperty]
        //public Weather Weather
        //{
        //    get => _weather;
        //    set
        //    {
        //        _weather = value;
        //        OnPropertyChanged();
        //        //OnPropertyChanged("CurrentTemperature");
        //        OnPropertyChanged(nameof(CurrentTemperature));
        //    }
        //}
 
        public string CurrentTemperature => Weather?.Temperature.Metric.Value.ToString();

        //public ICommand LoadCitiesCommand { get; }

        public MainViewModelV2(IAccuWeatherService accuWeatherService)
        {
          //  LoadCitiesCommand = new RelayCommand(x => loadCities());
            _accuWeatherService = accuWeatherService; 
            Cities = new ObservableCollection<City>();
        }

        // atrybut relayCommand powoduje ze od razu moge zbindowac te metode z kontrolka w xaml 
        [RelayCommand]
        public async void LoadCities()
        {
            var cities = await _accuWeatherService.GetLocations(_cityName);
           
            Cities.Clear();
            foreach (var city in cities)
                Cities.Add(city);

            // alternatywnie mozmemy tak odświeżać liste miast 
            //Cities = new ObservableCollection<City>(cities);
            //OnPropertyChanged("Cities");
        }

        private async void loadWeather()
        {
            if (SelectedCity != null)
            {
                Weather = await _accuWeatherService.GetCurentConditions(SelectedCity.Key);
                OnPropertyChanged(nameof(CurrentTemperature));
                // ponieważ teraz obsluga Weather jest przy pomocy [ObservableProperty]
                // to musimy inne zależne pola odświeżać ręcznie 
            }
        }
    }
}
