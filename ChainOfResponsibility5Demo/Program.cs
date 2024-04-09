using ChainOfResponsibility5Demo;
using ChainOfResponsibility5Demo.step2_Concrete_Handlers;
using ChainOfResponsibility5Demo.Step3_Set_Up_Client_;

var request =
    new DomainRequest("demo", "123", "domain.com", "12345");

var paymentProcessor = new PaymentsProcessor();
var domainChecker = new DomainChecker();
var accountVerifier = new AccountVerifier();



//first method

accountVerifier
    .SetNext(domainChecker)
    .SetNext(paymentProcessor);

var manager = new DomainManager(accountVerifier);
manager.ProcessDomainRegistration(request);

Console.WriteLine();
//second method the same above process but in different way
//accountVerifier.SetNext(domainChecker);
//domainChecker.SetNext(paymentProcessor);

//var manager2 = new DomainManager(accountVerifier);
//manager2.ProcessDomainRegistration(request);
