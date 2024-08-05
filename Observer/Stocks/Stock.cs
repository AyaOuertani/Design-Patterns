using System;
using System.Collections.Generic;

public class Stock : IStock
{
    private List<IStockObserver> observers;
    private string symbol;
    private float price;

    public Stock(string symbol, float price)
    {
        this.symbol = symbol;
        this.price = price;
        observers = new List<IStockObserver>();
    }

    public void RegisterObserver(IStockObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IStockObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(symbol, price);
        }
    }

    public void SetPrice(float price)
    {
        this.price = price;
        NotifyObservers();
    }
}
