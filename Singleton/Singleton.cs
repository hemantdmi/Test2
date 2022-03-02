using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    //public class Singleton //R1 part
    public sealed class Singleton
    {
        private static int count = 0;
        private static Singleton _singletonInstance;
        public static readonly object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (_singletonInstance == null)
                {
                    lock (obj)
                    {
                        if (_singletonInstance == null)
                        {
                            _singletonInstance = new Singleton();
                        }
                    }
                }
                return _singletonInstance;
            }
        }
        //public Singleton() //R1 part
        //{
        //    count++;
        //    Console.WriteLine("Counter value = " + count);
        //}

        private Singleton()
        {
            count++;
            Console.WriteLine("Counter value = " + count);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
