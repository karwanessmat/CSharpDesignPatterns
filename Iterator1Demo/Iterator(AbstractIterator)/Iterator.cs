namespace Iterator1Demo.Iterator_AbstractIterator_
{
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
   public abstract class Iterator

    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
