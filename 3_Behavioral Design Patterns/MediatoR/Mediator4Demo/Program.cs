using Mediator4Demo._02_CreateConcreteMediator;
using Mediator4Demo._04_CreateConcreteComponents;

var mediator = new ConcreteMediator();

//var c1 = new Colleague1();
//var c2 = new Colleague2();

//mediator.Register(c1);
//mediator.Register(c2);

Colleague1? c1 = mediator.CreateColleague<Colleague1>();
Colleague2? c2 = mediator.CreateColleague<Colleague2>();

c1.SendTo("Hello, World! (from c1)");
c2.SendTo("hi, there! (from c2)");
