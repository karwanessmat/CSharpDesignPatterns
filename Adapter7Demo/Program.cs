using Adapter7Demo;

Adaptee adaptee = new Adaptee();
IAdapter adapter = new SpecificAdapter(adaptee);
Client   client = new Client(adapter);
//Client client = new Client(new SpecificAdapter(new Adaptee()));
client.DoWork();