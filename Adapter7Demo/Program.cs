using Adapter7Demo;

Adaptee adaptee = new Adaptee();
IAdapter adapter = new SpecificAdapter(adaptee);
Client   client = new Client(adapter);

client.DoWork();