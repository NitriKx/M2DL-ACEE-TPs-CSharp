using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContract;

namespace Service
{
    public class MemoryRecipeService: AbstractRecipeService
    {
        public override List<Recipe> GetRecipes()
        {
            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Title = "Recipe 01",
                    Directions = new List<string>
                    {
                        "Un", "deux", "trois"
                    }
                },
                new Recipe()
                {
                    Id = Guid.NewGuid(),
                    Title="Recipe 02",
                    Directions = new List<string>
                    {
                        "Un", "deux", "trois", "quatre"
                    }
                },
                new Recipe()
                {
                    Id = Guid.NewGuid(),
                    Title="Recipe 03",
                    Directions = new List<string>
                    {
                        "Un", "deux", "trois", "quatre", "cinq"
                    }
                }
            };

            return recipes;

        }
    }
}
