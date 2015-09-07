using System;

namespace ConsoleApplication1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var video = new Video {videoname = " Justin Biber "};
            var VE = new VideoEncode(); // Publisher 
            var SO = new SubscriberOne(); // Subscriber 
            var ST = new SubscriberTwo(); // Subscriber

            // We need to bind these subscribers to Event
            VE.videoEncoded += ST.OnEventHandlerTwo;
            VE.videoEncoded += SO.OnEventHandlerOne;

            VE.videoEncode(video);
            Console.ReadLine();
        }
    }
}