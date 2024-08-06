using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Shipping_Strategy
{
    public class StandardShipping : IShippingStrategy
    {
        public string GetShippingDetails()
        {
            return " Standard Shipping: Delivery in 5-7 days. ";
        }
    }
}
