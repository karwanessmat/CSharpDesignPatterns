using Bridge5Demo.Services.Implementor;

namespace Bridge5Demo.Services.Concrete_Implementation
{
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
}
