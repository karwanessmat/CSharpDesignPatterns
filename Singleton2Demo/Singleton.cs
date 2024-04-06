namespace Singleton2Demo;

public class Singleton
{

    // 1. A private static variable to hold the single instance
    private static Singleton _instance;

    // 2. The constructor is private so it cannot be instantiated outside this class
    private Singleton()
    {
        // Initialization code, such as setting up a database connection, goes here
    }

    // 3. A public static method to get the instance
    public static Singleton GetInstance()
    {
        // 4. Lazy initialization - the instance is created the first time this method is called
        if (_instance is null)
        {
            // If you're using multithreading, you'll need to lock this part of the code to make sure
            // the instance is only created once
            _instance = new Singleton();
            _instance = new Singleton();
        }

        // Return the existing instance
        return _instance;
    }

    public void DoSomething()
    {
        // Method Implementation
    }

}