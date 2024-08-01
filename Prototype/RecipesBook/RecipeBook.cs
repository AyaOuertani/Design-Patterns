using Prototype.Interface;
using Prototype.Recipe;
using Prototype.RecipesRegistry;

namespace Prototype.RecipesBook
{
    public class RecipeBook
    {
        private readonly List<IRecipePrototype> _recipes = [];
        private readonly RecipeRegistry _recipeRegistry;
        public RecipeBook(RecipeRegistry recipeRegistry) => _recipeRegistry = recipeRegistry;
        public void AddRecipe(Recipes recipe)
        {
            _recipes.Add(recipe);
        }
        public void CreateRecipeFromProtype(string recipeName)
        {
            try
            {
                IRecipePrototype newPrototype = _recipeRegistry.GetRecipePrototype(recipeName);
                if (newPrototype is Recipes recipe)
                {
                    Console.WriteLine("Do you want to make changes on the recipe (Yes/No):");
                    string makeChange = Console.ReadLine();
                    if (makeChange.ToUpper() == "YES")
                    {
                        ChangeRecipe(recipe);
                    }
                }
                _recipes.Add(newPrototype);
                Console.WriteLine("Recipe Added Successfully !");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key Not Found !!!!!!!!");
            }
        }
        public void ChangeRecipe(Recipes newRecipe)
        {
            Console.WriteLine("Enter The New Name");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                newRecipe.Name = newName;
            }
            Console.WriteLine("Enter new ingredients (comma-separated): ");
            string newIngredients = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newIngredients))
            {
                newRecipe.Ingredients = new List<string>(newIngredients.Split(','));
            }
            Console.WriteLine("Enter new instructions: ");
            string newInstructions = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newInstructions))
            {
                newRecipe.Instructions = newInstructions;
            }
        }
        public void DisplayAllRecipes()
        {
            if (_recipes.Count == 0)
            {
                Console.WriteLine("OOppsi Still Empty ! No Recipes Found !");
            }
            else
            {
                foreach (IRecipePrototype recipe in _recipes)
                {
                    Console.WriteLine(recipe.RecipeDetails(), "\n");
                }
            }
        }
    }
}

