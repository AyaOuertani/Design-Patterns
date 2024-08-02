namespace Facade.SubSystem
{
    public class OrderProcessing
    {
        private int _OrderCounter = 1;
        private Dictionary<int, Order> _Orders = new Dictionary<int, Order>();
        public Order CreateOrder(List<Dish> dishes)
        {
            Order order = new Order(_OrderCounter++, dishes, DateTime.Now);
            _Orders.Add(order.OrderReference, order);
            return order;
        }
        public string UpdateOrder(int orderRef, List<Dish> newDishs)
        {
            if (_Orders.ContainsKey(orderRef))
            {
                _Orders[orderRef].Dishes = newDishs;
                return "Updated Successfully";
            }
            return "Order Reference Not Found.";
        }
        public string CancelOreder(int orderRef)
        {
            if (_Orders.ContainsKey(orderRef))
            {
                _Orders.Remove(orderRef);
                return "Delted Successfully.";
            }
            return "Order Reference Not Found .";
        }
        public string GetOrderStatus(int orderRef)
        {
            if (_Orders.ContainsKey(orderRef))
            {
                return "Order is being processed.";
            }
            return "Order not found.";
        }
        public void ShowOrderDetails(int orderRef)
        {
            if (_Orders.ContainsKey(orderRef))
            {
                Order order = _Orders[orderRef];
                Console.WriteLine($"Order ID: {order.OrderReference}");
                Console.WriteLine($"Order Date: {order.OrderDate}");
                Console.WriteLine("Dishes:");
                foreach (Dish dish in order.Dishes)
                {
                    Console.WriteLine($"- {dish.Name}: {dish.Price} - {dish.Description}");
                }
            }
        }
    }
}
