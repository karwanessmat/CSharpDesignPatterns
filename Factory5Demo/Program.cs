using Factory5Demo.Step1_Product_Interface;
using Factory5Demo.Step3_Creator;
using Factory5Demo.step4_Concrete_Creator;

ICreditUnionFactory factory = new  SavingsAcctFactory() as ICreditUnionFactory;
SavingsAccount citiAcct = factory.GetSavingsAccount("CITI-321");
SavingsAccount nationalAcct = factory.GetSavingsAccount("NATIONAL-987");;

Console.WriteLine($"My citi balance is {citiAcct.Balance} and national balance is {nationalAcct.Balance}");