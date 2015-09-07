using System;

namespace ConsoleApplication1
{
    public class SubscriberTwo
    {
        public void OnEventHandlerTwo(Object obj, EventArgs args)
        {
            Console.WriteLine("Subscriber Two event triggred");
        }
    }
}