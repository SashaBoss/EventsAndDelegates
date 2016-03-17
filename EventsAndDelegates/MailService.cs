using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void SendMail(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Sending message:" + args.Video.Title);
        }
    }
}
