namespace Singleton5Demo;

public class Logger
{
    private static Logger? _instance;
    private static readonly object _lockObj = new object();

    private readonly StreamWriter _logStream;

    private Logger()
    {
        _logStream = new StreamWriter("app.log", append: true)
        {
            AutoFlush = true
        };
    }

    public static Logger? Instance
    {
        get
        {
            lock (_lockObj)
            {
                _instance ??= new Logger();
            }
        

            return _instance;
        }
    }

    public void Log(string message)
    {

        _logStream.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
    }
}