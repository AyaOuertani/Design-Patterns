using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Recipe
{
    public partial class Recipes : IRecipePrototype
    {
        public Recipes(string name, List<string> ingredients, string instractions)
        {
            Name = name;
            Ingredients = new List<string>(ingredients);
            Instructions = instractions;
        }
        public IRecipePrototype Clone()
        {
            return new Recipes(Name, new List<string>(Ingredients), Instructions);
        }

        public string RecipeDetails()
        {
            return $"Recipe: {Name}\nIngredients: {string.Join(", ", Ingredients)}\nInstructions: {Instructions}";
        }
    }
}

