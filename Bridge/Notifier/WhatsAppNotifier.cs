using Bridge.Interface;

namespace Bridge.Notifier
{
    public class WhatsAppNotifier : INotifier
    {
        public void SendMessage(string message,string priority = "Normal")
        {
            Console.WriteLine($"WhatsApp message : {message}\n");
        }
    }
}
