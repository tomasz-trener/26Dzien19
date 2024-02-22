using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.Services
{
    public interface ISpeechService
    {
        Task<string> RecognizeAsync();
    }
}
