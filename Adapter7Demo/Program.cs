using Adapter7Demo;
using Adapter7Demo.Step1___Interface;
using Adapter7Demo.step2_Adapter_Class;
using Adapter7Demo.Step3_Client___Adaptee;

Adaptee adaptee = new Adaptee();
IAdapter adapter = new SpecificAdapter(adaptee);
Client   client = new Client(adapter);
//Client client = new Client(new SpecificAdapter(new Adaptee()));
client.DoWork();