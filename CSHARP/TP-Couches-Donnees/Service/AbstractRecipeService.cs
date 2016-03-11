using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContract;

namespace Service
{
    public abstract class AbstractRecipeService
    {
        public abstract List<Recipe> GetRecipes();
    }
}
