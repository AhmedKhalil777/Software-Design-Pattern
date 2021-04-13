using System;

namespace DesignPatterns.PubSub
{
    public class Publisher
    {
        /// <summary>
        /// The Name of Publisher
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Event handler => The Responsible for the handling for the message to send
        /// </summary>
        public event EventHandler<EventArgumants> _myEvent;

        /// <summary>
        /// Once the message is sent from a publisher , the subscriper to that publisher can listen to message
        /// </summary>
        /// <param name="message"> Message to sent </param>
        public void Notify(string message)
        {
            var args = new EventArgumants(message);
            if (args is not null)
            {
                _myEvent(this, args);
            }
        }

    }
}