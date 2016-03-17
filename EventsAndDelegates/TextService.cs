namespace EventsAndDelegates
{
    using System;

    public class TextService
    {
        public void SendTextMessage(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Sending Text message:" + args.Video.Title);
        }
    }
}
