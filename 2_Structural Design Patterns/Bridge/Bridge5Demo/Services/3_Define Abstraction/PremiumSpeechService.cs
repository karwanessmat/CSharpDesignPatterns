using Bridge5Demo.Services._1_Define_Implementor_Interface;
using Bridge5Demo.Services.Refined_Abstraction;

namespace Bridge5Demo.Services._3_Define_Abstraction
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
