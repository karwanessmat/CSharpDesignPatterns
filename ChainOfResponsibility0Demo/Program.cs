using ChainOfResponsibility0Demo.step2_Concrete_Handlers;

var handler1 = new ConcreteHandler1();
var handler2 = new ConcreteHandler2();

handler1.SetNext(handler2);

handler1.HandleRequest("Condition2"); // This request will be passed to and handled by ConcreteHandler2
