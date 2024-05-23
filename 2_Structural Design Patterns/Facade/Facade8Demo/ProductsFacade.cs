using Facade8Demo.Subsystem_Classes;

namespace Facade8Demo;

internal class ProductsFacade
{
    private readonly AccountCategoryService _accountCategoryService = new();
    private readonly AccountDataService _accountDataService = new();
    private readonly ProductsDataService _productDataService = new();

    public List<Product> GetProductListForAccount(string name)
    {
        // find account Id
        int accountId = _accountDataService
            .GetAccounts()// accounts
            .Where(a => a.Name == name)
            .Select(a => a.Id)
            .FirstOrDefault();

        if (accountId == default)
            return [];

        // find type of account category
        AccountCategory accountCategory = _accountCategoryService.GetCategory(accountId);

        return _productDataService.GetProductsForCategory((int)accountCategory);
    }
}