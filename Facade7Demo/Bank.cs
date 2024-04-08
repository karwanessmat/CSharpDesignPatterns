namespace Facade7Demo;

public class Bank
{
    public bool HasSufficientSavings(Student stud, int amount)
    {

        Console.WriteLine("Verify bank for "+stud.Name);
        return true;
    }
}