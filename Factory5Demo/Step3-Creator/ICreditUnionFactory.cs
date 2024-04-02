using Factory5Demo.Step1_Product;

namespace Factory5Demo.Step3_Creator
{
    /// <summary>
    /// Creator (Interface or Abstract class)
    /// </summary>
    public interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
