namespace Facade.SubSystem
{
    public class DeleveryManagement
    {
        private Dictionary<int, DeliveryInfo> _Deliveries = new Dictionary<int, DeliveryInfo>();
        public string AsignDriver(int orderRef)
        {
            DeliveryInfo deliveryInfo = new DeliveryInfo(orderRef, "John Doe", "Out for delivery");
            _Deliveries.Add(orderRef, deliveryInfo);
            return "Order Assigned Successfully";
        }
        public string TrackDelivery(int orderRef)
        {
            if (_Deliveries.ContainsKey(orderRef))
            {
                return $"Order {orderRef} is {_Deliveries[orderRef].Status} with driver {_Deliveries[orderRef].Driver}.";
            }
            return "Order not found.";
        }
        public void ConfirmDelivery(int orderRef)
        {
            if (_Deliveries.ContainsKey(orderRef))
            {
                _Deliveries[orderRef].Status = "Delivered";
            }
        }
    }
}
