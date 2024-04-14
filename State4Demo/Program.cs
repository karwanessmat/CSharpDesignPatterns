
using State4Demo._2_ImplementConcreteStates;
using State4Demo._3_ContextClass;

var phone = new MobilePhoneContext();

Console.WriteLine("Pressing home button.");
phone.PressHomeButton();

Console.WriteLine("Changing the phone state to unlocked.");
phone.ChangeState(new UnlockedScreenState());

Console.WriteLine("Pressing home button.");
phone.PressHomeButton();

Console.ReadKey();