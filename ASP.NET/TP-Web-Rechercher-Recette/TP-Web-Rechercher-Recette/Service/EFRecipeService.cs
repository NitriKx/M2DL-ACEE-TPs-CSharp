using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using DataContract;

namespace Service
{
    public class EFRecipeService: AbstractRecipeService
    {
        public override List<Recipe> GetRecipes()
        {
            using (var dbContext = new Data.Model())
            {
                return dbContext
                            .Recipes
                            .Select(r => new Recipe {Id = r.Id, Title = r.Name}).ToList();
            }
        }
    }
}
