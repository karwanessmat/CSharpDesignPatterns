namespace Memento1Demo
{
    public class Calculator
    {
        private int _result;


        public void SetResult(int i = 0)
        {
            _result = i;
        }

        public void Add(int x)
        {
            _result += x;
        }

        public void Subtract(int x)
        {
            _result -= x;
        }

        public int GetResult()
        {
            return _result;
        }



        public Memento CreateMemento()
        {
            var memento = new Memento();
            memento.SetState(_result);
            return memento;
        }


        public void SaveState(Memento memento)
        {
            _result = memento.GetState();
        }
    }
}
