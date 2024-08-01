using Bridge.Interface;
using Bridge.Notification;
using Bridge.Notifier;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            INotifier emailNotifier = new EmailNotifier();
            INotifier smsNotifier = new SmsNotifier();
            INotifier whatsAppNotifier = new WhatsAppNotifier();
            Notifications alertEmail = new AlertNotification(emailNotifier);
            Notifications updateSMS = new UpdateNotification(smsNotifier);
            Notifications reminderWhatsUp = new ReminderNotification(whatsAppNotifier);
            Notifications reminderEmail = new ReminderNotification(emailNotifier);


            alertEmail.Notify("Server is down!", "High");
            updateSMS.Notify("New feature released.");
            reminderWhatsUp.Notify("Meeting at 11 AM", "High");
            reminderEmail.Notify("You Have Important Email You Didn't Replay To !!", "High");

        }
    }
}