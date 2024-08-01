using Prototype.Interface;
using Prototype.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.RecipesRegistry
{
    public class RecipeRegistry
    {
        private readonly Dictionary<string, IRecipePrototype> _recipesPrototype = new Dictionary<string, IRecipePrototype>();
        public void RegisterRecipePrototype (string RecipeName,IRecipePrototype recipePrototype)
        {
            _recipesPrototype[RecipeName] = recipePrototype; 
        }
        public IRecipePrototype GetRecipePrototype(string RecipeName)
        {
            if (_recipesPrototype.TryGetValue(RecipeName,out IRecipePrototype? recipePrototype)) 
            { 
                return recipePrototype.Clone ();
            }
            throw new KeyNotFoundException($"Recipe with name {RecipeName} cannot be found !");
        }
        public IEnumerable<string> GetAllRecipesName()
        {
            return _recipesPrototype.Keys;
        }

    }
}
