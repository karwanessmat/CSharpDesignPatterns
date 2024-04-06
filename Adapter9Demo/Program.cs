using Adapter9Demo;

EuropeanPlug europeanPlug = new EuropeanPlug();
IAmericanSocket adapter = new PlugAdapter(europeanPlug);
AmericanAppliance appliance = new AmericanAppliance(adapter);

appliance.PlugIn(); // This should output "Getting 220V from European Plug through adapter"