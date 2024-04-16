using Bridge5Demo.Services;
using Bridge5Demo.Services._2_Create_Concrete_Implementations;
using Bridge5Demo.Services._3_Define_Abstraction;

// PremiumSpeechService has a bridge property to pass others
// <summary>
// it is bridge
// </summary>
// protected ISpeechProvider SpeechProvider = speechProvider;


var service = new PremiumSpeechService(new AzureProvider());
service.SpeechToTextAI();


service = new PremiumSpeechService(new GoogleProvider());
service.TextToSpeechNeural();