using System;

namespace ConsoleApplication1
{
    public class SubscriberOne
    {
        public void OnEventHandlerOne(Object obj, EventArgs args)
        {
            Console.WriteLine("Subscriber one event triggred");
        }
    }
}