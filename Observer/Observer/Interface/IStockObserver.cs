namespace Observer.Interface
{
    public interface IStockObserver
    {
        public void Update(string symbol, float price);


    }
}
