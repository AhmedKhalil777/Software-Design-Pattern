namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        private int _numberOfInstances = 0;

        private Singleton()
        {
            System.Console.WriteLine("Instantiating inside the private constructor");
            _numberOfInstances++;
            System.Console.WriteLine($"Number of instances = {_numberOfInstances}");
        }
        public static Singleton Instance
        {
            get
            {
                System.Console.WriteLine("Getting the instance of Singleton");
                return _instance;
            }
        }



    }
}