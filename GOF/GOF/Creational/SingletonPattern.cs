using System;
using System.Threading;

namespace GOF.Creational
{
    public class SingletonPattern : IUsage
    {
        public class Singleton
        {
            private static readonly Singleton instance = new Singleton();

            public string Date { get; private set; }

            private Singleton()
            {
                Date = DateTime.Now.TimeOfDay.ToString();
            }

            public static Singleton GetInstance()
            {
                return instance;
            }
        }

        public void Usage()
        {
            (new Thread(() =>
            {
                Singleton singleton1 = Singleton.GetInstance();
                Console.WriteLine(singleton1.Date);
            })).Start();

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Date);
        }
    }
}
