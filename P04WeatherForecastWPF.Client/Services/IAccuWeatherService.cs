using P04WeatherForecastWPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.Services
{
    public interface IAccuWeatherService
    {
        Task<City[]> GetLocations(string locationName);
        Task<Weather> GetCurentConditions(string cityKey);

         
    }
}
