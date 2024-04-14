// Open a new account
using State2Demo._3_ContextClass;
using System;

Account account = new Account("Jim Johnson");
// Apply financial transactions
account.Deposit(500.0);
account.Deposit(300.0);
account.Deposit(550.0);
account.PayInterest();
account.Withdraw(2000.00);
account.Withdraw(1100.00);
// Wait for user
Console.ReadKey();