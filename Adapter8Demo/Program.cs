using Adapter8Demo;

ITarget target = new Adapter();
Client client = new Client(target);
client.DoWork();