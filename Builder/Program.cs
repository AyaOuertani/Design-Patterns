using Builder.PizzaBuilder;
using Builder.PizzaProduct;
using Builder.Director;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaBuilder = new ConcretePizzaBuilder();
            var director = new PizzaDirector(pizzaBuilder);

            Console.WriteLine("Pizza Type");
            string type = Console.ReadLine();

            Console.WriteLine("Choose Size (Small, Medium, Large):");
            string size = Console.ReadLine();

            Console.WriteLine("Choose Cheese (Mozzarella, Cheddar, Vegan):");
            string cheese = Console.ReadLine();

            Console.WriteLine("Choose Toppings (type 'done' to finish):");
            List<string> toppings = new List<string>();
            while (true)
            {
                string topping = Console.ReadLine();
                if (topping.ToLower() == "done")
                    break;
                toppings.Add(topping);
            }
            director.ConstractPizza(size, type, cheese, toppings);
            Pizza pizza = pizzaBuilder.PrepareOrder();

            Console.WriteLine("Your custom pizza:");
            Console.WriteLine(pizza);
        }
    }

}