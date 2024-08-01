using Bridge.Interface;

namespace Bridge.Notifier
{
    public class SmsNotifier : INotifier
    {
        public void SendMessage(string message, string priority = "Normal")
        {
            Console.WriteLine($"SMS Message : {message}\n");
        }
    }
}
