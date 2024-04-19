using AbstractFactory5Demo.Step4_Concrete_Factories;
using AbstractFactory5Demo.Step5_Client;

var darkTheme = new Application(new DarkThemeFactory());
darkTheme.Render();