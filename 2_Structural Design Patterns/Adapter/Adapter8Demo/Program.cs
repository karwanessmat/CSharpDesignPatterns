using Adapter8Demo;
using Adapter8Demo.Step1___Interface;
using Adapter8Demo.step2_Adapter_Class;

ITarget target = new Adapter();
Client client = new Client(target);
client.DoWork();