using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04SpeechRecognition
{
    internal class SpeechService
    {
        public async Task<string> RecognizeAsync()
        {
            var config = SpeechConfig.FromSubscription("6e1a59bad95140b08706b9882b08f465", "northeurope");
            return await RecognizeFromMicrophoneAsync(config);
        }

        private async Task<string> RecognizeFromMicrophoneAsync(SpeechConfig speechConfig)
        {
            AudioConfig audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            SpeechRecognizer recognizer = new SpeechRecognizer(speechConfig,"pl-PL", audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }
    }
}
