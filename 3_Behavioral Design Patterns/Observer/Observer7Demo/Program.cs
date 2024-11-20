using Observer7Demo.Step3_Implement_Concrete_Subject;
using Observer7Demo.Step4_Implement_Concrete_Observers;

var weatherStation = new WeatherStation();

var currentDisplay = new CurrentConditionsDisplay(weatherStation);

weatherStation.Temperature = 70; // All observers are notified
weatherStation.Temperature = 75;