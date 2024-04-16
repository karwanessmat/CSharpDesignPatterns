using Bridge5Demo.Services._1_Define_Implementor_Interface;

namespace Bridge5Demo.Services._2_Create_Concrete_Implementations
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
