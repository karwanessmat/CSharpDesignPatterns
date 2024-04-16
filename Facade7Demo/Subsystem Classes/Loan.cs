namespace Facade7Demo.Subsystem_Classes;

public class Loan
{
    public bool HasNoBadLoans(Student stud)
    {

        Console.WriteLine($"Verify loan for {stud.Name}");
        return true;
    }
}