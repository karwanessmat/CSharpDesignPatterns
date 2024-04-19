// See https://aka.ms/new-console-template for more information

using Facade7Demo;

Console.WriteLine("Hello, World!");

var collegeLoan = new CollegeLoan();

var student = new Student("Karwan");
var isEligible = collegeLoan.IsEligible(student, 200);
Console.WriteLine($"{student.Name} has been {(isEligible?"approved":"rejected")}");

