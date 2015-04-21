namespace PizzaProjectAlt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PizzaProjectAlt.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaProjectAlt.Models.DefaultConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaProjectAlt.Models.DefaultConnection context)
        {
            context.Pizzas.AddOrUpdate(i => i.pizzaName,
                new Pizza
                {
                    userID = "testUser1@example.com",
                    pizzaName = "The Classic",
                    doughType = "Plain",
                    sauceType = "Tomato",
                    cheeseType = "Mozzarella",
                    toppingOne = "Pepperoni",
                    toppingTwo = "Pepperoni",
                    toppingThree = "Pepperoni",
                    toppingFour = "Pepperoni",
                    toppingFive = "Pepperoni"
                }
                );
            

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
