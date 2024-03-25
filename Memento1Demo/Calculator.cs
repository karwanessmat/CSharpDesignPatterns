namespace Memento1Demo
{
    public class Calculator
    {
        private int result = 0;

        public Calculator(int i =0)
        {
            result = 0;
        }

        public void SetResult(int i = 0)
        {
            result = 0;
        }

        public void Add(int x)
        {
            result += x;
        }

        public void Subtract(int x)
        {
            result -= x;
        }

        public int GetResult()
        {
            return result;
        }



        public Memento CreateMemento()
        {
            var memento = new Memento();
            memento.SetState(result);
            return memento;
        }


        public void SaveState(Memento memento)
        {
            result = memento.GetState();
        }
    }
}
