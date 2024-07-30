using Builder.Interface;
using Builder.PizzaProduct;

namespace Builder.PizzaBuilder
{
    public class ConcretePizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new();
        public void Type(string type) => _pizza.Type = type;
        public void Size(string size) => _pizza.Size = size;
        public void Cheese(string cheese) => _pizza.Cheese = cheese;
        public void Toppings(string toppings) => _pizza.AddTopping(toppings);
        public Pizza PrepareOrder() => _pizza;
    }
}
