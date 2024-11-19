using Decorator5Demo._1_Component_Interface;
using Decorator5Demo._2_Create_a_Concrete_Component;
using Decorator5Demo._4_Create_Concrete_Decorator;


// sending by Service 1;
INotifier service1 = new Service1NotifierDecorator(new EmailNotifier());
service1.Send("Dear employee today you get a salary");

service1 = new Service1NotifierDecorator(new SmsNotifier());
service1.Send("Dear employee today you get a salary");




Console.WriteLine("_____________");
Console.WriteLine();
Console.WriteLine("Sending message by  sms");
service1 = new Service1NotifierDecorator(new SmsNotifier());
service1.Send("Dear employee today you get a salary");


Console.WriteLine("_____________");
Console.WriteLine();
Console.WriteLine("Sending message by email");
service1 = new Service1NotifierDecorator(new EmailNotifier());
service1.Send("Dear employee today you get a salary");


