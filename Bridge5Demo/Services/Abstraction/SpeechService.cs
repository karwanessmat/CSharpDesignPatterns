using Bridge5Demo.Services.Implementor;

namespace Bridge5Demo.Services.Abstraction
{
    // abstract 
    public class SpeechService(ISpeechProvider speechProvider)
    {
        /// <summary>
        /// it is bridge
        /// </summary>
        protected ISpeechProvider SpeechProvider = speechProvider;

        public void TextToSpeechStandard()
        {
            SpeechProvider.TextToSpeechStandard();
        }
        public void SpeechToTextStandard()
        {
            SpeechProvider.SpeechToTextStandard();
        }
    }
}
