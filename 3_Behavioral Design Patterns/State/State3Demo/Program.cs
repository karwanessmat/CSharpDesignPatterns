

using State3Demo._3_ContextClass;

var atmMachine = new AtmMachine();
Console.WriteLine("Welcome to Design Pattern's Bank");
Console.WriteLine("Current balance is " + atmMachine.CashInMachine);
Console.WriteLine("");

while (true)
{
    Console.WriteLine("\nPlease enter your choice:\n1 - Insert Card\n2 - Eject Card\n3 - Insert Pin\n4 - Request Cash\n5 - Exit");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            atmMachine.InsertCard();
            break;
        case 2:
            atmMachine.EjectCard();
            break;
        case 3:
            Console.WriteLine("\nPlease enter your PIN");
            int pin = Convert.ToInt32(Console.ReadLine());
            atmMachine.InsertPin(pin);
            break;
        case 4:
            Console.WriteLine("\nPlease enter the amount of cash you want to withdraw");
            int cashToWithdraw = Convert.ToInt32(Console.ReadLine());
            atmMachine.RequestCash(cashToWithdraw);
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("\nPlease enter a valid choice");
            break;
    }
}