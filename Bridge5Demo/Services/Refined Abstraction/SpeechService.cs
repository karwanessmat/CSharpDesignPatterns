using Bridge5Demo.Services._1_Define_Implementor_Interface;

namespace Bridge5Demo.Services.Refined_Abstraction
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
