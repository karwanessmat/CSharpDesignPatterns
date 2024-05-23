namespace ChainOfResponsibility4Demo;

/// <summary>
/// Class holding request details
/// </summary>
public class Purchase(int number, double amount, string purpose)
{
    // Constructor

    // Gets or sets purchase number
    public int Number { get; set; } = number;

    // Gets or sets purchase amount
    public double Amount { get; set; } = amount;

    // Gets or sets purchase purpose
    public string Purpose { get; set; } = purpose;
}