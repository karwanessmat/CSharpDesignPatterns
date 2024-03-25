namespace ChainOfResponsibility4Demo
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Purchase
    {
        // Constructor
        public Purchase(int number, double amount, string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }

        // Gets or sets purchase number
        public int Number { get; set; }

        // Gets or sets purchase amount
        public double Amount { get; set; }

        // Gets or sets purchase purpose
        public string Purpose { get; set; }
    }
}
