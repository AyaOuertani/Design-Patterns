using Strategy.Interface;

namespace Strategy.Shipping_Context
{
    public class ShippingContext
    {
        private IShippingStrategy _shippingStrategy;
        public ShippingContext(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
        public string SendDetails()
        {
            return _shippingStrategy.GetShippingDetails();
        }
    }
}
