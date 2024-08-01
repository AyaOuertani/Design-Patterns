using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public class UpdateNotification : Notifications
    {
        public UpdateNotification(INotifier notifier) :base(notifier) { }
        public override void Notify (string message, string priority = "Normal")
        {
            Notifier.SendMessage($"Update : {message} ,  Priority : {priority}");
        }
        
    }
}
