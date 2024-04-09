using System;
using ChainOfResponsibility4Demo.Step1_Interface;

namespace ChainOfResponsibility4Demo.step2_Concrete_Handlers
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
