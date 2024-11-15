using System.Threading.Tasks;

namespace Singleton1Demo;

internal class Program
{
    private static void Main(string[] args)
    {

        //it created 2 instance to stop this action we should create lock in related class go to (singleton class)
        Parallel.Invoke(() =>
        {
            Singleton s1 = Singleton.GetInstance;
            s1.DisplayMessage("S1");
        }, () =>
        {
            Singleton s2 = Singleton.GetInstance;
            s2.DisplayMessage("S2");
        });

         
        Singleton ss1 = Singleton.GetInstance;
        ss1.DisplayMessage("Msg");

    }

    /// <summary>
    /// this is an example if we want to call
    /// </summary>

    public static void Print()
    {
        Singleton ss = Singleton.GetInstance;
        ss.DisplayMessage("hi");
    }
}