using P04WeatherForecastWPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public class WeatherViewModel
    {
        public WeatherViewModel(Weather weather, string cityName)
        {
            CurrentTemperature = weather.Temperature.Metric.Value;
            CityName = cityName;
            HasPrecipitation = weather.HasPrecipitation;
        }

        public double CurrentTemperature { get; set; }
        public string CityName { get; set; }
        public bool HasPrecipitation { get; set; }
    }
}
