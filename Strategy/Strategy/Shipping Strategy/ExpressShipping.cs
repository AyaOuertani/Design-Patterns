using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Shipping_Strategy
{
    public class ExpressShipping : IShippingStrategy
    {
        public string GetShippingDetails()
        {
            return "Express Shipping: Delivery in 2-3 days.";
        }
    }
}
