using Adapter9Demo;
using Adapter9Demo.Step1___Interface;
using Adapter9Demo.step2_Adapter_Class;
using Adapter9Demo.Step3_Client___Adaptee;

var europeanPlug = new EuropeanPlug();
IAmericanSocket adapter = new PlugAdapter(europeanPlug);
var appliance = new AmericanAppliance(adapter);

appliance.PlugIn(); // This should output "Getting 220V from European Plug through adapter"