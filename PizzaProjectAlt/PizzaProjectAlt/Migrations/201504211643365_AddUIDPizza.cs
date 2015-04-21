namespace PizzaProjectAlt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUIDPizza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pizzas", "userID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pizzas", "userID");
        }
    }
}
