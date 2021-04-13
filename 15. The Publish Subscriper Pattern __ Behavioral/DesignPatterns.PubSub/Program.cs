using System;

namespace DesignPatterns.PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            var mohammad = new Publisher { Name = "Mohammad"};
            var salem = new Publisher { Name = "Salem"};
            var ibrahim = new Subscriper("Ibrahim");
            var khalid = new Subscriper("Khalid");
            var malek = new Subscriper("Malek");



            ibrahim.Subscripe(mohammad);
            khalid.Subscripe(mohammad);
           
            malek.Subscripe(salem);
            mohammad.Notify("Hello Ya regala");

            salem.Notify("Hello  malek");

            khalid.UnSubscripe(mohammad);
            mohammad.Notify("is khalid close channel");

        }
    }
}
