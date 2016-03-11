using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RecipeServices
    {

        public List<DataContract.Receipe> getReceipes()
        {
            return new List<DataContract.Receipe>
            {
                new DataContract.Receipe
                {
                    ID = Guid.NewGuid(),
                    Title = "Recipe 01",
                    Directions = new List<string>
                    {
                        "un", "deux", "trois", "quatre"
                    }
                },
                new DataContract.Receipe
                {
                    ID = Guid.NewGuid(),
                    Title = "Recipe 02",
                    Directions = new List<string>
                    {
                        "un", "deux", "trois", "quatre"
                    }
                }
            };
        }

    }
}
