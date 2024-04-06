using System;

namespace Singleton1Demo
{
   public  class Singleton
    {
        public static int Count;
        private static Singleton _instance;
        private static readonly  object Obj=new();
        public static Singleton GetInstance
        {
            get
            {
                if (_instance != null) 
                    return _instance;

                lock (Obj)
                {
                    _instance ??= new Singleton();
                }

                return _instance;
            }
        }
        private Singleton()
        {
            Count++;
            Console.WriteLine(Count);
        }
        public void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }


    }


}
