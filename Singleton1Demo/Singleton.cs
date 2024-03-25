using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1Demo
{
   public  class Singleton
    {
        public static int Count = 0;
        private static Singleton _instance;
        private static readonly  object Obj=new object();
        public static Singleton GetInstance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Obj)
                {
                    _instance ??= new Singleton();
                    //if (_instance == null)
                    //{
                    //    _instance = new Singleton();
                    //}
                }

                return _instance;
            }
            //get { return _instance ??= new Singleton(); }
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


        public class DerivedClass : Singleton
        {

        }
    }


}
