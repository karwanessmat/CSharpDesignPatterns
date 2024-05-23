

using Facade2Demo;
using System;
using Facade2Demo.Subsystem_Classes;

// Facade
var mortgage = new Mortgage();

// Evaluate mortgage eligibility for customer
var customer = new Customer("Ann McKinsey");
bool eligible = mortgage.IsEligible(customer, 125000);

Console.WriteLine("\n" + customer.Name +
                  " has been " + (eligible ? "Approved" : "Rejected"));

// Wait for user
Console.ReadKey();