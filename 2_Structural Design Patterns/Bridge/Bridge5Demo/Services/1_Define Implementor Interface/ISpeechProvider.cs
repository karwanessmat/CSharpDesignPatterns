namespace Bridge5Demo.Services._1_Define_Implementor_Interface;

// Implementation
public interface ISpeechProvider
{
    void TextToSpeechStandard();
    void SpeechToTextStandard();
    void SpeechToTextAI();
    void TextToSpeechNeural();
}