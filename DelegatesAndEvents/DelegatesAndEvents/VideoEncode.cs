using System;
using System.Threading;

namespace ConsoleApplication1
{
    public class VideoEncode
    {
        // This publisher need raise event for subsribers
        // 1. Define delegate
        // 2. Define event.
        // 3. Raise event. 
        public delegate void videoEncodedEventHandler(Object source, EventArgs args);

        public event videoEncodedEventHandler videoEncoded;

        public void videoEncode(Video video)
        {
            Console.WriteLine("video name" + video.videoname);
            Thread.Sleep(3000);
            OnvideoEncoded();
        }

        protected virtual void OnvideoEncoded()
        {
            if (videoEncoded != null)
                videoEncoded(this, EventArgs.Empty);
        }
    }
}