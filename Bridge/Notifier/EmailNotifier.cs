using Bridge.Interface;

namespace Bridge.Notifier
{
    public class EmailNotifier : INotifier
    {
        public void SendMessage(string message,string priority = "Normal")
        {
            Console.WriteLine($"Email message : {message}\n");
        }
    }
}
