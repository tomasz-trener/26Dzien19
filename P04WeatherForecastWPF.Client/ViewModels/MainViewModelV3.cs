using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
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

    // dodalismy WeatherViewModel ktory bindujemy z widokiem 
    public partial class MainViewModelV3 : ObservableObject, IMainViewModel
    {
        private readonly IAccuWeatherService _accuWeatherService;
        private readonly IServiceProvider _serviceProvider;

        [ObservableProperty]
        private ObservableCollection<City> cities;

        //[ObservableProperty]
        //private Weather weather;
        [ObservableProperty]
        private WeatherViewModel weatherVM;

        [ObservableProperty]
        private string cityName = "warszawa";

        [ObservableProperty]
        private City selectedCity;

        partial void OnSelectedCityChanged(City value) // dodatkowy "set" dla SelectedCity, który wywołuje się po zmianie wartości
        {
            // Aktualizuj inne powiązane właściwości
            loadWeather();
        }

        public MainViewModelV3(IAccuWeatherService accuWeatherService, IServiceProvider serviceProvider)
        {
         
            _accuWeatherService = accuWeatherService;
            _serviceProvider = serviceProvider;
            Cities = new ObservableCollection<City>();
        }

        // atrybut relayCommand powoduje ze od razu moge zbindowac te metode z kontrolka w xaml 
        [RelayCommand]
        public async void LoadCities()
        {
            var cities = await _accuWeatherService.GetLocations(cityName);
            Cities = new ObservableCollection<City>(cities);

            //Cities.Clear();
            //foreach (var city in cities)
            //    Cities.Add(city); // ta metoda aktualizuje liste i powiadamia interfejsy
 
        }

        private async void loadWeather()
        {
            if (SelectedCity != null)
            {
                var weather = await _accuWeatherService.GetCurentConditions(SelectedCity.Key);
                WeatherVM = new WeatherViewModel(weather, cityName); // wystarczyło zmienić z małej literki na duża!! :)
               
                //OnPropertyChanged(nameof(CurrentTemperature));
            }
        }

        [RelayCommand]
        private void OpenWindow()
        {
            string parametrDoPrzekazania = "Twój parametr";

            // Pobranie instancji viewmodelu z DI
            var secondWindowViewModel = _serviceProvider.GetService<SecondWindowViewModel>();

            // przekazanie dowolngo parametru 
            secondWindowViewModel.Parametr = parametrDoPrzekazania;
            // Pobranie instancji widoku z DI
            var window = _serviceProvider.GetService<SecondWindow>();

            // Ustawienie DataContext nowego okna
            window.DataContext = secondWindowViewModel;

            window.Show();
        }

        [RelayCommand]
        public void OpenShowWindow()
        {
            ShopProductsView shopProductsView =  _serviceProvider.GetService<ShopProductsView>();
            ProductsViewModel productsViewModel = _serviceProvider.GetService<ProductsViewModel>();

            shopProductsView.Show();
            productsViewModel.GetProductsAsync();
        }


    }
}
