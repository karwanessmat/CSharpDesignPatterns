namespace Facade7Demo.Subsystem_Classes;

public class Bank
{
    public bool HasSufficientSavings(Student stud, int amount)
    {

        Console.WriteLine("Verify bank for "+stud.Name);
        return true;
    }
}