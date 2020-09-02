using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance ;

        private Singleton()
        {
            Console.WriteLine("This is a Singleton pattern.");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                 _instance = new Singleton();
            }

            return _instance;
        }
    }
}
