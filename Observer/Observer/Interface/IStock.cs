using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interface
{
    public interface IStock
    {
            void RegisterObserver(IStockObserver observer);
            void RemoveObserver(IStockObserver observer);
            void NotifyObservers();

    }
}
