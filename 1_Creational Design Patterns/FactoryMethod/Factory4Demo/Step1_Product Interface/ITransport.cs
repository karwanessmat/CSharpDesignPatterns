namespace Factory4Demo.Step1_Product_Interface;

/// <summary>
/// 1. Make all products follow the same interface. This interface
/// should declare methods that make sense in every product.
/// </summary>
public interface ITransport
{
    void Deliver();
}