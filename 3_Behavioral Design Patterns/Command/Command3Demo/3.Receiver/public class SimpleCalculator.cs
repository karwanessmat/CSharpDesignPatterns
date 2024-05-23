namespace Command3Demo._3.Receiver;

public class SimpleCalculator(int a, int b)
{
    public int Add()
    {
        return a + b;
    }
    public int Subtract()
    {
        return a - b;
    }
    public int Multiply()
    {
        return a * b;
    }
    public int Divide()
    {
        return a / b;
    }
}