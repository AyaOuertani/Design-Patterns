using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Shipping_Strategy
{
    public class SameDayShipping : IShippingStrategy
    {
        public string GetShippingDetails()
        {
            return "Same-Day Shipping: Delivery today if ordered before 4 PM.";
        }
    }
}
