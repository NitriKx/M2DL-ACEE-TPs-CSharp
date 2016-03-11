namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.Model context)
        {

            context.Recipes.AddOrUpdate(
              p => p.Id,
              new RecipeDB { Id = Guid.Parse("EE4C3AE1-24EC-4CED-B1D7-D37EC5410719"), Name = "Recette1" },
              new RecipeDB { Id = Guid.Parse("EE4C3AE1-24EC-4CED-B1D7-D37EC5410711"), Name = "Recette2" },
              new RecipeDB { Id = Guid.Parse("EE4C3AE1-24EC-4CED-B1D7-D37EC5410712"), Name = "Recette3" }
            );

        }
    }
}
