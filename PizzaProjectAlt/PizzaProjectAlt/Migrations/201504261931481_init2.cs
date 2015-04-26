namespace PizzaProjectAlt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        pizzaID = c.Int(nullable: false, identity: true),
                        userID = c.String(),
                        pizzaName = c.String(),
                        bacon = c.Boolean(nullable: false),
                        bpeppers = c.Boolean(nullable: false),
                        blackOlives = c.Boolean(nullable: false),
                        cheese = c.Boolean(nullable: false),
                        chicken = c.Boolean(nullable: false),
                        dough = c.Boolean(nullable: false),
                        gpeppers = c.Boolean(nullable: false),
                        ham = c.Boolean(nullable: false),
                        pepperoni = c.Boolean(nullable: false),
                        pineapple = c.Boolean(nullable: false),
                        sauce = c.Boolean(nullable: false),
                        sausage = c.Boolean(nullable: false),
                        spinnach = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pizzaID);
            

        }
        
        public override void Down()
        {
            DropTable("dbo.Pizzas");
        }
    }
}
