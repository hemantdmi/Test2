using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region R1
            //Singleton obj1 = new Singleton();
            //obj1.PrintDetails("Value from first object");

            //Singleton obj2 = new Singleton();
            //obj1.PrintDetails("Value from second object"); 
            #endregion

            #region R2
            //Singleton obj1 = Singleton.GetInstance;
            //obj1.PrintDetails("Value from first object");

            //Singleton obj2 = Singleton.GetInstance;
            //obj1.PrintDetails("Value from second object");
            #endregion

            #region R3
            Parallel.Invoke(
                () => M1(),
                () => M2()
                );
            #endregion
        }

        public static void M1()
        {
            Singleton obj1 = Singleton.GetInstance;
            obj1.PrintDetails("Value from first object");
        }

        public static void M2()
        {
            Singleton obj2 = Singleton.GetInstance;
            obj2.PrintDetails("Value from second object");
        }
    }
}
