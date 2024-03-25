using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1Demo
{
    public sealed class LazySingleton
    {
        private static int _count;
        private static  readonly  Lazy<LazySingleton> Instance = new Lazy<LazySingleton>(()=>new LazySingleton());

        public static LazySingleton GetInstance => Instance.Value;

        private LazySingleton()
        {
            Console.WriteLine(++_count);
        }

        public void DisplayMsg(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}
