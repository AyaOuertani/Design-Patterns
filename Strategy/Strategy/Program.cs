using Strategy.Shipping_Context;
using Strategy.Shipping_Strategy;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Standard Strategy :");
            ShippingContext shippingContext = new ShippingContext(new StandardShipping());
            Console.WriteLine(shippingContext.SendDetails());

            Console.WriteLine("Express Strategy :");
            shippingContext.SetShippingStrategy(new ExpressShipping());
            Console.WriteLine(shippingContext.SendDetails());

            Console.WriteLine("Same Day Strategy :");
            shippingContext.SetShippingStrategy(new SameDayShipping());
            Console.WriteLine(shippingContext.SendDetails());
        }
    }
}