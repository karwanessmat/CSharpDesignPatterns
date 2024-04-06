namespace Singleton5Demo
{
    public class SomeBusinessLogic
    {
        public void Process()
        {
            Logger.Instance.Log("Process started");
            Console.WriteLine("process is running");
            Logger.Instance.Log("Process finished successfully.");
        }
    }
}
