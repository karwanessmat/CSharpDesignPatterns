using System;

namespace ChainOfResponsibility4Demo
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>

   public class President(Approver successor) : Approver(successor)
   {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 30000)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else

            {
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    purchase.Number);
            }
        }
    }
}
