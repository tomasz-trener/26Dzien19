using P04WeatherForecastWPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.Services
{
    internal class FakeAccuWeatherService : IAccuWeatherService
    {
        public async Task<Weather> GetCurentConditions(string cityKey)
        {
            var data = new Weather()
            {
                Temperature = new Temperature()
                {
                    Metric = new Metric()
                    {
                        Value = 20
                    }
                }, 
                HasPrecipitation = true
            };

            return data;
        }

        public async Task<City[]> GetLocations(string locationName)
        {
            var data=new City[]
            {
                 new City(){LocalizedName="Warszawa", Country = new Country() { LocalizedName="Poland" } },
                 new City(){LocalizedName="Paris", Country = new Country() { LocalizedName="France" }},
                 new City(){LocalizedName="Berlin", Country = new Country() { LocalizedName="Germany" }},
            };

            return data;
        }
    }
}
