using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
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
}
