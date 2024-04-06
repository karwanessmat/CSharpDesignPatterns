using Singleton9Demo;

var board11 = Board.GetInstance("Karwan");
board11.Execute("Program1");

Console.WriteLine();

var board22 = Board.GetInstance("Lewan");
board22.Execute("Program2"); // it is always executing first board1 because checking _instance was created board1 and never created another one

Console.WriteLine();
Console.WriteLine();

Board board1 = null;
Board board2 = null;
Board board3 = null;

Task task1 = Task.Factory.StartNew(() =>
{
    //firstPrinterObject = InitializePrinterObjectAndAddDocument("First", "First-Document");
    board1 = Board.GetInstance("Galileo");
    Console.WriteLine(board1.BoardName);
});
Task task2 = Task.Factory.StartNew(() =>
{
    //secondPrinterObject = InitializePrinterObjectAndAddDocument("Second", "Second-Document");
    board2 = Board.GetInstance("DaVinci");
    Console.WriteLine(board2.BoardName);

});
Task task3 = Task.Factory.StartNew(() =>
{
    //thirdPrinterObject = InitializePrinterObjectAndAddDocument("Third", "Third-Document");
    board3 = Board.GetInstance("Copernico");
    Console.WriteLine(board3.BoardName);

});


Task.WaitAll(task1, task2, task3); ;
Console.WriteLine("All threads complete");
Console.WriteLine("Are these First Printer Object And Second Printer Object Same - {0} ", board1.Equals(board2) ? "Yes" : "No");
Console.WriteLine("Are these First Printer Object And Third Printer Object Same - {0} ", board1.Equals(board3) ? "Yes" : "No");
Console.WriteLine("Are these Second Printer Object And Third Printer Object Same - {0} ", board2.Equals(board3) ? "Yes" : "No");

