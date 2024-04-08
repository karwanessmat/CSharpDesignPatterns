﻿namespace Facade8Demo;

internal class ProductsFacade
{
    private readonly AccountCategoryService _accountCategoryService = new();
    private readonly AccountDataService _accountDataService = new();
    private readonly ProductsDataService _productDataService = new();

    public List<Product> GetProductListForAccount(string name)
    {
        // find account Id
        var accountId = _accountDataService
            .GetAccounts()// accounts
            .Where(a => a.Name == name)
            .Select(a => a.Id)
            .FirstOrDefault();

        if (accountId == default)
            return [];

        // find type of account category
        var accountCategory = _accountCategoryService.GetCategory(accountId);

        return _productDataService.GetProductsForCategory((int)accountCategory);
    }
}