namespace Facade7Demo;

public class Loan
{
    public bool HasNoBadLoans(Student stud)
    {

        Console.WriteLine($"Verify loan for {stud.Name}");
        return true;
    }
}