using System;
namespace DesignPatterns.PubSub
{
    public class EventArgumants : EventArgs
    {
        public EventArgumants(string message)
        {
            Message = message;
        }

        public string Message { get;  }
    }
}