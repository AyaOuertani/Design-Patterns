using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public abstract class Notifications
    {
        protected INotifier Notifier ;
        protected Notifications(INotifier notifier) 
        {
            Notifier = notifier;
        }
        public abstract void Notify(string message, string priority = "Normal");
    }
}
