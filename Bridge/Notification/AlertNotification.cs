using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public class AlertNotification : Notifications
    {
        public AlertNotification(INotifier notifier) : base(notifier) { }
        public override void Notify(string message, string priority = "Normal")
        {
            Notifier.SendMessage($"Alert : {message} , Priority : {priority}");
        }
    }
}
