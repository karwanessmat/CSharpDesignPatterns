using Decorator5Demo._1.Component;
using Decorator5Demo._2.ConcreteComponents;
using Decorator5Demo._4.ConcreteDecorators;

INotifier emailNotifier= new EmailNotifier();
INotifier smsNotifier = new SmsNotifier();
INotifier emailAndSmsNotifier = new EmailAndSmsNotifiers(emailNotifier);
// sending by Service 1;
INotifier service1 = new Service1NotifierDecorator(emailNotifier);
service1.Send("Dear employee today you get a salary");

service1 = new Service1NotifierDecorator(smsNotifier);
service1.Send("Dear employee today you get a salary");

Console.WriteLine();
Console.WriteLine("Sending message by email and sms");
service1 = new Service1NotifierDecorator(emailAndSmsNotifier);
service1.Send("Dear employee today you get a salary");

