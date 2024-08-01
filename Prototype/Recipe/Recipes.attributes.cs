using Microsoft.VisualBasic;
using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype.Recipe
{
    public partial class Recipes : IRecipePrototype
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string  Instructions {  get; set; }
    }
}
