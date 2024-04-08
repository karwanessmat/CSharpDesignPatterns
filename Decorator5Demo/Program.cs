using Decorator5Demo._1.Component;
using Decorator5Demo._2.ConcreteComponents;
using Decorator5Demo._4.ConcreteDecorators;


// sending by Service 1;
INotifier service1 = new Service1NotifierDecorator(new EmailNotifier());
service1.Send("Dear employee today you get a salary");

service1 = new Service1NotifierDecorator(new SmsNotifier());
service1.Send("Dear employee today you get a salary");

Console.WriteLine();
Console.WriteLine("Sending message by email and sms");
service1 = new Service1NotifierDecorator(new EmailAndSmsNotifiers(new EmailNotifier()));
service1.Send("Dear employee today you get a salary");

