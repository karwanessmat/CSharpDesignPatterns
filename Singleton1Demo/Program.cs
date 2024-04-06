using System;
using System.Threading.Tasks;

namespace Singleton1Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //it created 2 instance to stop this action we should create lock in related class go to (singleton class)
            Parallel.Invoke(() =>
            {
                var s1 = Singleton.GetInstance;
                s1.DisplayMessage("S1");
            }, () =>
            {
                var s2 = Singleton.GetInstance;
                s2.DisplayMessage("S2");
            });

            Console.WriteLine("_______________");
            Console.WriteLine("Lazy Singleton");

            Parallel.Invoke(() =>
            {
                var lz1 = LazySingleton.GetInstance;
                lz1.DisplayMsg("Lazy Singleton1");
            }, () =>
            {
                var lz2 = LazySingleton.GetInstance;
                lz2.DisplayMsg("Lazy Singleton2");
            }, () =>
             {
                 var lz3 = LazySingleton.GetInstance;
                 lz3.DisplayMsg("Lazy Singleton3");

             });







        }

        /// <summary>
        /// this is an example if we want to call
        /// </summary>

        public static void Print()
        {
            var ss = Singleton.GetInstance;
            ss.DisplayMessage("hi");
        }
    }
}
