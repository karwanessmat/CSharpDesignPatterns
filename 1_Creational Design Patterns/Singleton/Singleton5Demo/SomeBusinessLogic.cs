namespace Singleton5Demo;

public class SomeBusinessLogic
{
    public void Process()
    {
        var logger =Logger.Instance;
        logger.Log("Process started");
        Console.WriteLine("process is running");
        Logger.Instance.Log("Process finished successfully.");
    }
}