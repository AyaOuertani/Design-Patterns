using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interface
{
    public interface IPizzaBuilder
    {
        public void Type(string type);
        public void Size(string size);
        public void Cheese(string cheese);
        public void Toppings(string Toppings);
    }
}
