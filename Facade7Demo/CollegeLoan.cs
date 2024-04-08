namespace Facade7Demo;

public class CollegeLoan
{
    private readonly Bank _bank = new();
    private readonly Loan _loan = new();
    private readonly Credit _credit = new();

    public bool IsEligible(Student stud, int amount)
    {
        Console.WriteLine($"{stud.Name} applies for {amount:C} loan");
        var eligible = true;

        // verify creditworthyness of appliction
        if (!_bank.HasSufficientSavings(stud,amount))
        {
            eligible = false;
        }
        else if(! _loan.HasNoBadLoans(stud))
        {
            eligible = false;
        } else if (!_credit.HasGoodCredit(stud))
        {
            eligible = false;
        }

        return eligible;
    }
}