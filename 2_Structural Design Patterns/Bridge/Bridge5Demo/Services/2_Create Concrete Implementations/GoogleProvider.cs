using Bridge5Demo.Services._1_Define_Implementor_Interface;

namespace Bridge5Demo.Services._2_Create_Concrete_Implementations;

public class GoogleProvider : ISpeechProvider
{
    public void SpeechToTextAI()
    {
        Console.WriteLine("Generating Text with AI from Audio");
    }

    public void SpeechToTextStandard()
    {
        Console.WriteLine("Generating Text from Audio");
    }

    public void TextToSpeechNeural()
    {
        Console.WriteLine("Generating Neural Voice from Text");
    }

    public void TextToSpeechStandard()
    {
        Console.WriteLine("Generating Audio from Text");
    }

}