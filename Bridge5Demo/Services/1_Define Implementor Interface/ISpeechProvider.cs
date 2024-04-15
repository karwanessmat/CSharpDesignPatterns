namespace Bridge5Demo.Services.Implementor
{

    // Implementation
    public interface ISpeechProvider
    {
        void TextToSpeechStandard();
        void SpeechToTextStandard();
        void SpeechToTextAI();
        void TextToSpeechNeural();
    }
}
