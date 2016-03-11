using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using DataContract;

namespace Service
{
    public class JsonRecipeService: AbstractRecipeService
    {
        public override List<Recipe> GetRecipes()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Recipe>));
            var fs = File.OpenRead("recipes.json");
            return (List<Recipe>)serializer.ReadObject(fs);
        }
    }
}
