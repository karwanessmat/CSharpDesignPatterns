namespace Memento1Demo.Step1__Create_the_Memento_class
{
    public class Memento
    {
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
        }
    }
}
