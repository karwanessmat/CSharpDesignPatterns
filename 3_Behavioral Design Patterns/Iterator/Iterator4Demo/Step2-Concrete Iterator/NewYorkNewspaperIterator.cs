using Iterator4Demo.Step1_Iterator_Interface;

namespace Iterator4Demo.Step2_Concrete_Iterator
{
    public class NewYorkNewspaperIterator(string[] reporters) :IIterator
    {
        private int _current;

        public void First()
        {
            _current = 0;

        }

        public string Next()
        {
            return !IsDone() ? reporters[_current++] : string.Empty;
        }

        public bool IsDone()
        {
            return _current >= reporters.Length;
        }

        public string CurrentItem()
        {
            return reporters[_current];
        }

        public bool HasNext()
        {
            return _current < reporters.Length;
        }
    }
}
