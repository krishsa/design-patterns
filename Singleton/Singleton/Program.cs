using System;

namespace Singleton
{
class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton s1 = Singleton.GetInstance();
              
            Console.ReadLine();
        }

    }
}
