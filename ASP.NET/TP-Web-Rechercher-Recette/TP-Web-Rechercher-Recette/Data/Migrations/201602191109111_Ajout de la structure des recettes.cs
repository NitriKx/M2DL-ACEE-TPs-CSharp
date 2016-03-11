namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajoutdelastructuredesrecettes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecipeDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RecipeDBs");
        }
    }
}
