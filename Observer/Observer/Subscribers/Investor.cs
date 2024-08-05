using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
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
}
