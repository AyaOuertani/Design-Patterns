public class Program
{
    public static void Main(string[] args)
    {
        Stock appleStock = new Stock("AAPL", 150.00f);

        Investor investor1 = new Investor("Alice");
        Investor investor2 = new Investor("Bob");
        Broker broker = new Broker("Eve");
        NewsAgency newsAgency = new NewsAgency();

        appleStock.RegisterObserver(investor1);
        appleStock.RegisterObserver(investor2);
        appleStock.RegisterObserver(broker);
        appleStock.RegisterObserver(newsAgency);

        appleStock.SetPrice(152.00f);
        appleStock.SetPrice(149.00f);
        appleStock.SetPrice(155.50f);
    }
}
