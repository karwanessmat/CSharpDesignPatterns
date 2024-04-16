namespace Facade8Demo.Subsystem_Classes;

internal class AccountCategoryService
{
    private readonly Dictionary<int, AccountCategory> _accountCategories = new()
    {
        { 1, AccountCategory.Buyer },
        { 2, AccountCategory.Buyer },
        { 3, AccountCategory.Reseller },
        { 4, AccountCategory.Reseller },
        { 5, AccountCategory.Buyer}
    };

    /// <summary>
    /// return account category
    /// </summary>
    /// <param name="accountId"></param>
    /// <returns></returns>
    public AccountCategory GetCategory(int accountId)
    {
        return _accountCategories[accountId];
    }
}