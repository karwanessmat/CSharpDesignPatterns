using Adapter7Demo;
using Adapter7Demo.Step1___Interface;
using Adapter7Demo.step2_Adapter_Class;
using Adapter7Demo.Step3_Client___Adaptee;

var adaptee = new Adaptee();
IAdapter adapter = new SpecificAdapter(adaptee);
var   client = new Client(adapter);
//Client client = new Client(new SpecificAdapter(new Adaptee()));
client.DoWork();

Console.WriteLine("_______");

IAdapter a = new SpecificAdapter2();
var c = new Client(a);
c.DoWork();

