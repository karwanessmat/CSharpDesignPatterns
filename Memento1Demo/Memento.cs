namespace Memento1Demo
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
