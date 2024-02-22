

using P04SpeechRecognition;

var speechService = new SpeechService();

try
{
    Console.WriteLine("Start...");
    var text = await speechService.RecognizeAsync();
    Console.WriteLine(text);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}