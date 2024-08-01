﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interface
{
    public interface IRecipePrototype
    {
        public IRecipePrototype Clone();
        public string RecipeDetails();
    }
}
