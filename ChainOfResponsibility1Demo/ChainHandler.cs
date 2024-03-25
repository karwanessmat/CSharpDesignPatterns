namespace ChainOfResponsibility1Demo
{
  public abstract  class ChainHandler
    {
       public ChainHandler successor;
        public void SetSuccessor(ChainHandler successor)
        {
            this.successor = successor;
        }
        public abstract void HandlerRequest(int request);
    }
}
