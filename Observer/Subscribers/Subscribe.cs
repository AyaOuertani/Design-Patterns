public class Investor : IStockObserver
{
    private string name;

    public Investor(string name)
    {
        this.name = name;
    }

    public void Update(string symbol, float price)
    {
        Console.WriteLine($"Investor {name} notified. {symbol} price is now {price}");
    }
}

public class Broker : IStockObserver
{
    private string name;

    public Broker(string name)
    {
        this.name = name;
    }

    public void Update(string symbol, float price)
    {
        Console.WriteLine($"Broker {name} notified. {symbol} price is now {price}");
    }
}

public class NewsAgency : IStockObserver
{
    public void Update(string symbol, float price)
    {
        Console.WriteLine($"News Agency reports: {symbol} price is now {price}");
    }
}
