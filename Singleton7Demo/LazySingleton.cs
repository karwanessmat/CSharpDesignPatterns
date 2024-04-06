namespace Singleton7Demo
{
    public sealed class LazySingleton
    {
        private static int _count;
        private static  readonly  Lazy<LazySingleton> Instance = new(()=>new LazySingleton());

        public static LazySingleton GetInstance => Instance.Value;

        private LazySingleton()
        {
        }

        public void DisplayMsg(string msg)
        {
            Console.WriteLine($"{msg} - instance {++_count} ");
        }


    }
}
