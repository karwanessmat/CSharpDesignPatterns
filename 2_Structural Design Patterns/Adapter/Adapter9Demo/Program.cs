using Adapter9Demo;
using Adapter9Demo.Step1___Interface;
using Adapter9Demo.step2_Adapter_Class;
using Adapter9Demo.Step3_Client___Adaptee;

EuropeanPlug europeanPlug = new EuropeanPlug();
IAmericanSocket adapter = new PlugAdapter(europeanPlug);
AmericanAppliance appliance = new AmericanAppliance(adapter);

appliance.PlugIn(); // This should output "Getting 220V from European Plug through adapter"