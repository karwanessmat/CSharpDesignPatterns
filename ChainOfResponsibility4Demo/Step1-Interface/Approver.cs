namespace ChainOfResponsibility4Demo
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>

   public abstract class Approver(Approver successor)
   {
        protected Approver Successor = successor;


        public abstract void ProcessRequest(Purchase purchase);
    }
}
