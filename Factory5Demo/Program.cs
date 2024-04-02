using Factory5Demo.Step3_Creator;
using Factory5Demo.step4_ConcreteCreator;

var factory = new  SavingsAcctFactory() as ICreditUnionFactory;
var citiAcct = factory.GetSavingsAccount("CITI-321");
var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");;

Console.WriteLine($"My citi balance is {citiAcct.Balance} and national balance is {nationalAcct.Balance}");