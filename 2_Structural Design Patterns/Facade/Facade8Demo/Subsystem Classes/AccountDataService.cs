namespace Facade8Demo.Subsystem_Classes;

internal class AccountDataService
{
    private readonly List<Account> _accounts =
    [
        new Account(1, "John Smith"),
        new Account(2, "Jane Doe"),
        new Account(3, "Laurence Newport"),
        new Account(4, "David Fisher"),
        new Account(5,"Karwan Othman")
    ];

    public List<Account> GetAccounts()
    {
        return _accounts;
    }
}