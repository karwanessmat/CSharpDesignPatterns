namespace Adapter2Demo
{
    public interface ITarget
    {
        string Request();
    }


    public class Adaptee
    {
        public string SpecificRequest()
        {
            return "Method inside Adaptee Class";
        }
    }


    public  class  Adapter:ITarget
    {
        private Adaptee adaptee;

        //public Adapter()
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string Request()
        {
            return $"this is from {adaptee.SpecificRequest()}";
        }
    }
}
