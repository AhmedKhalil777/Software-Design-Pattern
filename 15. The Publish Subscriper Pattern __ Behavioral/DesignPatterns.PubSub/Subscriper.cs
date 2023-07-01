namespace DesignPatterns.PubSub
{
    public class Subscriper
    {
        public Subscriper(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Subscripe(Publisher publisher)
        {
            publisher._myEvent += Update;
        }

        public void UnSubscripe(Publisher publisher)
        {
            publisher._myEvent -= Update;
        }

        public void Update(object sender, EventArgumants args)
        {
            var pub = (Publisher)sender;
            System.Console.WriteLine(Name + "   ------  Channel");
            System.Console.WriteLine("============================================");
            System.Console.WriteLine(pub.Name + " Said that: " + args.Message);
            System.Console.WriteLine("============================================");
        }


    }
}