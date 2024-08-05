using Observer.Interface;

namespace Observer.Subscribers
{
    public class NewsAgency : IStockObserver
    {
        public void Update(string symbol, float price)
        {
            Console.WriteLine($"News Agency reports: {symbol} price is now {price}");
        }
    }

}
