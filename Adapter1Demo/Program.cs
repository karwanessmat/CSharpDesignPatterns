namespace Adapter1Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}
