using System;

namespace ChainOfResponsibility4Demo
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class VicePresident(Approver successor) : Approver(successor)
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 20000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else
            {
                Successor?.ProcessRequest(purchase);
            }
        }
    }
}
