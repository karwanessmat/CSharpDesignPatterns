namespace ChainOfResponsibility4Demo
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>

   public abstract class Approver
    {
        protected Approver Successor;

        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
