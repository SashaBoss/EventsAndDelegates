namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var episode = new Video() { Title = "Futurama s01e02" };
            var encoder = new VideoEncoder();
            var textService = new TextService();
            var mailService = new MailService();

            encoder.VideoEncoded += textService.SendTextMessage;
            encoder.VideoEncoded += mailService.SendMail;

            encoder.Encode(episode);
        }
    }
}
