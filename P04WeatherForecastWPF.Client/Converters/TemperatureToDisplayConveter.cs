using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace P04WeatherForecastWPF.Client.Converters
{
    internal class TemperatureToDisplayConveter : IValueConverter
    {
        // nasz konwerter ma za zadanie dodawać do wartosci temperatury znak °C

        private const string _tempCode = "°C";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int || value is double)
                return $"{value}{_tempCode}";

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string temperatureString = value as string;
            if (temperatureString != null && int.TryParse(temperatureString.Replace(_tempCode, ""), out int temperature))
                return temperature;

            return value;
        }
    }
}
