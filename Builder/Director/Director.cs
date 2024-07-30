using Builder.Interface;

using System.Drawing;

namespace Builder.Director
{
    internal class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }
        public void ConstractPizza(string size, string type, string cheese, List<string> toppings)
        {
            _builder.Size(size);
            _builder.Type(type);
            _builder.Cheese(cheese);
            foreach (string topping in toppings)
            {
                _builder.Toppings(topping);
            }
        }
        public void PizzaPapperoniBuilder ()
        {
            _builder.Type("Pepperoni");
            _builder.Cheese("Mozzarella");
        }
    }
}
