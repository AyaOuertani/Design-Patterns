using Prototype.RecipesBook;
using Prototype.RecipesRegistry;

namespace Prototype.Extension
{
    public static class ProgramExtension
    {
        private static int choice;
        public static void UserChoiceTreatment(ref RecipeBook book, ref RecipeRegistry registry, ref bool running)
        {
            Console.WriteLine("Recipe Book Menu:");
            Console.WriteLine("1. View all recipes\n2. Create new recipe from prototype\n3. View available prototypes\n4. Exit");
            Console.Write("Enter your choice (1-4): ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("All Recipes:");
                    book.DisplayAllRecipes();
                    break;
                case 2:
                    Console.WriteLine("Enter the name of the Recipe to clone:");
                    book.CreateRecipeFromProtype(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Available Prototypes:");
                    foreach (var key in registry.GetAllRecipesName())
                    {
                        Console.WriteLine(key);
                    }
                    break;
                case 4:
                    running = false;
                    Console.WriteLine("Thank You For Cheking Our Recipe Book !\n See You Next Time :) !!");
                    break;
            }

        }
    }
}
