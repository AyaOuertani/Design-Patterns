using Prototype.Recipe;
using Prototype.RecipesBook;
using Prototype.RecipesRegistry;
using Prototype.Extension;

namespace Prototype {
    public class Program
    {
        public static bool running = true;
        public static void Main(string[] args)
        {
            RecipeRegistry registry = new RecipeRegistry();

            registry.RegisterRecipePrototype("Pasta Alfredo", new Recipes("Pasta Alfredo", new List<string> { "Pasta", "Cream", "Cheese" }, "Cook pasta and mix with cream and cheese."));
            registry.RegisterRecipePrototype("Caesar Salad", new Recipes("Caesar Salad", new List<string> { "Lettuce", "Tomato", "Caesar Dressing" }, "Mix lettuce with Tomato and dressing."));

            RecipeBook book = new RecipeBook(registry);


            while (running)
            {
                ProgramExtension.UserChoiceTreatment(ref book, ref registry, ref running);
                Console.WriteLine("\n");
            }
        }
    }
}