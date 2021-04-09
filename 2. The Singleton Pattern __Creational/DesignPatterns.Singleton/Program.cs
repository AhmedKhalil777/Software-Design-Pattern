using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Creating the instance of singleton");
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            if (singleton1 == singleton2)
            {
                System.Console.WriteLine("The Instances are the same");
            }
            else
            {
                System.Console.WriteLine("The instances are different");
            }
        }
    }
}

