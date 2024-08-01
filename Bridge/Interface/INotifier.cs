using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Interface
{
    public interface INotifier
    {
        public void SendMessage(string message, string priority = "Normal");
    }
}
