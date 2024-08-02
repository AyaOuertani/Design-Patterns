using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystem
{
    public class DeliveryInfo
    {
        public int OrderRef {  get; set; }
        public string Driver {  get; set; }
        public string Status { get; set; }
        public DeliveryInfo(int orderRef, string driver, string status)
        {
            OrderRef = orderRef;
            Driver = driver;
            Status = status;
        }
    }

}
