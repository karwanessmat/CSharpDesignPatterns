namespace Facade7Demo.Subsystem_Classes;

public class Credit
{
    public bool HasGoodCredit(Student stud)
    {

        Console.WriteLine($"Verify credit for {stud.Name}");
        return true;
    }
}