using Facade.Facade;
using Facade.SubSystem;

public class Client
{
    public static void Main(string[] args)
    {
        RestaurantFacade facade = new RestaurantFacade();

        List<Dish> menu = facade.GetMenu();
        foreach (Dish dish in menu)
        {
            Console.WriteLine($"{dish.Name}: {dish.Price} - {dish.Description}");
        }

        List<Dish> orderItems = new List<Dish> { menu[0], menu[2] };
        Order order = facade.CreateOrder(orderItems);
        Console.WriteLine($"Order Reference: {order.OrderReference} placed successfully.");
        facade.CheckOrder(order.OrderReference);
        string trackingOrderInfo = facade.TrackOrder(order.OrderReference);
        Console.WriteLine(trackingOrderInfo);
        facade.ConfirmDelivery(order.OrderReference);
        Console.WriteLine("Order delivery confirmed.");
    }
}
