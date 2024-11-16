namespace Singleton8Demo;

public class LazySingleton
{
    // 1. Using the Lazy<T> type to defer the creation of the instance until it is needed
    private static readonly Lazy<LazySingleton> _lazyInstance = new(()=> new LazySingleton());

    // 2. The private constructor ensures that no more than one instance can be created from outside the class
    private LazySingleton()
    {

    }

    // 3. Public static property to access the instance
    public static LazySingleton Instance = _lazyInstance.Value;

    public void DoAction()
    {
        Console.WriteLine("We did");
    }

}