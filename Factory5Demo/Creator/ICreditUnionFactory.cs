using Factory5Demo.Product;

namespace Factory5Demo.Creator
{
    /// <summary>
    /// Creator (Interface or Abstract class)
    /// </summary>
    public interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
