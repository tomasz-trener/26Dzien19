using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using P06Shop.Shared.Confguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.Services
{
    // wymaga zainstalowania: Microsoft.CognitiveServices.Speech
    public class SpeechService : ISpeechService
    {
        public readonly SpeechSettings _speechSettings;

        public SpeechService(SpeechSettings speechSettings)
        {
            _speechSettings = speechSettings;
        }

        public async Task<string> RecognizeAsync()
        {
            var config = SpeechConfig.FromSubscription(_speechSettings.SpeechApiKey, _speechSettings.SpeechApiRegion);
            return await RecognizeFromMicrophoneAsync(config);
        }

        private async Task<string> RecognizeFromMicrophoneAsync(SpeechConfig speechConfig)
        {
            AudioConfig audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            SpeechRecognizer recognizer = new SpeechRecognizer(speechConfig, "pl-PL", audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }
    }
}
