using Bridge5Demo.Services.Abstraction;
using Bridge5Demo.Services;

// PremiumSpeechService has a bridge property to pass others
// <summary>
// it is bridge
// </summary>
// protected ISpeechProvider SpeechProvider = speechProvider;


var service = new PremiumSpeechService(new AzureProvider());
service.SpeechToTextAI();


service = new PremiumSpeechService(new GoogleProvider());
service.TextToSpeechNeural();