using Bridge5Demo.Services.Implementor;

namespace Bridge5Demo.Services.Abstraction
{
    public class PremiumSpeechService(ISpeechProvider serviceProvider)
        : SpeechService(serviceProvider)
    {
        public void TextToSpeechNeural()
        {
            SpeechProvider.TextToSpeechNeural();
        }
        public void SpeechToTextAI()
        {
            SpeechProvider.SpeechToTextAI();
        }
    }
}
