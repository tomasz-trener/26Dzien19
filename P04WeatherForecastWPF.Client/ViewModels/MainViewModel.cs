using P04WeatherForecastWPF.Client.Commands;
using P04WeatherForecastWPF.Client.Models;
using P04WeatherForecastWPF.Client.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private string _cityName = "warszawa";
        private City[] _cities;
        private City _selectedCity;
        private Weather _weather;

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

        public City[] Cities
        {
            get { return _cities; }
            set {
                _cities = value;
                OnPropertyChanged();
            }
        }

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

        public Weather Weather
        {
            get => _weather;
            set
            {
                _weather = value;
                OnPropertyChanged();
                //OnPropertyChanged("CurrentTemperature");
                OnPropertyChanged(nameof(CurrentTemperature));
            }
        }
 
        public string CurrentTemperature => Weather?.Temperature.Metric.Value.ToString();

        public ICommand LoadCitiesCommand { get; }

        public MainViewModel(IAccuWeatherService accuWeatherService)
        {
            LoadCitiesCommand = new RelayCommand(x => loadCities());
            _accuWeatherService = accuWeatherService;
        }

        private async void loadCities()
        {
            Cities = await _accuWeatherService.GetLocations(_cityName);
            //OnPropertyChanged("Cities");
        }

        private async void loadWeather()
        {
            if (SelectedCity != null)
            {
                Weather = await _accuWeatherService.GetCurentConditions(SelectedCity.Key);
            }
        }
    }
}
