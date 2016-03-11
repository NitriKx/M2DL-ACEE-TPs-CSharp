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
    public class AdoRecipeService: AbstractRecipeService
    {
        public override List<Recipe> GetRecipes()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Model"].ToString());
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "select * from recipedbs"
            };

            var reader = command.ExecuteReader();
            var recipes = new List<Recipe>();

            while (reader.Read())
            {
                recipes.Add(
                    new Recipe
                    {
                        Id = Guid.Parse(reader["id"].ToString()),
                        Title = (string)reader["name"]
                    }
                );
            }
            return recipes;
        }
    }
}
