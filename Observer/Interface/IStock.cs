public interface IStock
{
    void RegisterObserver(IStockObserver observer);
    void RemoveObserver(IStockObserver observer);
    void NotifyObservers();
}
