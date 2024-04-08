using Bridge5Demo.Services.Implementor;

namespace Bridge5Demo.Services.Concrete_Implementation
{
    // Refined Abstraction
    public class AzureProvider : ISpeechProvider
    {
        public void SpeechToTextAI()
        {
            Console.WriteLine("Generating Text with AI from Audio - Azure");
        }

        public void SpeechToTextStandard()
        {
            Console.WriteLine("Generating Text from Audio - Azure");
        }

        public void TextToSpeechNeural()
        {
            Console.WriteLine("Generating Neural Voice from Text - Azure");
        }

        public void TextToSpeechStandard()
        {
            Console.WriteLine("Generating Audio from Text - Azure");
        }
    }

}
