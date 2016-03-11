namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutduneligneJPA : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.RecipeDBs VALUES('00000000-0000-0000-0000-000000000000', 'JPA')");

        }

        public override void Down()
        {
           
        }
    }
}
